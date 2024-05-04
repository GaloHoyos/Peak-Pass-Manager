namespace Peak_Pass_Manager
{
    partial class FormReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            chartMasVendidos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartCategoriaMasVendida = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartProdPorCategoria = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnDescargar = new Button();
            chartVentasPorMes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartMasVendidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartCategoriaMasVendida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartProdPorCategoria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartVentasPorMes).BeginInit();
            SuspendLayout();
            // 
            // chartMasVendidos
            // 
            chartMasVendidos.BackColor = Color.FromArgb(34, 33, 74);
            chartMasVendidos.BorderlineColor = Color.FromArgb(34, 33, 74);
            chartArea1.BackColor = Color.FromArgb(34, 33, 74);
            chartArea1.Name = "ChartArea1";
            chartMasVendidos.ChartAreas.Add(chartArea1);
            legend1.BackColor = Color.FromArgb(34, 33, 74);
            legend1.ForeColor = Color.White;
            legend1.Name = "Legend1";
            chartMasVendidos.Legends.Add(legend1);
            chartMasVendidos.Location = new Point(635, 12);
            chartMasVendidos.Name = "chartMasVendidos";
            chartMasVendidos.RightToLeft = RightToLeft.Yes;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Color = Color.FromArgb(34, 33, 74);
            series1.IsValueShownAsLabel = true;
            series1.LabelBackColor = Color.Transparent;
            series1.LabelBorderColor = Color.Transparent;
            series1.LabelForeColor = Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Productos";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            chartMasVendidos.Series.Add(series1);
            chartMasVendidos.Size = new Size(549, 263);
            chartMasVendidos.TabIndex = 0;
            chartMasVendidos.Text = "chart1";
            title1.ForeColor = Color.White;
            title1.Name = "Title1";
            title1.Text = "Top 5 Productos mas Vendidos";
            chartMasVendidos.Titles.Add(title1);
            // 
            // chartCategoriaMasVendida
            // 
            chartCategoriaMasVendida.BackColor = Color.FromArgb(34, 33, 74);
            chartArea2.AxisX.LabelStyle.ForeColor = Color.White;
            chartArea2.AxisX.LineColor = Color.BlueViolet;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.TitleForeColor = Color.White;
            chartArea2.AxisX2.LineColor = Color.Transparent;
            chartArea2.AxisY.LabelStyle.Enabled = false;
            chartArea2.AxisY.LabelStyle.ForeColor = Color.White;
            chartArea2.AxisY.LineColor = Color.Transparent;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.TitleForeColor = Color.White;
            chartArea2.AxisY2.LineColor = Color.White;
            chartArea2.BackColor = Color.FromArgb(34, 33, 74);
            chartArea2.BorderColor = Color.FromArgb(34, 33, 74);
            chartArea2.Name = "ChartArea1";
            chartCategoriaMasVendida.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            chartCategoriaMasVendida.Legends.Add(legend2);
            chartCategoriaMasVendida.Location = new Point(746, 343);
            chartCategoriaMasVendida.Name = "chartCategoriaMasVendida";
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Categorias";
            chartCategoriaMasVendida.Series.Add(series2);
            chartCategoriaMasVendida.Size = new Size(438, 347);
            chartCategoriaMasVendida.TabIndex = 1;
            chartCategoriaMasVendida.Text = "chart1";
            title2.ForeColor = Color.White;
            title2.Name = "Title1";
            title2.Text = "Ventas de Productos por Catalogos";
            chartCategoriaMasVendida.Titles.Add(title2);
            // 
            // chartProdPorCategoria
            // 
            chartProdPorCategoria.BackColor = Color.FromArgb(34, 33, 74);
            chartArea3.AxisX.LabelStyle.ForeColor = Color.White;
            chartArea3.AxisX.LineColor = Color.BlueViolet;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.TitleForeColor = Color.White;
            chartArea3.AxisX2.LineColor = Color.Transparent;
            chartArea3.AxisY.LabelStyle.Enabled = false;
            chartArea3.AxisY.LabelStyle.ForeColor = Color.White;
            chartArea3.AxisY.LineColor = Color.Transparent;
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.AxisY.TitleForeColor = Color.White;
            chartArea3.AxisY2.LineColor = Color.White;
            chartArea3.BackColor = Color.FromArgb(34, 33, 74);
            chartArea3.BorderColor = Color.FromArgb(34, 33, 74);
            chartArea3.Name = "ChartArea1";
            chartProdPorCategoria.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            chartProdPorCategoria.Legends.Add(legend3);
            chartProdPorCategoria.Location = new Point(147, 12);
            chartProdPorCategoria.Name = "chartProdPorCategoria";
            series3.ChartArea = "ChartArea1";
            series3.IsValueShownAsLabel = true;
            series3.LabelForeColor = Color.White;
            series3.Legend = "Legend1";
            series3.Name = "Productos";
            series3.YValuesPerPoint = 2;
            chartProdPorCategoria.Series.Add(series3);
            chartProdPorCategoria.Size = new Size(409, 301);
            chartProdPorCategoria.TabIndex = 2;
            chartProdPorCategoria.Text = "chart1";
            title3.ForeColor = Color.White;
            title3.Name = "Title1";
            title3.Text = "Cantidad de Productos por Categoria";
            chartProdPorCategoria.Titles.Add(title3);
            // 
            // btnDescargar
            // 
            btnDescargar.Location = new Point(1072, 281);
            btnDescargar.Name = "btnDescargar";
            btnDescargar.Size = new Size(112, 34);
            btnDescargar.TabIndex = 3;
            btnDescargar.Text = "Descargar Reportes";
            btnDescargar.UseVisualStyleBackColor = true;
            btnDescargar.Click += btnDescargar_Click;
            // 
            // chartVentasPorMes
            // 
            chartVentasPorMes.BackColor = Color.FromArgb(34, 33, 74);
            chartArea4.AxisX.LabelStyle.ForeColor = Color.White;
            chartArea4.AxisX.LineColor = Color.BlueViolet;
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated90;
            chartArea4.AxisX.TitleForeColor = Color.White;
            chartArea4.AxisX2.LineColor = Color.Transparent;
            chartArea4.AxisY.LabelStyle.Enabled = false;
            chartArea4.AxisY.LabelStyle.ForeColor = Color.White;
            chartArea4.AxisY.LineColor = Color.Transparent;
            chartArea4.AxisY.MajorGrid.Enabled = false;
            chartArea4.AxisY.TitleForeColor = Color.White;
            chartArea4.AxisY2.LineColor = Color.White;
            chartArea4.BackColor = Color.FromArgb(34, 33, 74);
            chartArea4.BorderColor = Color.FromArgb(34, 33, 74);
            chartArea4.Name = "ChartArea1";
            chartVentasPorMes.ChartAreas.Add(chartArea4);
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            chartVentasPorMes.Legends.Add(legend4);
            chartVentasPorMes.Location = new Point(12, 329);
            chartVentasPorMes.Name = "chartVentasPorMes";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series4.IsValueShownAsLabel = true;
            series4.LabelForeColor = Color.White;
            series4.Legend = "Legend1";
            series4.Name = "Ventas";
            chartVentasPorMes.Series.Add(series4);
            chartVentasPorMes.Size = new Size(734, 347);
            chartVentasPorMes.TabIndex = 4;
            chartVentasPorMes.Text = "chart1";
            title4.ForeColor = Color.White;
            title4.Name = "Title1";
            title4.Text = "Cantidad de Ventas por Mes";
            chartVentasPorMes.Titles.Add(title4);
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1196, 702);
            Controls.Add(chartVentasPorMes);
            Controls.Add(btnDescargar);
            Controls.Add(chartProdPorCategoria);
            Controls.Add(chartCategoriaMasVendida);
            Controls.Add(chartMasVendidos);
            Name = "FormReportes";
            Text = "FormReportes";
            Load += FormReportes_Load;
            ((System.ComponentModel.ISupportInitialize)chartMasVendidos).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartCategoriaMasVendida).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartProdPorCategoria).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartVentasPorMes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMasVendidos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCategoriaMasVendida;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProdPorCategoria;
        private Button btnDescargar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVentasPorMes;
    }
}