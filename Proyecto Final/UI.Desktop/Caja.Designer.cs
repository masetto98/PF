
namespace UI.Desktop
{
    partial class Caja
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
            FastReport.DataVisualization.Charting.Legend legend1 = new FastReport.DataVisualization.Charting.Legend();
            FastReport.DataVisualization.Charting.Series series1 = new FastReport.DataVisualization.Charting.Series();
            FastReport.DataVisualization.Charting.Title title1 = new FastReport.DataVisualization.Charting.Title();
            FastReport.DataVisualization.Charting.ChartArea chartArea2 = new FastReport.DataVisualization.Charting.ChartArea();
            FastReport.DataVisualization.Charting.Series series2 = new FastReport.DataVisualization.Charting.Series();
            FastReport.DataVisualization.Charting.Title title2 = new FastReport.DataVisualization.Charting.Title();
            this.listOrdenes = new MaterialSkin.Controls.MaterialListView();
            this.columnNro = new System.Windows.Forms.ColumnHeader();
            this.columnFechaSalida = new System.Windows.Forms.ColumnHeader();
            this.columnIngresos = new System.Windows.Forms.ColumnHeader();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lblBalanceHoy = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.lblSalidasDia = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.lblIngresosDia = new MaterialSkin.Controls.MaterialLabel();
            this.lblSaldoAnterior = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCerrar = new MaterialSkin.Controls.MaterialButton();
            this.listGastos = new MaterialSkin.Controls.MaterialListView();
            this.columnTipoGasto = new System.Windows.Forms.ColumnHeader();
            this.columnDesc = new System.Windows.Forms.ColumnHeader();
            this.columnFecha = new System.Windows.Forms.ColumnHeader();
            this.columnImporte = new System.Windows.Forms.ColumnHeader();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.btnReporteCaja = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.chartGastos = new FastReport.DataVisualization.Charting.Chart();
            this.chartIngresos = new FastReport.DataVisualization.Charting.Chart();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIngresos)).BeginInit();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listOrdenes
            // 
            this.listOrdenes.AutoSizeTable = false;
            this.listOrdenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listOrdenes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listOrdenes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNro,
            this.columnFechaSalida,
            this.columnIngresos});
            this.listOrdenes.Depth = 0;
            this.listOrdenes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listOrdenes.FullRowSelect = true;
            this.listOrdenes.HideSelection = false;
            this.listOrdenes.Location = new System.Drawing.Point(12, 187);
            this.listOrdenes.MinimumSize = new System.Drawing.Size(200, 100);
            this.listOrdenes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listOrdenes.MouseState = MaterialSkin.MouseState.OUT;
            this.listOrdenes.MultiSelect = false;
            this.listOrdenes.Name = "listOrdenes";
            this.listOrdenes.OwnerDraw = true;
            this.listOrdenes.Size = new System.Drawing.Size(401, 410);
            this.listOrdenes.TabIndex = 0;
            this.listOrdenes.UseCompatibleStateImageBehavior = false;
            this.listOrdenes.View = System.Windows.Forms.View.Details;
            this.listOrdenes.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listOrdenes_ColumnWidthChanging);
            // 
            // columnNro
            // 
            this.columnNro.Text = "N° Orden";
            this.columnNro.Width = 100;
            // 
            // columnFechaSalida
            // 
            this.columnFechaSalida.Text = "Fecha Salida";
            this.columnFechaSalida.Width = 151;
            // 
            // columnIngresos
            // 
            this.columnIngresos.Text = "Dinero ingresado";
            this.columnIngresos.Width = 150;
            // 
            // dtpFecha
            // 
            this.dtpFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dtpFecha.CustomFormat = "dd/MM/yyyy";
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(112, 95);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(196, 23);
            this.dtpFecha.TabIndex = 1;
            this.dtpFecha.Value = new System.DateTime(2022, 10, 4, 0, 0, 0, 0);
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblBalanceHoy);
            this.materialCard1.Controls.Add(this.materialLabel5);
            this.materialCard1.Controls.Add(this.lblSalidasDia);
            this.materialCard1.Controls.Add(this.materialLabel6);
            this.materialCard1.Controls.Add(this.lblIngresosDia);
            this.materialCard1.Controls.Add(this.lblSaldoAnterior);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(420, 95);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(496, 141);
            this.materialCard1.TabIndex = 2;
            // 
            // lblBalanceHoy
            // 
            this.lblBalanceHoy.AutoSize = true;
            this.lblBalanceHoy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblBalanceHoy.Depth = 0;
            this.lblBalanceHoy.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBalanceHoy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBalanceHoy.Location = new System.Drawing.Point(149, 105);
            this.lblBalanceHoy.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBalanceHoy.Name = "lblBalanceHoy";
            this.lblBalanceHoy.Size = new System.Drawing.Size(5, 19);
            this.lblBalanceHoy.TabIndex = 7;
            this.lblBalanceHoy.Text = "-";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(17, 105);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(62, 19);
            this.materialLabel5.TabIndex = 6;
            this.materialLabel5.Text = "Balance:";
            // 
            // lblSalidasDia
            // 
            this.lblSalidasDia.AutoSize = true;
            this.lblSalidasDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblSalidasDia.Depth = 0;
            this.lblSalidasDia.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSalidasDia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSalidasDia.Location = new System.Drawing.Point(149, 72);
            this.lblSalidasDia.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSalidasDia.Name = "lblSalidasDia";
            this.lblSalidasDia.Size = new System.Drawing.Size(5, 19);
            this.lblSalidasDia.TabIndex = 5;
            this.lblSalidasDia.Text = "-";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(17, 72);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(96, 19);
            this.materialLabel6.TabIndex = 4;
            this.materialLabel6.Text = "Total Gastos:";
            // 
            // lblIngresosDia
            // 
            this.lblIngresosDia.AutoSize = true;
            this.lblIngresosDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblIngresosDia.Depth = 0;
            this.lblIngresosDia.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblIngresosDia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIngresosDia.Location = new System.Drawing.Point(149, 41);
            this.lblIngresosDia.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIngresosDia.Name = "lblIngresosDia";
            this.lblIngresosDia.Size = new System.Drawing.Size(5, 19);
            this.lblIngresosDia.TabIndex = 3;
            this.lblIngresosDia.Text = "-";
            // 
            // lblSaldoAnterior
            // 
            this.lblSaldoAnterior.AutoSize = true;
            this.lblSaldoAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblSaldoAnterior.Depth = 0;
            this.lblSaldoAnterior.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSaldoAnterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSaldoAnterior.Location = new System.Drawing.Point(149, 14);
            this.lblSaldoAnterior.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSaldoAnterior.Name = "lblSaldoAnterior";
            this.lblSaldoAnterior.Size = new System.Drawing.Size(5, 19);
            this.lblSaldoAnterior.TabIndex = 2;
            this.lblSaldoAnterior.Text = "-";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(17, 41);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(106, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Total Ingresos:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(17, 14);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(104, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Saldo anterior:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(13, 95);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(94, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Fecha desde:";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(13, 165);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(129, 19);
            this.materialLabel8.TabIndex = 4;
            this.materialLabel8.Text = "Ordenes retiradas:";
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
            this.btnCerrar.Location = new System.Drawing.Point(1228, 603);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCerrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCerrar.Size = new System.Drawing.Size(77, 36);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCerrar.UseAccentColor = false;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // listGastos
            // 
            this.listGastos.AutoSizeTable = false;
            this.listGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listGastos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listGastos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTipoGasto,
            this.columnDesc,
            this.columnFecha,
            this.columnImporte});
            this.listGastos.Depth = 0;
            this.listGastos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listGastos.FullRowSelect = true;
            this.listGastos.HideSelection = false;
            this.listGastos.Location = new System.Drawing.Point(420, 272);
            this.listGastos.MinimumSize = new System.Drawing.Size(200, 100);
            this.listGastos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listGastos.MouseState = MaterialSkin.MouseState.OUT;
            this.listGastos.MultiSelect = false;
            this.listGastos.Name = "listGastos";
            this.listGastos.OwnerDraw = true;
            this.listGastos.Size = new System.Drawing.Size(503, 325);
            this.listGastos.TabIndex = 6;
            this.listGastos.UseCompatibleStateImageBehavior = false;
            this.listGastos.View = System.Windows.Forms.View.Details;
            this.listGastos.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listGastos_ColumnWidthChanging);
            // 
            // columnTipoGasto
            // 
            this.columnTipoGasto.Text = "Tipo Gasto";
            this.columnTipoGasto.Width = 102;
            // 
            // columnDesc
            // 
            this.columnDesc.Text = "Descripción";
            this.columnDesc.Width = 136;
            // 
            // columnFecha
            // 
            this.columnFecha.Text = "Fecha realizado";
            this.columnFecha.Width = 160;
            // 
            // columnImporte
            // 
            this.columnImporte.Text = "Monto";
            this.columnImporte.Width = 99;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(420, 250);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(55, 19);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Gastos:";
            // 
            // btnReporteCaja
            // 
            this.btnReporteCaja.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReporteCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnReporteCaja.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReporteCaja.Depth = 0;
            this.btnReporteCaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReporteCaja.HighEmphasis = true;
            this.btnReporteCaja.Icon = null;
            this.btnReporteCaja.Location = new System.Drawing.Point(12, 603);
            this.btnReporteCaja.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReporteCaja.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReporteCaja.Name = "btnReporteCaja";
            this.btnReporteCaja.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReporteCaja.Size = new System.Drawing.Size(126, 36);
            this.btnReporteCaja.TabIndex = 8;
            this.btnReporteCaja.Text = "Reporte caja";
            this.btnReporteCaja.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReporteCaja.UseAccentColor = false;
            this.btnReporteCaja.UseVisualStyleBackColor = false;
            this.btnReporteCaja.Click += new System.EventHandler(this.btnReporteCaja_Click);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(13, 132);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(92, 19);
            this.materialLabel7.TabIndex = 10;
            this.materialLabel7.Text = "Fecha hasta:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dtpFechaHasta.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpFechaHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHasta.Location = new System.Drawing.Point(112, 130);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(196, 23);
            this.dtpFechaHasta.TabIndex = 9;
            this.dtpFechaHasta.Value = new System.DateTime(2022, 10, 4, 0, 0, 0, 0);
            this.dtpFechaHasta.ValueChanged += new System.EventHandler(this.dtpFechaHasta_ValueChanged);
            // 
            // chartGastos
            // 
            this.chartGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            chartArea1.Name = "ChartArea1";
            this.chartGastos.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartGastos.Legends.Add(legend1);
            this.chartGastos.Location = new System.Drawing.Point(17, 14);
            this.chartGastos.Name = "chartGastos";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            series1.Legend = "Legend1";
            series1.Name = "Gastos";
            this.chartGastos.Series.Add(series1);
            this.chartGastos.Size = new System.Drawing.Size(349, 216);
            this.chartGastos.TabIndex = 11;
            this.chartGastos.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Gastos por categoría";
            this.chartGastos.Titles.Add(title1);
            // 
            // chartIngresos
            // 
            this.chartIngresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            chartArea2.Name = "ChartArea1";
            this.chartIngresos.ChartAreas.Add(chartArea2);
            this.chartIngresos.Location = new System.Drawing.Point(17, 236);
            this.chartIngresos.Name = "chartIngresos";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = FastReport.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Ingresos";
            series2.XValueType = FastReport.DataVisualization.Charting.ChartValueType.Date;
            series2.YValuesPerPoint = 3;
            this.chartIngresos.Series.Add(series2);
            this.chartIngresos.Size = new System.Drawing.Size(349, 251);
            this.chartIngresos.TabIndex = 12;
            this.chartIngresos.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "Evolución de los Ingresos en el Periodo seleccionado";
            this.chartIngresos.Titles.Add(title2);
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.chartGastos);
            this.materialCard2.Controls.Add(this.chartIngresos);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(933, 95);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(380, 502);
            this.materialCard2.TabIndex = 13;
            // 
            // Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 654);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.btnReporteCaja);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.listGastos);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.listOrdenes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Caja";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caja";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIngresos)).EndInit();
            this.materialCard2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listOrdenes;
        private System.Windows.Forms.ColumnHeader columnNro;
        private System.Windows.Forms.ColumnHeader columnFechaSalida;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel lblSalidasDia;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel lblIngresosDia;
        private MaterialSkin.Controls.MaterialLabel lblSaldoAnterior;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialButton btnCerrar;
        private MaterialSkin.Controls.MaterialListView listGastos;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel lblBalanceHoy;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.ColumnHeader columnTipoGasto;
        private System.Windows.Forms.ColumnHeader columnDesc;
        private System.Windows.Forms.ColumnHeader columnFecha;
        private System.Windows.Forms.ColumnHeader columnImporte;
        private MaterialSkin.Controls.MaterialButton btnReporteCaja;
        private System.Windows.Forms.ColumnHeader columnIngresos;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private FastReport.DataVisualization.Charting.Chart chartGastos;
        private FastReport.DataVisualization.Charting.Chart chartIngresos;
        private MaterialSkin.Controls.MaterialCard materialCard2;
    }
}