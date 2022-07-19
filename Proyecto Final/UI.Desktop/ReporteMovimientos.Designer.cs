
namespace UI.Desktop
{
    partial class ReporteMovimientos
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
            this.listInsumos = new MaterialSkin.Controls.MaterialListView();
            this.columnID = new System.Windows.Forms.ColumnHeader();
            this.columnDesc = new System.Windows.Forms.ColumnHeader();
            this.listIngresos = new MaterialSkin.Controls.MaterialListView();
            this.columnProveedor = new System.Windows.Forms.ColumnHeader();
            this.columnFecha = new System.Windows.Forms.ColumnHeader();
            this.columnCant = new System.Windows.Forms.ColumnHeader();
            this.listEgresos = new MaterialSkin.Controls.MaterialListView();
            this.columnNroOrden = new System.Windows.Forms.ColumnHeader();
            this.columnServicio = new System.Windows.Forms.ColumnHeader();
            this.columntp = new System.Windows.Forms.ColumnHeader();
            this.columnCantidad = new System.Windows.Forms.ColumnHeader();
            this.btnDetalles = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.btnCerrar = new MaterialSkin.Controls.MaterialButton();
            this.btnReporteMovimientos = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // listInsumos
            // 
            this.listInsumos.AutoSizeTable = false;
            this.listInsumos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listInsumos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listInsumos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnDesc});
            this.listInsumos.Depth = 0;
            this.listInsumos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listInsumos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listInsumos.FullRowSelect = true;
            this.listInsumos.HideSelection = false;
            this.listInsumos.Location = new System.Drawing.Point(12, 93);
            this.listInsumos.MinimumSize = new System.Drawing.Size(200, 100);
            this.listInsumos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listInsumos.MouseState = MaterialSkin.MouseState.OUT;
            this.listInsumos.Name = "listInsumos";
            this.listInsumos.OwnerDraw = true;
            this.listInsumos.Size = new System.Drawing.Size(300, 534);
            this.listInsumos.TabIndex = 0;
            this.listInsumos.UseCompatibleStateImageBehavior = false;
            this.listInsumos.View = System.Windows.Forms.View.Details;
            this.listInsumos.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listInsumos_ColumnWidthChanging);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 100;
            // 
            // columnDesc
            // 
            this.columnDesc.Text = "Descripción";
            this.columnDesc.Width = 200;
            // 
            // listIngresos
            // 
            this.listIngresos.AutoSizeTable = false;
            this.listIngresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listIngresos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listIngresos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnProveedor,
            this.columnFecha,
            this.columnCant});
            this.listIngresos.Depth = 0;
            this.listIngresos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listIngresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listIngresos.FullRowSelect = true;
            this.listIngresos.HideSelection = false;
            this.listIngresos.Location = new System.Drawing.Point(464, 179);
            this.listIngresos.MinimumSize = new System.Drawing.Size(200, 100);
            this.listIngresos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listIngresos.MouseState = MaterialSkin.MouseState.OUT;
            this.listIngresos.Name = "listIngresos";
            this.listIngresos.OwnerDraw = true;
            this.listIngresos.Size = new System.Drawing.Size(650, 200);
            this.listIngresos.TabIndex = 1;
            this.listIngresos.UseCompatibleStateImageBehavior = false;
            this.listIngresos.View = System.Windows.Forms.View.Details;
            this.listIngresos.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listIngresos_ColumnWidthChanging);
            // 
            // columnProveedor
            // 
            this.columnProveedor.Text = "Proveedor";
            this.columnProveedor.Width = 250;
            // 
            // columnFecha
            // 
            this.columnFecha.Text = "Fecha ingreso";
            this.columnFecha.Width = 250;
            // 
            // columnCant
            // 
            this.columnCant.Text = "Cantidad";
            this.columnCant.Width = 150;
            // 
            // listEgresos
            // 
            this.listEgresos.AutoSizeTable = false;
            this.listEgresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listEgresos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listEgresos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNroOrden,
            this.columnServicio,
            this.columntp,
            this.columnCantidad});
            this.listEgresos.Depth = 0;
            this.listEgresos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listEgresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listEgresos.FullRowSelect = true;
            this.listEgresos.HideSelection = false;
            this.listEgresos.Location = new System.Drawing.Point(464, 427);
            this.listEgresos.MinimumSize = new System.Drawing.Size(200, 100);
            this.listEgresos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listEgresos.MouseState = MaterialSkin.MouseState.OUT;
            this.listEgresos.Name = "listEgresos";
            this.listEgresos.OwnerDraw = true;
            this.listEgresos.Size = new System.Drawing.Size(650, 200);
            this.listEgresos.TabIndex = 2;
            this.listEgresos.UseCompatibleStateImageBehavior = false;
            this.listEgresos.View = System.Windows.Forms.View.Details;
            this.listEgresos.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listEgresos_ColumnWidthChanging);
            // 
            // columnNroOrden
            // 
            this.columnNroOrden.Text = "Nro Orden";
            this.columnNroOrden.Width = 120;
            // 
            // columnServicio
            // 
            this.columnServicio.Text = "Servicio";
            this.columnServicio.Width = 200;
            // 
            // columntp
            // 
            this.columntp.Text = "Tipo Prenda";
            this.columntp.Width = 200;
            // 
            // columnCantidad
            // 
            this.columnCantidad.Text = "Consumo";
            this.columnCantidad.Width = 120;
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
            this.btnDetalles.Location = new System.Drawing.Point(319, 93);
            this.btnDetalles.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDetalles.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDetalles.Size = new System.Drawing.Size(114, 51);
            this.btnDetalles.TabIndex = 3;
            this.btnDetalles.Text = "Detalles";
            this.btnDetalles.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDetalles.UseAccentColor = false;
            this.btnDetalles.UseVisualStyleBackColor = false;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(464, 154);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(65, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Ingresos:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(464, 405);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(61, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Egresos:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaDesde.Location = new System.Drawing.Point(694, 105);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(157, 23);
            this.dtpFechaDesde.TabIndex = 6;
            this.dtpFechaDesde.ValueChanged += new System.EventHandler(this.dtpFechaDesde_ValueChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(594, 105);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(94, 19);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "Fecha desde:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(857, 107);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(92, 19);
            this.materialLabel4.TabIndex = 9;
            this.materialLabel4.Text = "Fecha hasta:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHasta.Location = new System.Drawing.Point(957, 105);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(157, 23);
            this.dtpFechaHasta.TabIndex = 8;
            this.dtpFechaHasta.ValueChanged += new System.EventHandler(this.dtpFechaHasta_ValueChanged);
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
            this.btnCerrar.Location = new System.Drawing.Point(1037, 643);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCerrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCerrar.Size = new System.Drawing.Size(77, 36);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCerrar.UseAccentColor = false;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnReporteMovimientos
            // 
            this.btnReporteMovimientos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReporteMovimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnReporteMovimientos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReporteMovimientos.Depth = 0;
            this.btnReporteMovimientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReporteMovimientos.HighEmphasis = true;
            this.btnReporteMovimientos.Icon = null;
            this.btnReporteMovimientos.Location = new System.Drawing.Point(13, 643);
            this.btnReporteMovimientos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReporteMovimientos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReporteMovimientos.Name = "btnReporteMovimientos";
            this.btnReporteMovimientos.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReporteMovimientos.Size = new System.Drawing.Size(189, 36);
            this.btnReporteMovimientos.TabIndex = 11;
            this.btnReporteMovimientos.Text = "Reporte Movimientos";
            this.btnReporteMovimientos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReporteMovimientos.UseAccentColor = false;
            this.btnReporteMovimientos.UseVisualStyleBackColor = false;
            this.btnReporteMovimientos.Click += new System.EventHandler(this.btnReporteMovimientos_Click);
            // 
            // ReporteMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 694);
            this.Controls.Add(this.btnReporteMovimientos);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.listEgresos);
            this.Controls.Add(this.listIngresos);
            this.Controls.Add(this.listInsumos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ReporteMovimientos";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimientos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listInsumos;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnDesc;
        private MaterialSkin.Controls.MaterialListView listIngresos;
        private MaterialSkin.Controls.MaterialListView listEgresos;
        private MaterialSkin.Controls.MaterialButton btnDetalles;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.ColumnHeader columnProveedor;
        private System.Windows.Forms.ColumnHeader columnFecha;
        private System.Windows.Forms.ColumnHeader columnCant;
        private System.Windows.Forms.ColumnHeader columnNroOrden;
        private System.Windows.Forms.ColumnHeader columnServicio;
        private System.Windows.Forms.ColumnHeader columntp;
        private MaterialSkin.Controls.MaterialButton btnCerrar;
        private MaterialSkin.Controls.MaterialButton btnReporteMovimientos;
        private System.Windows.Forms.ColumnHeader columnCantidad;
    }
}