using System;
using System.Drawing;
using System.Runtime.Serialization;

namespace Draw.src.Model
{
    [Serializable]
    class TriangleShape : Shape
    {
        public TriangleShape()
        {
        }

        public TriangleShape(RectangleF rect) : base(rect)
        {
        }

        public TriangleShape(Shape shape) : base(shape)
        {
        }

        public override bool Contains(PointF point)
        {
            if (base.Contains(point))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void DrawSelf(Graphics grfx)
        {
            SolidBrush brush = new SolidBrush(FillColor);
            Pen pen = Pen;

            int x = Convert.ToInt32(Rectangle.X);
            int y = Convert.ToInt32(Rectangle.Y);
            int width = Convert.ToInt32(Rectangle.Width);
            int height = Convert.ToInt32(Rectangle.Height);

            Point top = new Point(x + width / 2, y);
            Point right = new Point(x + width, y + width);
            Point left = new Point(x, y + height);

            grfx.FillPolygon(brush, new Point[] { top, right, left });
            grfx.DrawPolygon(pen, new Point[] { top, right, left });
        }
        public TriangleShape(SerializationInfo info, StreamingContext context)
        {
            this.Rectangle = (RectangleF)info.GetValue("rectangle", typeof(RectangleF));
            this.Width = (float)info.GetValue("width", typeof(float));
            this.Height = (float)info.GetValue("height", typeof(float));
            this.Location = (PointF)info.GetValue("location", typeof(PointF));
            this.FillColor = (Color)info.GetValue("fillColor", typeof(Color));
        }
    }
}
