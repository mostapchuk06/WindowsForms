using System.Drawing;

namespace MyPaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetSize();
        }
        private class PointArray
        {
            private int index = 0;
            private Point[] points;
            public PointArray(int size)
            {
                if(size <= 0) { size = 2; }
                points = new Point[size];
            }
            public void SetPoint(int x, int y)
            {
                if (index >= points.Length)
                    index = 0;
                points[index] = new Point(x, y);
                index++;
            }
            public void ResetPoints()
            {
                index = 0;
            }
            public int GetCountOfpoints()
            {
                return index;
            }
            public Point[] GetPoints()
            {
                return points;
            }
        }
        private bool isMouse = false;
        private PointArray pointArray = new PointArray(2);
        Bitmap bitmap = new(100, 100);
        private Bitmap previousBitmap;
        Graphics graphics;
        Pen pen = new(Color.Black);
        private void SetSize()
        {
            Rectangle rectangle = Screen.PrimaryScreen.Bounds;
            bitmap = new(rectangle.Width, rectangle.Height);
            graphics = Graphics.FromImage(bitmap);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        private Bitmap GetPreviousBitmap()
        {
            return previousBitmap;
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouse = true;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMouse) { return; }
            pointArray.SetPoint(e.X, e.Y);
            if(pointArray.GetCountOfpoints() >= 2)
            {
                graphics.DrawLines(pen, pointArray.GetPoints());
                pictureBox1.Image = bitmap;
                pointArray.SetPoint(e.X, e.Y);
            }

            previousBitmap = (Bitmap)bitmap.Clone();

            if (!isMouse) { return; }
            pointArray.SetPoint(e.X, e.Y);
            if (pointArray.GetCountOfpoints() >= 2)
            {
                graphics.DrawLines(pen, pointArray.GetPoints());
                pictureBox1.Image = bitmap;
                pointArray.SetPoint(e.X, e.Y);
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouse = false;
            pointArray.ResetPoints();
        }
        private void ColorBtn_Click(object sender, EventArgs e)
        {
            pen.Color = ((Button)sender).BackColor;
        }
        private void PaletteBtn_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new();
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
            }
        }

        private void ClearToolStripBtn_Click(object sender, EventArgs e)
        {
            graphics.Clear(pictureBox1.BackColor);
            pictureBox1.Image = bitmap;
        }

        private void PenSize_Scroll(object sender, EventArgs e)
        {
            pen.Width = PenSize.Value;
        }

        private void SaveToolStripBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new();
            save.DefaultExt = ".png";
            save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (save.ShowDialog() == DialogResult.OK)
                pictureBox1.Image.Save(save.FileName);
        }
    }
}