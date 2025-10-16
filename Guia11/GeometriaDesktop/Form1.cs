using GeometriaModels.Models;
using GeometriaModels.Services;
using System.Drawing.Drawing2D;


namespace GeometriaDesktop
{
    public partial class Form1 : Form
    {
        FiguraService _figurasService;
        public Form1(FiguraService figuraService)
        {
            _figurasService = figuraService;
            InitializeComponent();

            tbRadio.Enabled = false;
            tbArea.Enabled = false;
            tbAncho.Enabled = false;
            tbAlto.Enabled = false;
            lvwInicializar();
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }

        private void btn_Click(object sender, EventArgs e)
        {

            FiguraModel figuraModels = null;
            if (radioButton1.Checked)
            {

                double area = Convert.ToDouble(tbArea.Text);
                double largo = Convert.ToDouble(tbAlto.Text);
                double ancho = Convert.ToDouble(tbAncho.Text);

                figuraModels = new RectanguloModel { Area = area, Largo = largo, Ancho = ancho };

            }
            else if (radioButton2.Checked)
            {


                double area = Convert.ToDouble(tbArea.Text);
                double redio = Convert.ToDouble(tbRadio.Text);
                figuraModels = new CirculoModel { Area = area, Radio = redio };
            }

            if (figuraModels != null)
            {
                _figurasService.AddFigura(figuraModels);
            }

            btnListado.PerformClick();
            //btnLimpiar.PerformClick();

            tbRadio.Clear();
            tbArea.Clear();
            tbAncho.Clear();
            tbAlto.Clear();

        }
        #region lvw redibujado
        public void lvwInicializar()
        {
            lvwFiguras.View = View.Tile;
            lvwFiguras.FullRowSelect = true;
            lvwFiguras.HideSelection = false;
            lvwFiguras.OwnerDraw = true;
            lvwFiguras.TileSize = new Size(300, 100);
            lvwFiguras.BackColor = Color.Red;
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

        private void btnListado_Click(object sender, EventArgs e)
        {
            lvwFiguras.Items.Clear();

            foreach (var figura in _figurasService.GetAll())
            {
                var item = new ListViewItem();
                if (figura is RectanguloModel r)
                {
                    item = new ListViewItem(new string[]
                    {
                        $"Rectangulo: #{r.Id} Area: #{r.Area} ancho: #{r.Ancho}",
                        $"Area: #{r.Area}",$"ancho: #{r.Ancho}",

                    });
                }
                else if (figura is CirculoModel c)
                {
                    item = new ListViewItem(new string[]
                 {
                    $"Circulo: #{c.Id}",
                    $"Area: {c.Area:f2}",
                    $"Radio: {c.Radio:f2}"
                 });
                }
                item.Tag = figura;
                lvwFiguras.Items.Add(item);
            }
        }

        private void lvwFiguras_SelectedIndexChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                var figuraSelected = e.Item.Tag as FiguraModel;

                if (figuraSelected != null)
                {
                    tbAncho.Clear();
                    tbAlto.Clear();
                    tbRadio.Clear();
                    radioButton1.Enabled = false;
                    radioButton2.Enabled = false;

                    tbArea.Text = $"{figuraSelected.Area:f2}";

                    if (figuraSelected is RectanguloModel r)
                    {
                        radioButton1.Checked = true;
                        tbAncho.Text = $"{r.Ancho:f2}";
                        tbAlto.Text = $"{r.Largo:f2}";

                        tbAncho.Enabled = true;
                        tbAlto.Enabled = true;
                        tbRadio.Enabled = false;
                    }
                    else if (figuraSelected is CirculoModel c)
                    {
                        radioButton2.Checked = true;
                        tbRadio.Text = $"{c.Radio:f2}";

                        tbAncho.Enabled = false;
                        tbAlto.Enabled = false;
                        tbRadio.Enabled = true;
                    }
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                tbAlto.Enabled = true;
                tbAncho.Enabled = true;
                tbArea.Enabled = true;
                tbRadio.Enabled = false;
            }
            else if (radioButton2.Checked)
            {
                tbAlto.Enabled = false;
                tbAncho.Enabled = false;
                tbArea.Enabled = true;
                tbRadio.Enabled = true;
            }
        }
    }
}