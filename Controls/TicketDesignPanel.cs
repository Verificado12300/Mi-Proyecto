using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace SistemaPOS.Controls
{
    public class TicketDesignPanel : Panel
    {
        public TicketDesignPanel()
        {
            DoubleBuffered = true;
            BackColor = Color.White;
        }

        public void RenderForPrint(Graphics g, Rectangle destino, int sourceHeight = 0)
        {
            if (g == null || destino.Width <= 0 || destino.Height <= 0)
            {
                return;
            }

            int logicalHeight = sourceHeight > 0 ? Math.Min(sourceHeight, Height) : Height;
            logicalHeight = Math.Max(1, logicalHeight);

            GraphicsState state = g.Save();
            try
            {
                g.SetClip(destino);
                g.TranslateTransform(destino.X, destino.Y);
                g.ScaleTransform(
                    destino.Width / (float)Math.Max(1, Width),
                    destino.Height / (float)logicalHeight);

                g.CompositingQuality = CompositingQuality.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

                using (var bg = new SolidBrush(Color.White))
                {
                    g.FillRectangle(bg, 0, 0, Width, logicalHeight);
                }

                DrawChildrenRecursive(this, g, Point.Empty);
            }
            finally
            {
                g.Restore(state);
            }
        }

        private static void DrawChildrenRecursive(Control parent, Graphics g, Point offset)
        {
            for (int i = parent.Controls.Count - 1; i >= 0; i--)
            {
                Control c = parent.Controls[i];
                if (!c.Visible)
                {
                    continue;
                }

                Rectangle rect = new Rectangle(offset.X + c.Left, offset.Y + c.Top, c.Width, c.Height);

                if (c is Panel p)
                {
                    if (p.BackColor.A > 0 && p.BackColor != Color.Transparent)
                    {
                        using (var b = new SolidBrush(p.BackColor))
                        {
                            g.FillRectangle(b, rect);
                        }
                    }
                }
                else if (c is Label lbl)
                {
                    using (var b = new SolidBrush(lbl.ForeColor))
                    {
                        if (lbl.AutoSize)
                        {
                            g.DrawString(lbl.Text ?? string.Empty, lbl.Font, b, new PointF(rect.X, rect.Y));
                        }
                        else
                        {
                            using (var sf = CreateStringFormat(lbl.TextAlign))
                            {
                                g.DrawString(lbl.Text ?? string.Empty, lbl.Font, b, rect, sf);
                            }
                        }
                    }
                }
                else if (c is PictureBox pb && pb.Image != null)
                {
                    Rectangle img = GetImageRect(pb, rect);
                    g.DrawImage(pb.Image, img);
                }

                if (c.HasChildren)
                {
                    DrawChildrenRecursive(c, g, new Point(rect.X, rect.Y));
                }
            }
        }

        private static Rectangle GetImageRect(PictureBox pb, Rectangle rect)
        {
            if (pb.Image == null)
            {
                return rect;
            }

            if (pb.SizeMode == PictureBoxSizeMode.StretchImage)
            {
                return rect;
            }

            if (pb.SizeMode == PictureBoxSizeMode.Normal)
            {
                return new Rectangle(rect.X, rect.Y, Math.Min(rect.Width, pb.Image.Width), Math.Min(rect.Height, pb.Image.Height));
            }

            float rw = rect.Width / (float)Math.Max(1, pb.Image.Width);
            float rh = rect.Height / (float)Math.Max(1, pb.Image.Height);
            float ratio = Math.Min(rw, rh);
            int w = Math.Max(1, (int)Math.Round(pb.Image.Width * ratio));
            int h = Math.Max(1, (int)Math.Round(pb.Image.Height * ratio));
            int x = rect.X + (rect.Width - w) / 2;
            int y = rect.Y + (rect.Height - h) / 2;
            return new Rectangle(x, y, w, h);
        }

        private static StringFormat CreateStringFormat(ContentAlignment align)
        {
            var sf = new StringFormat(StringFormatFlags.NoClip)
            {
                Trimming = StringTrimming.None
            };

            switch (align)
            {
                case ContentAlignment.TopLeft:
                    sf.Alignment = StringAlignment.Near;
                    sf.LineAlignment = StringAlignment.Near;
                    break;
                case ContentAlignment.TopCenter:
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Near;
                    break;
                case ContentAlignment.TopRight:
                    sf.Alignment = StringAlignment.Far;
                    sf.LineAlignment = StringAlignment.Near;
                    break;
                case ContentAlignment.MiddleLeft:
                    sf.Alignment = StringAlignment.Near;
                    sf.LineAlignment = StringAlignment.Center;
                    break;
                case ContentAlignment.MiddleCenter:
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    break;
                case ContentAlignment.MiddleRight:
                    sf.Alignment = StringAlignment.Far;
                    sf.LineAlignment = StringAlignment.Center;
                    break;
                case ContentAlignment.BottomLeft:
                    sf.Alignment = StringAlignment.Near;
                    sf.LineAlignment = StringAlignment.Far;
                    break;
                case ContentAlignment.BottomCenter:
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Far;
                    break;
                case ContentAlignment.BottomRight:
                    sf.Alignment = StringAlignment.Far;
                    sf.LineAlignment = StringAlignment.Far;
                    break;
                default:
                    sf.Alignment = StringAlignment.Near;
                    sf.LineAlignment = StringAlignment.Near;
                    break;
            }

            return sf;
        }
    }
}
