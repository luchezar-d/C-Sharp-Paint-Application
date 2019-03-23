using System;
using System.Drawing;
using System.Runtime.Serialization;

namespace Draw
{
	/// <summary>
	/// Класът правоъгълник е основен примитив, който е наследник на базовия Shape.
	/// </summary>
    [Serializable]
	public class RectangleShape : Shape
	{
		#region Constructor
		
		public RectangleShape(RectangleF rect) : base(rect)
		{
		}
		
		public RectangleShape(RectangleShape rectangle) : base(rectangle)
		{
		}
		
		#endregion

		/// <summary>
		/// Проверка за принадлежност на точка point към правоъгълника.
		/// В случая на правоъгълник този метод може да не бъде пренаписван, защото
		/// Реализацията съвпада с тази на абстрактния клас Shape, който проверява
		/// дали точката е в обхващащия правоъгълник на елемента (а той съвпада с
		/// елемента в този случай).
		/// </summary>
		public override bool Contains(PointF point)
		{
			if (base.Contains(point))
				// Проверка дали е в обекта само, ако точката е в обхващащия правоъгълник.
				// В случая на правоъгълник - директно връщаме true
				return true;
			else
				// Ако не е в обхващащия правоъгълник, то неможе да е в обекта и => false
				return false;
		}
		
		/// <summary>
		/// Частта, визуализираща конкретния примитив.
		/// </summary>
		public override void DrawSelf(Graphics grfx)
		{
			base.DrawSelf(grfx);
			
			grfx.FillRectangle(new SolidBrush(FillColor),Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
			grfx.DrawRectangle(Pens.Black,Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
			
		}
        public RectangleShape(SerializationInfo info, StreamingContext context)
        {
            this.Rectangle = (RectangleF)info.GetValue("rectangle", typeof(RectangleF));
            this.Width = (float)info.GetValue("width", typeof(float));
            this.Height = (float)info.GetValue("height", typeof(float));
            this.Location = (PointF)info.GetValue("location", typeof(PointF));
            this.FillColor = (Color)info.GetValue("fillColor", typeof(Color));
        }
    }
}
