using Draw.src.Model;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Draw
{
	/// <summary>
	/// Класът, който ще бъде използван при управляване на диалога.
	/// </summary>
	public class DialogProcessor : DisplayProcessor
	{
		#region Constructor
		
		public DialogProcessor()
		{
		}

        #endregion

        #region Properties

        /// <summary>
        /// Избран елемент.
        /// </summary>
        private List<Shape> selection = new List<Shape>();
        public List<Shape> Selection
        {
            get { return selection; }
            set { selection = value; }
        }

        /// <summary>
        /// Дали в момента диалога е в състояние на "влачене" на избрания елемент.
        /// </summary>
        private bool isDragging;
		public bool IsDragging {
			get { return isDragging; }
			set { isDragging = value; }
		}
		
		/// <summary>
		/// Последна позиция на мишката при "влачене".
		/// Използва се за определяне на вектора на транслация.
		/// </summary>
		private PointF lastLocation;
		public PointF LastLocation {
			get { return lastLocation; }
			set { lastLocation = value; }
		}
		
		#endregion
		
		/// <summary>
		/// Добавя примитив - правоъгълник на произволно място върху клиентската област.
		/// </summary>
		public void AddRandomRectangle()
		{
			Random rnd = new Random();
			int x = rnd.Next(100,1000);
			int y = rnd.Next(100,600);
			
			RectangleShape rect = new RectangleShape(new Rectangle(x,y,100,200));
			rect.FillColor = Color.White;

			ShapeList.Add(rect);
            BackList.Add(rect);
        }
        public void AddElipse()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            ElipseShape rect = new ElipseShape(new Rectangle(x, y, 100, 200));
            rect.FillColor = Color.White;

            ShapeList.Add(rect);
            BackList.Add(rect);
        }
        public void AddOval()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            ElipseShape rect = new ElipseShape(new Rectangle(x, y, 100, 100));
            rect.FillColor = Color.White;

            ShapeList.Add(rect);
            BackList.Add(rect);
        }
        public void AddTriangle()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            TriangleShape rect = new TriangleShape(new Rectangle(x, y, 150, 150));
            rect.FillColor = Color.White;

            ShapeList.Add(rect);
            BackList.Add(rect);
        }
        /// <summary>
        /// Проверява дали дадена точка е в елемента.
        /// Обхожда в ред обратен на визуализацията с цел намиране на
        /// "най-горния" елемент т.е. този който виждаме под мишката.
        /// </summary>
        /// <param name="point">Указана точка</param>
        /// <returns>Елемента на изображението, на който принадлежи дадената точка.</returns>
        public Shape ContainsPoint(PointF point)
		{
			for(int i = ShapeList.Count - 1; i >= 0; i--){
				if (ShapeList[i].Contains(point)){
						
					return ShapeList[i];
				}	
			}
			return null;
		}

        public void TranslateTo(PointF p)
        {
            //if (selection != null) {
            foreach (var item in Selection)
            {
                item.Location = new PointF(item.Location.X + p.X - lastLocation.X, item.Location.Y + p.Y - lastLocation.Y);

            }
            lastLocation = p;
        }
        public override void Draw(Graphics grfx)
        {
            foreach (Shape item in ShapeList)
            {
                base.Draw(grfx);

                //    if (Selection != null)
                foreach (var item1 in Selection)
                {

                    grfx.DrawRectangle(Pens.Black, item1.Location.X - 3, item1.Location.Y - 3, item1.Width + 6, item1.Height + 6);
                }
            }
        }
        public void Group()
        {
            if (Selection.Count < 2) return;

            float minX = float.PositiveInfinity;
            float minY = float.PositiveInfinity;
            float maxX = float.NegativeInfinity;
            float maxY = float.NegativeInfinity;
            foreach (var item in Selection)
            {
                if (minX > item.Location.X) minX = item.Location.X;
                if (minY > item.Location.Y) minY = item.Location.Y;
                if (maxX > item.Location.X + item.Width) maxX = item.Location.X + item.Width;
                if (maxY > item.Location.Y + item.Height) maxY = item.Location.Y + item.Height;
            }

            var group = new GroupShape(new RectangleF(minX, minY, maxX - minX, maxY - minY));
            group.SubItems = Selection;

            foreach (var item in Selection)
            {
                ShapeList.Remove(item);
            }

            Selection = new List<Shape>();
            Selection.Add(group);

            ShapeList.Add(group);

        }
        public void Delete()
        {
            foreach (var item in Selection)
                ShapeList.Remove(item);
            Selection.Clear();
        }

        public void SelectAll()
        {
            Selection = new List<Shape>(ShapeList);
        }
        public void UnSelectAll()
        {
            Selection = new List<Shape>(shapeList1);
        }
        
    }
}
