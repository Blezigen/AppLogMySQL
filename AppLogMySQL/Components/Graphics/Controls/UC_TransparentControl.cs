using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace AppLogMySQL.UC_Panels
{
    [Designer(typeof(TransparentControlDesigner))]
    public partial class UC_TransparentControl : UserControl
    {
        public bool drag = false; // Активно ли перетаскивавание 
        private Image backImage = null; // Фоновое Изображение
        private Color fillColor = Color.White; // Цветовой заполнитель
        private Color backColor = Color.Transparent; // Цвет заднего фона
        private Color transpKey = Color.White; // Прозрачный  цвет
        private int opacity = 100; // Прозрачность
        private int lineWidth = 0; // Толщина линий
        private bool glassMode = true; // Стекло?

        public UC_TransparentControl()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                    ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.UserPaint, true);
        }
        [Browsable(false)]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set { base.BackColor = value; }
        }
        [Browsable(false)]
        public override Image BackgroundImage
        {
            get { return base.BackgroundImage; }
            set { base.BackgroundImage = value; }
        }
        public Image BackImage
        {
            get { return this.backImage; }
            set
            {
                this.backImage = value;
                this.Invalidate();
            }
        }
        public Color TranspKey
        {
            get { return this.transpKey; }
            set
            {
                this.transpKey = value;
                this.Invalidate();
            }
        }
        public Color GlassColor
        {
            get { return this.backColor; }
            set
            {
                this.backColor = value;
                this.Invalidate();
            }
        }
        public bool GlassMode
        {
            get { return this.glassMode; }
            set
            {
                this.glassMode = value;
                this.Invalidate();
            }
        }
        public Color FillColor
        {
            get { return this.fillColor; }
            set
            {
                this.fillColor = value;
                this.Invalidate();
            }
        }
        public int LineWidth
        {
            get { return this.lineWidth; }
            set
            {
                this.lineWidth = value;
                this.Invalidate();
            }
        }
        public int Opacity
        {
            get
            {
                if (opacity > 100) { opacity = 100; }
                else if (opacity < 1) { opacity = 0; }
                return this.opacity;
            }
            set
            {
                this.opacity = value;
                this.Invalidate();
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            Graphics g = e.Graphics; // Движок графики

            if (Parent != null && !drag) // Если нет родителя, и не перемещается
            {
                BackColor = Color.Transparent; // Сбрасываем задний фон на прозрачный
                int index = Parent.Controls.GetChildIndex(this); // Получайет индекс дочернего элемента

                for (int i = Parent.Controls.Count - 1; i > index; i--)// пройтись по всем контролам до нашего
                {
                    Control c = Parent.Controls[i];// выбираем контролы по одному
                    if (c.Bounds.IntersectsWith(Bounds) && c.Visible) // определяет пересечен ли наш компонент с контролом
                    {//если да то идем ниже
                        Bitmap bmp = new Bitmap(c.Width, c.Height, g);// создает новый Битмап с параметрами контрола, в области графической прорисовки
                        c.DrawToBitmap(bmp, c.ClientRectangle); // Рисует на контроле наш битмап

                        g.TranslateTransform(c.Left - Left, c.Top - Top); // смещаем  Control.X - this.X, Control.Y - this.Y
                        g.DrawImageUnscaled(bmp, Point.Empty); // Рисует заданное изображение в заданном месте, используя его исходный фактический размер
                        //Структура Point, задающая верхний левый угол формируемого изображения. 
                        g.TranslateTransform(Left - c.Left, Top - c.Top);// смещаем ОБРАТНО this.X - Control.X ,  this.Y-Control.Y
                        bmp.Dispose(); //Освобождаем Битмап
                    }
                }
            }
            else// Иначе просто закрасить задний фон
            {
                g.Clear(Parent.BackColor);
                g.FillRectangle(new SolidBrush(Color.FromArgb(opacity * 255 / 100, GlassColor)),
                                               this.ClientRectangle);
            }

            if (BackImage != null && GlassMode) // Если есть задняя картинка и режим стекла включен
            {
                Bitmap image = new Bitmap(BackImage); // Задаем новую картинку на основе заднего фона
                image.MakeTransparent(TranspKey); // Если это не png то сделать ез нее прозрачный элемент

                float a = (float)opacity / 100.0f; // задаем прозрачность 

                float[][] mtxItens = { // Цветовое определение
                new float[] {1,0,0,0,0},// Red
                new float[] {0,1,0,0,0},// Green
                new float[] {0,0,1,0,0},// Blue
                new float[] {0,0,0,a,0},// Alpha
                new float[] {0,0,0,0,1}};//?
                ColorMatrix colorMatrix = new ColorMatrix(mtxItens);//Определяет матрицу 5 x 5, которая содержит координаты для пространства RGBAW

                ImageAttributes imgAtb = new ImageAttributes();//Содержит сведения о том, каким образом обрабатываются цвета точечных рисунков и метафайлов во время отрисовки. 
                imgAtb.SetColorMatrix(//Задает матрицу настройки цвета для категории по умолчанию.
                colorMatrix,//ColorMatrix
                ColorMatrixFlag.Default,//определяющий тип изображения и цвет, на которые будет влиять матрица настройки цвета. 
                ColorAdjustType.Bitmap); //указывающий категорию, для которой задается матрица настройки цвета. Информация настройки цвета для объектов Bitmap.

                g.DrawImage(//Рисует заданную часть указанного объекта Image в заданном месте, используя заданный размер.
                        image,//Image
                        ClientRectangle,//Rectangle
                        0.0f,//X
                        0.0f,//Y
                        image.Width,//W
                        image.Height,//H
                        GraphicsUnit.Pixel,//GraphicsUnit 
                        imgAtb);//ImageAttributes 
            }
        }
        protected override void OnMove(EventArgs e)
        {
            base.OnMove(e);
            Rectangle pBounds = this.Bounds;
            pBounds.Inflate(pBounds.Width / 2, pBounds.Height / 2);
            this.Invalidate();
            if (this.Parent != null) this.Parent.Invalidate(pBounds, true);
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Rectangle pBounds = this.Bounds;
            pBounds.Inflate(pBounds.Width / 2, pBounds.Height / 2);
            this.Invalidate();
            if (this.Parent != null) this.Parent.Invalidate(pBounds, true);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TranspControl
            // 
            this.Name = "TranspControl";
            this.ResumeLayout(false);

        }

    }
    internal class TransparentControlDesigner : ControlDesigner
    {
        private UC_TransparentControl control;
        protected override void OnMouseDragBegin(int x, int y)
        {
            base.OnMouseDragBegin(x, y);
            control = (UC_TransparentControl)(this.Control);
            control.drag = true;

        }
        protected override void OnMouseLeave()
        {
            base.OnMouseLeave();
            control = (UC_TransparentControl)(this.Control);
            control.drag = false;

        }
    }
}
