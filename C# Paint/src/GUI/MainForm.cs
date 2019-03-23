using Draw.src.GUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Draw
{
	/// <summary>
	/// Върху главната форма е поставен потребителски контрол,
	/// в който се осъществява визуализацията
	/// </summary>
	public partial class MainForm : Form
	{
		/// <summary>
		/// Агрегирания диалогов процесор във формата улеснява манипулацията на модела.
		/// </summary>
		private DialogProcessor dialogProcessor = new DialogProcessor();

        Graphics g;
        int x = 0;
        int y = 0;
        bool moving = false;
        Pen pen;
        Image image;

        public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
            g = viewPort.CreateGraphics();
            pen = new Pen(Color.Black, 1);
            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }
        
		/// <summary>
		/// Изход от програмата. Затваря главната форма, а с това и програмата.
		/// </summary>
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Close();
		}
		
		/// <summary>
		/// Събитието, което се прихваща, за да се превизуализира при изменение на модела.
		/// </summary>
		void ViewPortPaint(object sender, PaintEventArgs e)
		{
			dialogProcessor.ReDraw(sender, e);
		}
		
		/// <summary>
		/// Бутон, който поставя на произволно място правоъгълник със зададените размери.
		/// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
		/// </summary>
		void DrawRectangleSpeedButtonClick(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomRectangle();
			
			statusBar.Items[0].Text = "Последно действие: Рисуване на правоъгълник";
			
			viewPort.Invalidate();
		}

		/// <summary>
		/// Прихващане на координатите при натискането на бутон на мишката и проверка (в обратен ред) дали не е
		/// щракнато върху елемент. Ако е така то той се отбелязва като селектиран и започва процес на "влачене".
		/// Промяна на статуса и инвалидиране на контрола, в който визуализираме.
		/// Реализацията се диалогът с потребителя, при който се избира "най-горния" елемент от екрана.
		/// </summary>
		void ViewPortMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
            var sel = dialogProcessor.ContainsPoint(e.Location);

            if (sel == null)
            {
                moving = true;
                x = e.X;
                y = e.Y;
                return;
            }

            if (pickUpSpeedButton.Checked)
            {
                if (dialogProcessor.Selection.Contains(sel))
                    dialogProcessor.Selection.Remove(sel);
                else
                    dialogProcessor.Selection.Add(sel);

                statusBar.Items[0].Text = "Последно действие: Селекция на примитив";
                dialogProcessor.IsDragging = true;
                dialogProcessor.LastLocation = e.Location;
                viewPort.Invalidate();

            }
            moving = true;
            x = e.X;
            y = e.Y;
            viewPort.Invalidate();
        }

		/// <summary>
		/// Прихващане на преместването на мишката.
		/// Ако сме в режм на "влачене", то избрания елемент се транслира.
		/// </summary>
		void ViewPortMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (dialogProcessor.IsDragging) {
				if (dialogProcessor.Selection != null) statusBar.Items[0].Text = "Последно действие: Влачене";
				dialogProcessor.TranslateTo(e.Location);
				viewPort.Invalidate();
			}
            if (moving && x != -1 && y != -1)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;

            }
        }

		/// <summary>
		/// Прихващане на отпускането на бутона на мишката.
		/// Излизаме от режим "влачене".
		/// </summary>
		void ViewPortMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			dialogProcessor.IsDragging = false;
            moving = false;
            x = -1;
            y = -1;
        }

        private void ElipseBtn_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddElipse();

            statusBar.Items[0].Text = "Рисуване на елипса";

            viewPort.Invalidate();

        }

        private void TriangleBtn_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddTriangle();

            statusBar.Items[0].Text = "Рисуване на триъгълник.";

            viewPort.Invalidate();
        }

        private void ColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < dialogProcessor.Selection.Count; i++)
                {
                    dialogProcessor.Selection[i].FillColor = dialog.Color;
                }
            }
            viewPort.Invalidate();
        }

        private void SelectAllBtn_Click(object sender, EventArgs e)
        {
            dialogProcessor.SelectAll();

            viewPort.Invalidate();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            dialogProcessor.Delete();
            viewPort.Invalidate();
        }

        private void UndoBtn_Click(object sender, EventArgs e)
        {
            dialogProcessor.ShapeList = new List<Shape>(dialogProcessor.BackList);

            viewPort.Invalidate();
        }
        

        private void BackgroundColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                viewPort.BackColor = cd.Color;
                backGroundColor.BackColor = cd.Color;
            }
            viewPort.Invalidate();
        }

        private void SizeBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dialogProcessor.Selection.Count; i++)
            {
                dialogProcessor.Selection[i].Width = Int32.Parse(SizeBox.Text);
                dialogProcessor.Selection[i].Height = Int32.Parse(SizeBox.Text);
            }

            viewPort.Invalidate();
        }

        private void ChangePenSize_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            pen = new Pen(Color.Black, Int32.Parse(PenSizeBox.Text));
            
        }

        private void Oval_Click(object sender, EventArgs e)
        {
            
        }

        private void openAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream stream = File.Open(openFileDialog.FileName, FileMode.Open))
                {

                    BinaryFormatter bf = new BinaryFormatter();
                    List<Shape> serializedShapes = (List<Shape>)bf.Deserialize(stream);

                    dialogProcessor.ShapeList = new List<Shape>(serializedShapes);

                }
            }
            
            viewPort.Invalidate();
            
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream stream = File.Open(saveFileDialog.FileName, FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();

                    bf.Serialize(stream, dialogProcessor.ShapeList);
                };
            }
            Loader load = new Loader();
            load.ShowDialog();
        }

        private void UnSelect_Click(object sender, EventArgs e)
        {
            dialogProcessor.UnSelectAll();
            viewPort.Invalidate();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*.JPG)|*.jpg";

            if (f.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(f.FileName);
                viewPort.BackgroundImage = image;
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "JPG(*.JPG)|*.jpg";

            if (f.ShowDialog() == DialogResult.OK)
            {
                image.Save(f.FileName);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.ShowDialog();
        }

        private void Help_Click(object sender, EventArgs e)
        {
            src.GUI.Help h = new src.GUI.Help();
            h.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
        

        private void penColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                pen.Color = cd.Color;
                penBackColor.BackColor = pen.Color;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit ?", "Exit" , MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
