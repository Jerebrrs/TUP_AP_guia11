using GeometriaModels.DALs;
using GeometriaModels.Models;
using GeometriaModels.Services;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace GeometriaDesktop
{
    public partial class Form1 : Form
    {
        FiguraService _figurasService;
        public Form1(FiguraService figuraService)
        {
            _figurasService = figuraService;
            InitializeComponent();
         
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbRadio.Enabled = false;
            tbArea.Enabled = false;
            tbAncho.Enabled = false;
            tbAlto.Enabled = false;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int idi = rnd.Next(1,100);

            bool rRecta = radioButton1.Checked;

            if (rRecta== true)
            {
                tbArea.Enabled = true;
                tbAncho.Enabled = true;
                tbAlto.Enabled = true;
            }

            FiguraModel figuraModels = null;
            if (rRecta == true)
            {
            
                double area = Convert.ToDouble(tbArea.Text);
                double largo = Convert.ToDouble(tbAlto.Text);
                double ancho = Convert.ToDouble(tbAncho.Text);

                figuraModels = new RectanguloModel { Id = idi, Area = area, Largo = largo, Ancho = ancho };

            }
            else
            {

                tbArea.Enabled = true;
              
                tbRadio.Enabled = true;
                double area = Convert.ToDouble(tbArea.Text);
                double redio = Convert.ToDouble(tbRadio.Text);
                figuraModels = new CirculoModel { Id = idi, Area = area, Radio= redio };
            }

            _figurasService.AddFigura(figuraModels);

           
        }
        #region lvw redibujado
        public void lvwInicializar()
        {
            lvwFiguras.View = View.Tile;
            lvwFiguras.FullRowSelect = true;
            lvwFiguras.HideSelection = false;
            lvwFiguras.OwnerDraw = true;
            lvwFiguras.TileSize = new Size(300, 100);
            lvwFiguras.BackColor = Color.WhiteSmoke;
            lvwFiguras.BorderStyle = BorderStyle.None;
            lvwFiguras.DrawItem += lvwFiguras_DrawItem;
            lvwFiguras.SelectedIndexChanged += lvwFiguras_SelectedIndexChanged;
        }

        private GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            path.AddArc(arc, 180, 90);

            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            arc.Y = bounds.Bottom - diameter;



            path.AddArc(arc, 0, 90);

            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        private void lvwFiguras_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            var rect = e.Bounds;

            Color backColor = e.Item.Selected ? Color.LightBlue : Color.White;
            Color borderColor = e.Item.Selected ? Color.DodgerBlue : Color.LightGray;

            using (var brush = new SolidBrush(backColor))
            using (var pen = new Pen(borderColor, 2))
            {
                int radius = 10;
                var path = RoundedRect(rect, radius);
                e.Graphics.FillPath(brush, path);
                e.Graphics.DrawPath(pen, path);
            }

            string text = e.Item.Text;
            var fontTitle = new Font("Segoe UI", 10, FontStyle.Bold);
            var fontSub = new Font("Segoe UI", 9, FontStyle.Regular);

            e.Graphics.DrawString(text, fontTitle, Brushes.Black, rect.X + 10, rect.Y + 10);

            int offsetY = 30;
            foreach (ListViewItem.ListViewSubItem sub in e.Item.SubItems)
            {
                if (sub == e.Item.SubItems[0]) continue;
                e.Graphics.DrawString(sub.Text, fontSub, Brushes.DimGray, rect.X + 10, rect.Y + offsetY);
                offsetY += 18;
            }
        }
        private void lvwFiguras_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvwFiguras.Invalidate();
        }
        #endregion
    }
}