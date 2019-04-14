using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.Serialization;
using System.Text;

namespace Draw.src.Model
{
     class RectMercedes : Shape
    {
        public RectMercedes()
        {
        }

        public RectMercedes(RectangleF rect) : base(rect)
        {
        }

        public RectMercedes(Shape shape) : base(shape)
        {
        }
        
        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);
            Matrix m = new Matrix();
            m.Rotate(0, MatrixOrder.Append);
            grfx.Transform = m;

            m.RotateAt(0, new PointF(Rectangle.Left + (Rectangle.Width / 2), Rectangle.Top + (Rectangle.Height / 2)));

            PointF center = new PointF(Rectangle.X + Rectangle.Width / 2, Rectangle.Y + Rectangle.Height / 2);
            PointF right = new PointF(Rectangle.Right, Rectangle.Bottom);
            PointF left = new PointF(Rectangle.Left, Rectangle.Bottom );
            PointF top = new PointF(Rectangle.X + Rectangle.Width / 2, Rectangle.Top);

            grfx.FillRectangle(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawRectangle(Pens.Black, Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.ResetTransform();

            grfx.DrawLine(Pens.Black, center, right);
            grfx.DrawLine(Pens.Black, center, left);
            grfx.DrawLine(Pens.Black, center, top);


        }
        public RectMercedes(SerializationInfo info, StreamingContext context)
        {
            this.Rectangle = (RectangleF)info.GetValue("rectangle", typeof(RectangleF));
            this.Width = (float)info.GetValue("width", typeof(float));
            this.Height = (float)info.GetValue("height", typeof(float));
            this.Location = (PointF)info.GetValue("location", typeof(PointF));
            this.FillColor = (Color)info.GetValue("fillColor", typeof(Color));
        }
    }
}
