
namespace UI.Desktop
{
    partial class ServicioTipoPrenda
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
            FastReport.DataVisualization.Charting.ChartArea chartArea1 = new FastReport.DataVisualization.Charting.ChartArea();
            FastReport.DataVisualization.Charting.Series series1 = new FastReport.DataVisualization.Charting.Series();
            FastReport.DataVisualization.Charting.Title title1 = new FastReport.DataVisualization.Charting.Title();
            this.listServiciosTipoPrendas = new MaterialSkin.Controls.MaterialListView();
            this.columnServicio = new System.Windows.Forms.ColumnHeader();
            this.columnTipoPrenda = new System.Windows.Forms.ColumnHeader();
            this.btnDetalles = new MaterialSkin.Controls.MaterialButton();
            this.btnAgregar = new MaterialSkin.Controls.MaterialButton();
            this.btnEditarServicioTipoPrenda = new MaterialSkin.Controls.MaterialButton();
            this.btnEliminarServicioTipoPrenda = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lblIngresoTotalObtenido = new MaterialSkin.Controls.MaterialLabel();
            this.lblIngresosUtlimoMes = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.lblTiempoPromedio = new MaterialSkin.Controls.MaterialLabel();
            this.lblCantidadSolicitudes = new MaterialSkin.Controls.MaterialLabel();
            this.chartItem = new FastReport.DataVisualization.Charting.Chart();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCerrar = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartItem)).BeginInit();
            this.SuspendLayout();
            // 
            // listServiciosTipoPrendas
            // 
            this.listServiciosTipoPrendas.AutoSizeTable = false;
            this.listServiciosTipoPrendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listServiciosTipoPrendas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listServiciosTipoPrendas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnServicio,
            this.columnTipoPrenda});
            this.listServiciosTipoPrendas.Depth = 0;
            this.listServiciosTipoPrendas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listServiciosTipoPrendas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listServiciosTipoPrendas.FullRowSelect = true;
            this.listServiciosTipoPrendas.HideSelection = false;
            this.listServiciosTipoPrendas.Location = new System.Drawing.Point(15, 160);
            this.listServiciosTipoPrendas.MinimumSize = new System.Drawing.Size(200, 100);
            this.listServiciosTipoPrendas.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listServiciosTipoPrendas.MouseState = MaterialSkin.MouseState.OUT;
            this.listServiciosTipoPrendas.MultiSelect = false;
            this.listServiciosTipoPrendas.Name = "listServiciosTipoPrendas";
            this.listServiciosTipoPrendas.OwnerDraw = true;
            this.listServiciosTipoPrendas.Size = new System.Drawing.Size(358, 365);
            this.listServiciosTipoPrendas.TabIndex = 0;
            this.listServiciosTipoPrendas.UseCompatibleStateImageBehavior = false;
            this.listServiciosTipoPrendas.View = System.Windows.Forms.View.Details;
            this.listServiciosTipoPrendas.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listServiciosTipoPrendas_ColumnWidthChanging);
            this.listServiciosTipoPrendas.SelectedIndexChanged += new System.EventHandler(this.listServiciosTipoPrendas_SelectedIndexChanged);
            // 
            // columnServicio
            // 
            this.columnServicio.Text = "Servicio";
            this.columnServicio.Width = 158;
            // 
            // columnTipoPrenda
            // 
            this.columnTipoPrenda.Text = "Tipo de Prenda";
            this.columnTipoPrenda.Width = 200;
            // 
            // btnDetalles
            // 
            this.btnDetalles.AutoSize = false;
            this.btnDetalles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDetalles.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDetalles.Depth = 0;
            this.btnDetalles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDetalles.HighEmphasis = true;
            this.btnDetalles.Icon = global::UI.Desktop.Properties.Resources.document_3530;
            this.btnDetalles.Location = new System.Drawing.Point(380, 161);
            this.btnDetalles.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDetalles.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDetalles.Size = new System.Drawing.Size(114, 51);
            this.btnDetalles.TabIndex = 1;
            this.btnDetalles.Text = "Detalles";
            this.btnDetalles.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDetalles.UseAccentColor = false;
            this.btnDetalles.UseVisualStyleBackColor = false;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = false;
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAgregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAgregar.HighEmphasis = true;
            this.btnAgregar.Icon = global::UI.Desktop.Properties.Resources.plus_icon_icons_com_70890;
            this.btnAgregar.Location = new System.Drawing.Point(15, 95);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregar.Size = new System.Drawing.Size(114, 51);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregar.UseAccentColor = false;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditarServicioTipoPrenda
            // 
            this.btnEditarServicioTipoPrenda.AutoSize = false;
            this.btnEditarServicioTipoPrenda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditarServicioTipoPrenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEditarServicioTipoPrenda.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditarServicioTipoPrenda.Depth = 0;
            this.btnEditarServicioTipoPrenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditarServicioTipoPrenda.HighEmphasis = true;
            this.btnEditarServicioTipoPrenda.Icon = global::UI.Desktop.Properties.Resources._353430_checkbox_edit_pen_pencil_107516;
            this.btnEditarServicioTipoPrenda.Location = new System.Drawing.Point(137, 95);
            this.btnEditarServicioTipoPrenda.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditarServicioTipoPrenda.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarServicioTipoPrenda.Name = "btnEditarServicioTipoPrenda";
            this.btnEditarServicioTipoPrenda.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditarServicioTipoPrenda.Size = new System.Drawing.Size(114, 51);
            this.btnEditarServicioTipoPrenda.TabIndex = 5;
            this.btnEditarServicioTipoPrenda.Text = "Editar";
            this.btnEditarServicioTipoPrenda.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditarServicioTipoPrenda.UseAccentColor = false;
            this.btnEditarServicioTipoPrenda.UseVisualStyleBackColor = false;
            this.btnEditarServicioTipoPrenda.Click += new System.EventHandler(this.btnEditarServicioTipoPrenda_Click);
            // 
            // btnEliminarServicioTipoPrenda
            // 
            this.btnEliminarServicioTipoPrenda.AutoSize = false;
            this.btnEliminarServicioTipoPrenda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarServicioTipoPrenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEliminarServicioTipoPrenda.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarServicioTipoPrenda.Depth = 0;
            this.btnEliminarServicioTipoPrenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarServicioTipoPrenda.HighEmphasis = true;
            this.btnEliminarServicioTipoPrenda.Icon = global::UI.Desktop.Properties.Resources.trash_bin_icon_icons_com_67981;
            this.btnEliminarServicioTipoPrenda.Location = new System.Drawing.Point(259, 95);
            this.btnEliminarServicioTipoPrenda.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarServicioTipoPrenda.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarServicioTipoPrenda.Name = "btnEliminarServicioTipoPrenda";
            this.btnEliminarServicioTipoPrenda.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminarServicioTipoPrenda.Size = new System.Drawing.Size(114, 51);
            this.btnEliminarServicioTipoPrenda.TabIndex = 4;
            this.btnEliminarServicioTipoPrenda.Text = "Eliminar";
            this.btnEliminarServicioTipoPrenda.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminarServicioTipoPrenda.UseAccentColor = false;
            this.btnEliminarServicioTipoPrenda.UseVisualStyleBackColor = false;
            this.btnEliminarServicioTipoPrenda.Click += new System.EventHandler(this.btnEliminarServicioTipoPrenda_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblIngresoTotalObtenido);
            this.materialCard1.Controls.Add(this.lblIngresosUtlimoMes);
            this.materialCard1.Controls.Add(this.materialLabel7);
            this.materialCard1.Controls.Add(this.materialLabel6);
            this.materialCard1.Controls.Add(this.lblTiempoPromedio);
            this.materialCard1.Controls.Add(this.lblCantidadSolicitudes);
            this.materialCard1.Controls.Add(this.chartItem);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(504, 86);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(450, 439);
            this.materialCard1.TabIndex = 6;
            // 
            // lblIngresoTotalObtenido
            // 
            this.lblIngresoTotalObtenido.AutoSize = true;
            this.lblIngresoTotalObtenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblIngresoTotalObtenido.Depth = 0;
            this.lblIngresoTotalObtenido.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblIngresoTotalObtenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIngresoTotalObtenido.Location = new System.Drawing.Point(206, 136);
            this.lblIngresoTotalObtenido.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIngresoTotalObtenido.Name = "lblIngresoTotalObtenido";
            this.lblIngresoTotalObtenido.Size = new System.Drawing.Size(5, 19);
            this.lblIngresoTotalObtenido.TabIndex = 9;
            this.lblIngresoTotalObtenido.Text = "-";
            // 
            // lblIngresosUtlimoMes
            // 
            this.lblIngresosUtlimoMes.AutoSize = true;
            this.lblIngresosUtlimoMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblIngresosUtlimoMes.Depth = 0;
            this.lblIngresosUtlimoMes.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblIngresosUtlimoMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIngresosUtlimoMes.Location = new System.Drawing.Point(294, 103);
            this.lblIngresosUtlimoMes.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIngresosUtlimoMes.Name = "lblIngresosUtlimoMes";
            this.lblIngresosUtlimoMes.Size = new System.Drawing.Size(5, 19);
            this.lblIngresosUtlimoMes.TabIndex = 8;
            this.lblIngresosUtlimoMes.Text = "-";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(9, 136);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(191, 19);
            this.materialLabel7.TabIndex = 7;
            this.materialLabel7.Text = "Ingreso total obtenidos ($):";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(9, 103);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(279, 19);
            this.materialLabel6.TabIndex = 6;
            this.materialLabel6.Text = "Ingreso obtenidos en el ultimo mes ($) :";
            // 
            // lblTiempoPromedio
            // 
            this.lblTiempoPromedio.AutoSize = true;
            this.lblTiempoPromedio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblTiempoPromedio.Depth = 0;
            this.lblTiempoPromedio.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTiempoPromedio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTiempoPromedio.Location = new System.Drawing.Point(251, 74);
            this.lblTiempoPromedio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTiempoPromedio.Name = "lblTiempoPromedio";
            this.lblTiempoPromedio.Size = new System.Drawing.Size(5, 19);
            this.lblTiempoPromedio.TabIndex = 5;
            this.lblTiempoPromedio.Text = "-";
            // 
            // lblCantidadSolicitudes
            // 
            this.lblCantidadSolicitudes.AutoSize = true;
            this.lblCantidadSolicitudes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblCantidadSolicitudes.Depth = 0;
            this.lblCantidadSolicitudes.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCantidadSolicitudes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCantidadSolicitudes.Location = new System.Drawing.Point(186, 46);
            this.lblCantidadSolicitudes.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCantidadSolicitudes.Name = "lblCantidadSolicitudes";
            this.lblCantidadSolicitudes.Size = new System.Drawing.Size(5, 19);
            this.lblCantidadSolicitudes.TabIndex = 4;
            this.lblCantidadSolicitudes.Text = "-";
            // 
            // chartItem
            // 
            this.chartItem.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartItem.ChartAreas.Add(chartArea1);
            this.chartItem.Location = new System.Drawing.Point(9, 178);
            this.chartItem.Name = "chartItem";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = FastReport.DataVisualization.Charting.SeriesChartType.StackedBar;
            series1.IsValueShownAsLabel = true;
            series1.Name = "Series1";
            series1.YValuesPerPoint = 6;
            this.chartItem.Series.Add(series1);
            this.chartItem.Size = new System.Drawing.Size(430, 234);
            this.chartItem.TabIndex = 8;
            this.chartItem.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Porcentaje de Servicios brindados por Tipo de Prenda";
            this.chartItem.Titles.Add(title1);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(9, 75);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(235, 19);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Tiempo promedio para realizarlo:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(9, 47);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(170, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Cantidad de solicitudes:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(9, 9);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(91, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Estadísticas:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCerrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCerrar.Depth = 0;
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.HighEmphasis = true;
            this.btnCerrar.Icon = null;
            this.btnCerrar.Location = new System.Drawing.Point(877, 536);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCerrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCerrar.Size = new System.Drawing.Size(77, 36);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCerrar.UseAccentColor = false;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // ServicioTipoPrenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 578);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEditarServicioTipoPrenda);
            this.Controls.Add(this.btnEliminarServicioTipoPrenda);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.listServiciosTipoPrendas);
            this.Controls.Add(this.materialCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ServicioTipoPrenda";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicios por tipo de prenda";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listServiciosTipoPrendas;
        private System.Windows.Forms.ColumnHeader columnServicio;
        private System.Windows.Forms.ColumnHeader columnTipoPrenda;
        private MaterialSkin.Controls.MaterialButton btnDetalles;
        private MaterialSkin.Controls.MaterialButton btnAgregar;
        private MaterialSkin.Controls.MaterialButton btnEditarServicioTipoPrenda;
        private MaterialSkin.Controls.MaterialButton btnEliminarServicioTipoPrenda;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel lblIngresoTotalObtenido;
        private MaterialSkin.Controls.MaterialLabel lblIngresosUtlimoMes;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel lblTiempoPromedio;
        private MaterialSkin.Controls.MaterialLabel lblCantidadSolicitudes;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnCerrar;
        private FastReport.DataVisualization.Charting.Chart chartItem;
    }
}