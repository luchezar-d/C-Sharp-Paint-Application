using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Serialization;
using System.Text;

namespace Draw.src.Model
{
    [Serializable]
    class ElipseShape : Shape
    {
        public ElipseShape(RectangleF rect) : base(rect)
        {
        }

        public ElipseShape(ElipseShape elipse) : base(elipse)
        {
        }
        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            grfx.FillEllipse(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawEllipse(Pens.Black, Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

        }
        public ElipseShape(SerializationInfo info, StreamingContext context)
        {
            this.Rectangle = (RectangleF)info.GetValue("rectangle", typeof(RectangleF));
            this.Width = (float)info.GetValue("width", typeof(float));
            this.Height = (float)info.GetValue("height", typeof(float));
            this.Location = (PointF)info.GetValue("location", typeof(PointF));
            this.FillColor = (Color)info.GetValue("fillColor", typeof(Color));
        }
    }
}
