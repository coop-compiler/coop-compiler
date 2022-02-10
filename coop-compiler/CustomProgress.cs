using System.Drawing;
using System.Windows.Forms;

namespace coop_builder
{
    public class CustomProgressBar : ProgressBar
    {
        private Brush foreBrush;
        private Brush backBrush;
        private float x;
        private float speed;

        public CustomProgressBar()
        {
            this.SetStyle(
               ControlStyles.AllPaintingInWmPaint |
               ControlStyles.UserPaint |
               ControlStyles.DoubleBuffer,
               true);
        }

        public void Speed()
        {
            speed += 1;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (this.DesignMode)
            {
                base.OnPaint(e);
                return;
            }

            if (foreBrush == null)
            {
                foreBrush = new SolidBrush(ForeColor);
                backBrush = new SolidBrush(BackColor);
                speed = 1;
            }
            int barWidth = Width / 3;

            Rectangle rec = e.ClipRectangle;
            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);

            e.Graphics.FillRectangle(Brushes.Black, rec.X, rec.Y, rec.Width, rec.Height);

            rec.X += 2;
            rec.Y += 2;
            rec.Width -= 4;
            rec.Height -= 4;
            int totalWidth = rec.Width;

            e.Graphics.FillRectangle(backBrush, rec.X, rec.Y, rec.Width, rec.Height);

            if (speed < 1) { speed = 1; }
            else if (speed > 5) { speed = 5; }
            else { speed *= 0.95f; }

            x += 0.012f * speed;
            if (x >= 1.0f) { x -= 1.0f; }

            float minX = -barWidth;
            float maxX = Width;

            Rectangle draw = new Rectangle();
            draw.Y = rec.Y;
            draw.Height = rec.Height;

            draw.X = (int)(rec.X + minX + (maxX - minX) * x);
            draw.Width = barWidth;

            e.Graphics.FillRectangle(foreBrush, draw.X, draw.Y, draw.Width, draw.Height);
        }
    }
}
