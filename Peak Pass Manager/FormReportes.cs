using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Peak_Pass_Manager
{
    public partial class FormReportes : Form
    {
        ControladoraReportes controladoraReportes = new ControladoraReportes();
        public FormReportes()
        {
            InitializeComponent();
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {
            CargarProductosMasVendidos();
            CargarCategoriasMasVendidas();
            CargarProductosPorCategoria();
            CargarVentasPorMes();
        }
        //Metodo para cargar el chart de reporte de productos mas vendidos
        private void CargarProductosMasVendidos()
        {
            DataTable dt = controladoraReportes.ProductosMasVendidos();
            chartMasVendidos.DataSource = dt;
            chartMasVendidos.Series["Productos"].XValueMember = "Producto";
            chartMasVendidos.Series["Productos"].YValueMembers = "Cantidad";
            chartMasVendidos.DataBind();
        }
        //Metodo para cargar el chart de reporte de categorias mas vendidas
        private void CargarCategoriasMasVendidas()
        {
            DataTable dt = controladoraReportes.CategoriasMasVendidas();
            chartCategoriaMasVendida.DataSource = dt;
            chartCategoriaMasVendida.Series["Categorias"].XValueMember = "Categoria";
            chartCategoriaMasVendida.Series["Categorias"].YValueMembers = "Ventas";
            chartCategoriaMasVendida.DataBind();
        }
        //Metodo para cargar el chart de reporte de productos por categoria
        private void CargarProductosPorCategoria()
        {
            DataTable dt = controladoraReportes.ProductosPorCategoria();
            chartProdPorCategoria.DataSource = dt;
            chartProdPorCategoria.Series["Productos"].XValueMember = "Catalogo";
            chartProdPorCategoria.Series["Productos"].YValueMembers = "Productos";
            chartProdPorCategoria.DataBind();
        }
        //Metodo para cargar el chart de reporte de ventas por mes
        private void CargarVentasPorMes()
        {
            DataTable dt = controladoraReportes.VentasPorMes();
            chartVentasPorMes.DataSource = dt;
            chartVentasPorMes.Series["Ventas"].XValueMember = "Mes";
            chartVentasPorMes.Series["Ventas"].YValueMembers = "Ventas";
            chartVentasPorMes.DataBind();
            //Hace que el chart muestre todos los meses
            chartVentasPorMes.ChartAreas[0].AxisX.Interval = 1;
        }
        
        private void Descargar()
        {
            //Guarda los reportes en un archivo PDF usando iTextSharp
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF (*.pdf)|*.pdf";
            saveFileDialog.FileName = "Reporte.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Document doc = new Document(PageSize.A4);
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                doc.Open();
                //Titulo
                Paragraph title = new Paragraph("Reportes Peak Pass", FontFactory.GetFont(FontFactory.TIMES, 24, BaseColor.BLACK));
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);
                Paragraph subtitle = new Paragraph("Fecha de hoy: " + DateTime.Now.ToString("dd/MM/yyyy"), FontFactory.GetFont(FontFactory.TIMES, 18, BaseColor.BLACK));
                subtitle.Alignment = Element.ALIGN_CENTER;
                doc.Add(subtitle);
                doc.Add(new Paragraph(" "));
                //Reporte de productos mas vendidos
                doc.Add(new Paragraph("Productos mas vendidos", FontFactory.GetFont(FontFactory.TIMES, 18, BaseColor.BLACK)));
                doc.Add(new Paragraph(" "));
                PdfPTable table = new PdfPTable(2);
                table.AddCell("Producto");
                table.AddCell("Cantidad");
                foreach (DataRow row in controladoraReportes.ProductosMasVendidos().Rows)
                {
                    table.AddCell(row["Producto"].ToString());
                    table.AddCell(row["Cantidad"].ToString());
                }
                doc.Add(table);
                doc.Add(new Paragraph(" "));
                //Reporte de categorias mas vendidas
                doc.Add(new Paragraph("Categorias mas vendidas", FontFactory.GetFont(FontFactory.TIMES, 18, BaseColor.BLACK)));
                doc.Add(new Paragraph(" "));
                table = new PdfPTable(2);
                table.AddCell("Categoria");
                table.AddCell("Ventas");
                foreach (DataRow row in controladoraReportes.CategoriasMasVendidas().Rows)
                {
                    table.AddCell(row["Categoria"].ToString());
                    table.AddCell(row["Ventas"].ToString());
                }
                doc.Add(table);
                doc.Add(new Paragraph(" "));
                //Reporte de productos por categoria
                doc.Add(new Paragraph("Productos por categoria", FontFactory.GetFont(FontFactory.TIMES, 18, BaseColor.BLACK)));
                doc.Add(new Paragraph(" "));
                table = new PdfPTable(2);
                table.AddCell("Catalogo");
                table.AddCell("Productos");
                foreach (DataRow row in controladoraReportes.ProductosPorCategoria().Rows)
                {
                    table.AddCell(row["Catalogo"].ToString());
                    table.AddCell(row["Productos"].ToString());
                }
                doc.Add(table);
                doc.Add(new Paragraph(" "));
                //Reporte de ventas por mes
                doc.Add(new Paragraph("Ventas por mes", FontFactory.GetFont(FontFactory.TIMES, 18, BaseColor.BLACK)));
                doc.Add(new Paragraph(" "));
                table = new PdfPTable(2);
                table.AddCell("Mes");
                table.AddCell("Ventas");
                foreach (DataRow row in controladoraReportes.VentasPorMes().Rows)
                {
                    table.AddCell(row["Mes"].ToString());
                    table.AddCell(row["Ventas"].ToString());
                }
                doc.Add(table);
                doc.Close();
                MessageBox.Show("Reporte guardado exitosamente");

            }
        }

        private void btnDescargarRJ_Click(object sender, EventArgs e)
        {
            Descargar();
        }
    }
}
