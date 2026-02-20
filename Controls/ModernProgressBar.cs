using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SistemaPOS.Controls
{
    public class ModernProgressBar : Control
    {
        private int _value = 0;
        private int _maximum = 100;
        private int _minimum = 0;
        private int _borderRadius = 6;
        private Color _barColor = Color.FromArgb(52, 152, 219);
        private Color _barColorEnd = Color.FromArgb(41, 128, 185);
        private Color _trackColor = Color.FromArgb(241, 243, 245);

        [Category("Behavior")]
        [DefaultValue(0)]
        public int Value
        {
            get => _value;
            set
            {
                if (value < _minimum) value = _minimum;
                if (value > _maximum) value = _maximum;
                _value = value;
                Invalidate();
            }
        }

        [Category("Behavior")]
        [DefaultValue(100)]
        public int Maximum
        {
            get => _maximum;
            set { _maximum = value; Invalidate(); }
        }

        [Category("Behavior")]
        [DefaultValue(0)]
        public int Minimum
        {
            get => _minimum;
            set { _minimum = value; Invalidate(); }
        }

        [Category("Appearance")]
        [DefaultValue(6)]
        public int BorderRadius
        {
            get => _borderRadius;
            set { _borderRadius = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color BarColor
        {
            get => _barColor;
            set { _barColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color BarColorEnd
        {
            get => _barColorEnd;
            set { _barColorEnd = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color TrackColor
        {
            get => _trackColor;
            set { _trackColor = value; Invalidate(); }
        }

        public ModernProgressBar()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw,
                true);
            Height = 8;
            Width = 200;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle trackRect = new Rectangle(0, 0, Width - 1, Height - 1);

            // Draw track
            using (GraphicsPath trackPath = GetRoundedRect(trackRect, _borderRadius))
            using (SolidBrush trackBrush = new SolidBrush(_trackColor))
            {
                g.FillPath(trackBrush, trackPath);
            }

            // Draw bar
            float range = _maximum - _minimum;
            if (range <= 0) return;
            float percent = (_value - _minimum) / range;
            int barWidth = (int)(trackRect.Width * percent);
            if (barWidth < _borderRadius * 2 && barWidth > 0) barWidth = _borderRadius * 2;
            if (barWidth <= 0) return;

            Rectangle barRect = new Rectangle(0, 0, barWidth, Height - 1);
            using (GraphicsPath barPath = GetRoundedRect(barRect, _borderRadius))
            using (LinearGradientBrush barBrush = new LinearGradientBrush(
                barRect, _barColor, _barColorEnd, LinearGradientMode.Horizontal))
            {
                g.FillPath(barBrush, barPath);
            }
        }

        private GraphicsPath GetRoundedRect(Rectangle rect, int radius)
        {
            int diameter = radius * 2;
            if (diameter > rect.Height) diameter = rect.Height;
            if (diameter > rect.Width) diameter = rect.Width;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
