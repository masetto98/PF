
namespace UI.Desktop
{
    partial class ReporteDeudas
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
            this.listOrdenesCliente = new MaterialSkin.Controls.MaterialListView();
            this.columnCliente = new System.Windows.Forms.ColumnHeader();
            this.columnNroOrden = new System.Windows.Forms.ColumnHeader();
            this.columnFechaSalida = new System.Windows.Forms.ColumnHeader();
            this.columnNroFactura = new System.Windows.Forms.ColumnHeader();
            this.columnImporte = new System.Windows.Forms.ColumnHeader();
            this.columnPagos = new System.Windows.Forms.ColumnHeader();
            this.columnDeuda = new System.Windows.Forms.ColumnHeader();
            this.btnReporteDeudas = new MaterialSkin.Controls.MaterialButton();
            this.dtpFiltroDeuda = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBuscar = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnReset = new MaterialSkin.Controls.MaterialButton();
            this.btnCerrar = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // listOrdenesCliente
            // 
            this.listOrdenesCliente.AutoSizeTable = false;
            this.listOrdenesCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listOrdenesCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listOrdenesCliente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCliente,
            this.columnNroOrden,
            this.columnFechaSalida,
            this.columnNroFactura,
            this.columnImporte,
            this.columnPagos,
            this.columnDeuda});
            this.listOrdenesCliente.Depth = 0;
            this.listOrdenesCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listOrdenesCliente.FullRowSelect = true;
            this.listOrdenesCliente.HideSelection = false;
            this.listOrdenesCliente.Location = new System.Drawing.Point(12, 155);
            this.listOrdenesCliente.MinimumSize = new System.Drawing.Size(200, 100);
            this.listOrdenesCliente.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listOrdenesCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.listOrdenesCliente.Name = "listOrdenesCliente";
            this.listOrdenesCliente.OwnerDraw = true;
            this.listOrdenesCliente.Size = new System.Drawing.Size(908, 333);
            this.listOrdenesCliente.TabIndex = 0;
            this.listOrdenesCliente.UseCompatibleStateImageBehavior = false;
            this.listOrdenesCliente.View = System.Windows.Forms.View.Details;
            this.listOrdenesCliente.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listOrdenesCliente_ColumnWidthChanging);
            // 
            // columnCliente
            // 
            this.columnCliente.Text = "Cliente";
            this.columnCliente.Width = 211;
            // 
            // columnNroOrden
            // 
            this.columnNroOrden.Text = "Nro Orden";
            this.columnNroOrden.Width = 96;
            // 
            // columnFechaSalida
            // 
            this.columnFechaSalida.Text = "Fecha de Salida";
            this.columnFechaSalida.Width = 200;
            // 
            // columnNroFactura
            // 
            this.columnNroFactura.Text = "Nro Factura";
            this.columnNroFactura.Width = 106;
            // 
            // columnImporte
            // 
            this.columnImporte.Text = "Importe";
            this.columnImporte.Width = 100;
            // 
            // columnPagos
            // 
            this.columnPagos.Text = "Pagos";
            this.columnPagos.Width = 100;
            // 
            // columnDeuda
            // 
            this.columnDeuda.Text = "Deuda";
            this.columnDeuda.Width = 95;
            // 
            // btnReporteDeudas
            // 
            this.btnReporteDeudas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReporteDeudas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnReporteDeudas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReporteDeudas.Depth = 0;
            this.btnReporteDeudas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReporteDeudas.HighEmphasis = true;
            this.btnReporteDeudas.Icon = null;
            this.btnReporteDeudas.Location = new System.Drawing.Point(13, 497);
            this.btnReporteDeudas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReporteDeudas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReporteDeudas.Name = "btnReporteDeudas";
            this.btnReporteDeudas.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReporteDeudas.Size = new System.Drawing.Size(145, 36);
            this.btnReporteDeudas.TabIndex = 1;
            this.btnReporteDeudas.Text = "Reporte Deudas";
            this.btnReporteDeudas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReporteDeudas.UseAccentColor = false;
            this.btnReporteDeudas.UseVisualStyleBackColor = false;
            this.btnReporteDeudas.Click += new System.EventHandler(this.btnReporteDeudas_Click);
            // 
            // dtpFiltroDeuda
            // 
            this.dtpFiltroDeuda.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFiltroDeuda.Location = new System.Drawing.Point(623, 101);
            this.dtpFiltroDeuda.Name = "dtpFiltroDeuda";
            this.dtpFiltroDeuda.Size = new System.Drawing.Size(200, 23);
            this.dtpFiltroDeuda.TabIndex = 2;
            this.dtpFiltroDeuda.CloseUp += new System.EventHandler(this.dtpFiltroDeuda_CloseUp);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(544, 105);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(77, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "A partir de:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.AnimateReadOnly = false;
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBuscar.Hint = "Ingrese nombre, apellido o cuit del cliente";
            this.txtBuscar.LeadingIcon = null;
            this.txtBuscar.Location = new System.Drawing.Point(72, 87);
            this.txtBuscar.MaxLength = 50;
            this.txtBuscar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscar.Multiline = false;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(321, 50);
            this.txtBuscar.TabIndex = 4;
            this.txtBuscar.Text = "";
            this.txtBuscar.TrailingIcon = null;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 106);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(54, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Buscar:";
            // 
            // btnReset
            // 
            this.btnReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnReset.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReset.Depth = 0;
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReset.HighEmphasis = true;
            this.btnReset.Icon = null;
            this.btnReset.Location = new System.Drawing.Point(855, 96);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReset.Name = "btnReset";
            this.btnReset.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReset.Size = new System.Drawing.Size(65, 36);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "reset";
            this.btnReset.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReset.UseAccentColor = false;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
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
            this.btnCerrar.Location = new System.Drawing.Point(843, 497);
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
            // ReporteDeudas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 548);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dtpFiltroDeuda);
            this.Controls.Add(this.btnReporteDeudas);
            this.Controls.Add(this.listOrdenesCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ReporteDeudas";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deudas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listOrdenesCliente;
        private System.Windows.Forms.ColumnHeader columnCliente;
        private System.Windows.Forms.ColumnHeader columnNroOrden;
        private System.Windows.Forms.ColumnHeader columnFechaSalida;
        private System.Windows.Forms.ColumnHeader columnNroFactura;
        private System.Windows.Forms.ColumnHeader columnImporte;
        private System.Windows.Forms.ColumnHeader columnPagos;
        private System.Windows.Forms.ColumnHeader columnDeuda;
        private MaterialSkin.Controls.MaterialButton btnReporteDeudas;
        private System.Windows.Forms.DateTimePicker dtpFiltroDeuda;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtBuscar;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton btnReset;
        private MaterialSkin.Controls.MaterialButton btnCerrar;
    }
}