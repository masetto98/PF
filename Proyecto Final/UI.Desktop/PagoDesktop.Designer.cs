
namespace UI.Desktop
{
    partial class PagoDesktop
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
            this.txtNroFactura = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cbFormaPago = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.listPagos = new MaterialSkin.Controls.MaterialListView();
            this.columnNroFactura = new System.Windows.Forms.ColumnHeader();
            this.columnFechaPago = new System.Windows.Forms.ColumnHeader();
            this.columnFormaPago = new System.Windows.Forms.ColumnHeader();
            this.columnImporte = new System.Windows.Forms.ColumnHeader();
            this.txtImportePago = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCancelarPago = new MaterialSkin.Controls.MaterialButton();
            this.btnAceptarPago = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btnAgregarPago = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTotalFactura = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtApagar = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSaldarDeuda = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.AnimateReadOnly = false;
            this.txtNroFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtNroFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNroFactura.Depth = 0;
            this.txtNroFactura.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNroFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtNroFactura.LeadingIcon = null;
            this.txtNroFactura.Location = new System.Drawing.Point(126, 104);
            this.txtNroFactura.MaxLength = 50;
            this.txtNroFactura.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNroFactura.Multiline = false;
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.Size = new System.Drawing.Size(84, 50);
            this.txtNroFactura.TabIndex = 0;
            this.txtNroFactura.Text = "";
            this.txtNroFactura.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel1.Location = new System.Drawing.Point(29, 119);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(88, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Nro Factura:";
            // 
            // cbFormaPago
            // 
            this.cbFormaPago.AutoResize = false;
            this.cbFormaPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cbFormaPago.Depth = 0;
            this.cbFormaPago.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbFormaPago.DropDownHeight = 174;
            this.cbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaPago.DropDownWidth = 121;
            this.cbFormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbFormaPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbFormaPago.FormattingEnabled = true;
            this.cbFormaPago.IntegralHeight = false;
            this.cbFormaPago.ItemHeight = 43;
            this.cbFormaPago.Location = new System.Drawing.Point(178, 18);
            this.cbFormaPago.MaxDropDownItems = 4;
            this.cbFormaPago.MouseState = MaterialSkin.MouseState.OUT;
            this.cbFormaPago.Name = "cbFormaPago";
            this.cbFormaPago.Size = new System.Drawing.Size(184, 49);
            this.cbFormaPago.StartIndex = 0;
            this.cbFormaPago.TabIndex = 2;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel2.Location = new System.Drawing.Point(53, 32);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(113, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Forma de Pago:";
            // 
            // listPagos
            // 
            this.listPagos.AutoSizeTable = false;
            this.listPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.listPagos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listPagos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNroFactura,
            this.columnFechaPago,
            this.columnFormaPago,
            this.columnImporte});
            this.listPagos.Depth = 0;
            this.listPagos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listPagos.FullRowSelect = true;
            this.listPagos.HideSelection = false;
            this.listPagos.Location = new System.Drawing.Point(103, 74);
            this.listPagos.MinimumSize = new System.Drawing.Size(200, 100);
            this.listPagos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listPagos.MouseState = MaterialSkin.MouseState.OUT;
            this.listPagos.Name = "listPagos";
            this.listPagos.OwnerDraw = true;
            this.listPagos.Size = new System.Drawing.Size(520, 129);
            this.listPagos.TabIndex = 4;
            this.listPagos.UseCompatibleStateImageBehavior = false;
            this.listPagos.View = System.Windows.Forms.View.Details;
            // 
            // columnNroFactura
            // 
            this.columnNroFactura.Text = "Nro Factura";
            this.columnNroFactura.Width = 110;
            // 
            // columnFechaPago
            // 
            this.columnFechaPago.Text = "Fecha de Pago";
            this.columnFechaPago.Width = 160;
            // 
            // columnFormaPago
            // 
            this.columnFormaPago.Text = "Forma de Pago";
            this.columnFormaPago.Width = 140;
            // 
            // columnImporte
            // 
            this.columnImporte.Text = "Importe";
            this.columnImporte.Width = 110;
            // 
            // txtImportePago
            // 
            this.txtImportePago.AnimateReadOnly = false;
            this.txtImportePago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtImportePago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImportePago.Depth = 0;
            this.txtImportePago.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtImportePago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtImportePago.LeadingIcon = null;
            this.txtImportePago.Location = new System.Drawing.Point(438, 17);
            this.txtImportePago.MaxLength = 50;
            this.txtImportePago.MouseState = MaterialSkin.MouseState.OUT;
            this.txtImportePago.Multiline = false;
            this.txtImportePago.Name = "txtImportePago";
            this.txtImportePago.Size = new System.Drawing.Size(128, 50);
            this.txtImportePago.TabIndex = 5;
            this.txtImportePago.Text = "";
            this.txtImportePago.TrailingIcon = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel3.Location = new System.Drawing.Point(373, 32);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(59, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Importe:";
            // 
            // btnCancelarPago
            // 
            this.btnCancelarPago.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelarPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCancelarPago.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelarPago.Depth = 0;
            this.btnCancelarPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancelarPago.HighEmphasis = true;
            this.btnCancelarPago.Icon = null;
            this.btnCancelarPago.Location = new System.Drawing.Point(668, 462);
            this.btnCancelarPago.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelarPago.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelarPago.Name = "btnCancelarPago";
            this.btnCancelarPago.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelarPago.Size = new System.Drawing.Size(96, 36);
            this.btnCancelarPago.TabIndex = 7;
            this.btnCancelarPago.Text = "Cancelar";
            this.btnCancelarPago.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelarPago.UseAccentColor = false;
            this.btnCancelarPago.UseVisualStyleBackColor = false;
            this.btnCancelarPago.Click += new System.EventHandler(this.btnCancelarPago_Click);
            // 
            // btnAceptarPago
            // 
            this.btnAceptarPago.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptarPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAceptarPago.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAceptarPago.Depth = 0;
            this.btnAceptarPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAceptarPago.HighEmphasis = true;
            this.btnAceptarPago.Icon = null;
            this.btnAceptarPago.Location = new System.Drawing.Point(566, 462);
            this.btnAceptarPago.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAceptarPago.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptarPago.Name = "btnAceptarPago";
            this.btnAceptarPago.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAceptarPago.Size = new System.Drawing.Size(86, 36);
            this.btnAceptarPago.TabIndex = 8;
            this.btnAceptarPago.Text = "Aceptar";
            this.btnAceptarPago.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAceptarPago.UseAccentColor = false;
            this.btnAceptarPago.UseVisualStyleBackColor = false;
            this.btnAceptarPago.Click += new System.EventHandler(this.btnAceptarPago_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.materialCard1.Controls.Add(this.btnAgregarPago);
            this.materialCard1.Controls.Add(this.listPagos);
            this.materialCard1.Controls.Add(this.txtImportePago);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.cbFormaPago);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Location = new System.Drawing.Point(29, 222);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(735, 220);
            this.materialCard1.TabIndex = 9;
            // 
            // btnAgregarPago
            // 
            this.btnAgregarPago.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAgregarPago.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarPago.Depth = 0;
            this.btnAgregarPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAgregarPago.HighEmphasis = true;
            this.btnAgregarPago.Icon = null;
            this.btnAgregarPago.Location = new System.Drawing.Point(582, 24);
            this.btnAgregarPago.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarPago.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarPago.Name = "btnAgregarPago";
            this.btnAgregarPago.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarPago.Size = new System.Drawing.Size(88, 36);
            this.btnAgregarPago.TabIndex = 7;
            this.btnAgregarPago.Text = "Agregar";
            this.btnAgregarPago.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarPago.UseAccentColor = false;
            this.btnAgregarPago.UseVisualStyleBackColor = false;
            this.btnAgregarPago.Click += new System.EventHandler(this.btnAgregarPago_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel4.Location = new System.Drawing.Point(216, 119);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(100, 19);
            this.materialLabel4.TabIndex = 11;
            this.materialLabel4.Text = "Total Factura:";
            // 
            // txtTotalFactura
            // 
            this.txtTotalFactura.AnimateReadOnly = false;
            this.txtTotalFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtTotalFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalFactura.Depth = 0;
            this.txtTotalFactura.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTotalFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtTotalFactura.LeadingIcon = null;
            this.txtTotalFactura.Location = new System.Drawing.Point(320, 104);
            this.txtTotalFactura.MaxLength = 50;
            this.txtTotalFactura.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotalFactura.Multiline = false;
            this.txtTotalFactura.Name = "txtTotalFactura";
            this.txtTotalFactura.Size = new System.Drawing.Size(143, 50);
            this.txtTotalFactura.TabIndex = 10;
            this.txtTotalFactura.Text = "";
            this.txtTotalFactura.TrailingIcon = null;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialLabel5.Location = new System.Drawing.Point(495, 119);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(100, 19);
            this.materialLabel5.TabIndex = 13;
            this.materialLabel5.Text = "Total a pagar:";
            // 
            // txtApagar
            // 
            this.txtApagar.AnimateReadOnly = false;
            this.txtApagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtApagar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApagar.Depth = 0;
            this.txtApagar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtApagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtApagar.LeadingIcon = null;
            this.txtApagar.Location = new System.Drawing.Point(601, 103);
            this.txtApagar.MaxLength = 50;
            this.txtApagar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtApagar.Multiline = false;
            this.txtApagar.Name = "txtApagar";
            this.txtApagar.Size = new System.Drawing.Size(163, 50);
            this.txtApagar.TabIndex = 12;
            this.txtApagar.Text = "";
            this.txtApagar.TrailingIcon = null;
            // 
            // btnSaldarDeuda
            // 
            this.btnSaldarDeuda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaldarDeuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSaldarDeuda.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaldarDeuda.Depth = 0;
            this.btnSaldarDeuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSaldarDeuda.HighEmphasis = true;
            this.btnSaldarDeuda.Icon = null;
            this.btnSaldarDeuda.Location = new System.Drawing.Point(29, 173);
            this.btnSaldarDeuda.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaldarDeuda.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaldarDeuda.Name = "btnSaldarDeuda";
            this.btnSaldarDeuda.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaldarDeuda.Size = new System.Drawing.Size(127, 36);
            this.btnSaldarDeuda.TabIndex = 14;
            this.btnSaldarDeuda.Text = "Saldar Deuda";
            this.btnSaldarDeuda.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaldarDeuda.UseAccentColor = false;
            this.btnSaldarDeuda.UseVisualStyleBackColor = false;
            this.btnSaldarDeuda.Click += new System.EventHandler(this.btnSaldarDeuda_Click);
            // 
            // PagoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 555);
            this.Controls.Add(this.btnSaldarDeuda);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.txtApagar);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtTotalFactura);
            this.Controls.Add(this.btnAceptarPago);
            this.Controls.Add(this.btnCancelarPago);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtNroFactura);
            this.Controls.Add(this.materialCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PagoDesktop";
            this.Sizable = false;
            this.Text = "Nuevo Pago";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtNroFactura;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox cbFormaPago;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialListView listPagos;
        private System.Windows.Forms.ColumnHeader columnNroFactura;
        private System.Windows.Forms.ColumnHeader columnFechaPago;
        private System.Windows.Forms.ColumnHeader columnFormaPago;
        private MaterialSkin.Controls.MaterialTextBox txtImportePago;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ColumnHeader columnImporte;
        private MaterialSkin.Controls.MaterialButton btnCancelarPago;
        private MaterialSkin.Controls.MaterialButton btnAceptarPago;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btnAgregarPago;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox txtTotalFactura;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox txtApagar;
        private MaterialSkin.Controls.MaterialButton btnSaldarDeuda;
    }
}