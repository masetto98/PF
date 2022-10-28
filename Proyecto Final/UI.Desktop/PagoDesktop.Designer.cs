
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
            this.components = new System.ComponentModel.Container();
            this.txtNroFactura = new MaterialSkin.Controls.MaterialTextBox();
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
            this.txtTotalFactura = new MaterialSkin.Controls.MaterialTextBox();
            this.txtApagar = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSaldarDeuda = new MaterialSkin.Controls.MaterialButton();
            this.ayudaPago = new System.Windows.Forms.ToolTip(this.components);
            this.txtSenia = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.AnimateReadOnly = false;
            this.txtNroFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtNroFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNroFactura.Depth = 0;
            this.txtNroFactura.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNroFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNroFactura.Hint = "N° Factura";
            this.txtNroFactura.LeadingIcon = null;
            this.txtNroFactura.Location = new System.Drawing.Point(29, 103);
            this.txtNroFactura.MaxLength = 50;
            this.txtNroFactura.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNroFactura.Multiline = false;
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.Size = new System.Drawing.Size(119, 50);
            this.txtNroFactura.TabIndex = 0;
            this.txtNroFactura.Text = "";
            this.txtNroFactura.TrailingIcon = null;
            // 
            // cbFormaPago
            // 
            this.cbFormaPago.AutoResize = false;
            this.cbFormaPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cbFormaPago.Depth = 0;
            this.cbFormaPago.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbFormaPago.DropDownHeight = 174;
            this.cbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaPago.DropDownWidth = 121;
            this.cbFormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbFormaPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.materialLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.listPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listPagos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listPagos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNroFactura,
            this.columnFechaPago,
            this.columnFormaPago,
            this.columnImporte});
            this.listPagos.Depth = 0;
            this.listPagos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listPagos.FullRowSelect = true;
            this.listPagos.HideSelection = false;
            this.listPagos.Location = new System.Drawing.Point(81, 74);
            this.listPagos.MinimumSize = new System.Drawing.Size(200, 100);
            this.listPagos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listPagos.MouseState = MaterialSkin.MouseState.OUT;
            this.listPagos.MultiSelect = false;
            this.listPagos.Name = "listPagos";
            this.listPagos.OwnerDraw = true;
            this.listPagos.Size = new System.Drawing.Size(550, 129);
            this.listPagos.TabIndex = 4;
            this.listPagos.UseCompatibleStateImageBehavior = false;
            this.listPagos.View = System.Windows.Forms.View.Details;
            this.listPagos.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listPagos_ColumnWidthChanging);
            // 
            // columnNroFactura
            // 
            this.columnNroFactura.Text = "Nro Factura";
            this.columnNroFactura.Width = 110;
            // 
            // columnFechaPago
            // 
            this.columnFechaPago.Text = "Fecha de Pago";
            this.columnFechaPago.Width = 190;
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
            this.txtImportePago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtImportePago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImportePago.Depth = 0;
            this.txtImportePago.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtImportePago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtImportePago.LeadingIcon = null;
            this.txtImportePago.Location = new System.Drawing.Point(438, 17);
            this.txtImportePago.MaxLength = 50;
            this.txtImportePago.MouseState = MaterialSkin.MouseState.OUT;
            this.txtImportePago.Multiline = false;
            this.txtImportePago.Name = "txtImportePago";
            this.txtImportePago.Size = new System.Drawing.Size(128, 50);
            this.txtImportePago.TabIndex = 5;
            this.txtImportePago.Text = "";
            this.ayudaPago.SetToolTip(this.txtImportePago, "Recuerde seleccionar la forma de pago antes de ingresar un importe.\r\n");
            this.txtImportePago.TrailingIcon = null;
            this.txtImportePago.TextChanged += new System.EventHandler(this.txtImportePago_TextChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.btnCancelarPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCancelarPago.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelarPago.Depth = 0;
            this.btnCancelarPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelarPago.HighEmphasis = true;
            this.btnCancelarPago.Icon = null;
            this.btnCancelarPago.Location = new System.Drawing.Point(668, 387);
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
            this.btnAceptarPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAceptarPago.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAceptarPago.Depth = 0;
            this.btnAceptarPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAceptarPago.HighEmphasis = true;
            this.btnAceptarPago.Icon = null;
            this.btnAceptarPago.Location = new System.Drawing.Point(574, 387);
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
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btnAgregarPago);
            this.materialCard1.Controls.Add(this.listPagos);
            this.materialCard1.Controls.Add(this.txtImportePago);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.cbFormaPago);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(29, 160);
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
            this.btnAgregarPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAgregarPago.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarPago.Depth = 0;
            this.btnAgregarPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAgregarPago.HighEmphasis = true;
            this.btnAgregarPago.Icon = global::UI.Desktop.Properties.Resources.pay_payment_bill_dollar_cash_icon_143281;
            this.btnAgregarPago.Location = new System.Drawing.Point(601, 26);
            this.btnAgregarPago.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarPago.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarPago.Name = "btnAgregarPago";
            this.btnAgregarPago.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarPago.Size = new System.Drawing.Size(116, 36);
            this.btnAgregarPago.TabIndex = 7;
            this.btnAgregarPago.Text = "Agregar";
            this.btnAgregarPago.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarPago.UseAccentColor = false;
            this.btnAgregarPago.UseVisualStyleBackColor = false;
            this.btnAgregarPago.Click += new System.EventHandler(this.btnAgregarPago_Click);
            // 
            // txtTotalFactura
            // 
            this.txtTotalFactura.AnimateReadOnly = false;
            this.txtTotalFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtTotalFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalFactura.Depth = 0;
            this.txtTotalFactura.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTotalFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTotalFactura.Hint = "Total Factura";
            this.txtTotalFactura.LeadingIcon = null;
            this.txtTotalFactura.Location = new System.Drawing.Point(154, 103);
            this.txtTotalFactura.MaxLength = 50;
            this.txtTotalFactura.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotalFactura.Multiline = false;
            this.txtTotalFactura.Name = "txtTotalFactura";
            this.txtTotalFactura.Size = new System.Drawing.Size(143, 50);
            this.txtTotalFactura.TabIndex = 10;
            this.txtTotalFactura.Text = "";
            this.txtTotalFactura.TrailingIcon = null;
            // 
            // txtApagar
            // 
            this.txtApagar.AnimateReadOnly = false;
            this.txtApagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtApagar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApagar.Depth = 0;
            this.txtApagar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtApagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtApagar.Hint = "Total a pagar";
            this.txtApagar.LeadingIcon = null;
            this.txtApagar.Location = new System.Drawing.Point(472, 103);
            this.txtApagar.MaxLength = 50;
            this.txtApagar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtApagar.Multiline = false;
            this.txtApagar.Name = "txtApagar";
            this.txtApagar.Size = new System.Drawing.Size(163, 50);
            this.txtApagar.TabIndex = 12;
            this.txtApagar.Text = "";
            this.txtApagar.TrailingIcon = null;
            this.txtApagar.TextChanged += new System.EventHandler(this.txtApagar_TextChanged);
            // 
            // btnSaldarDeuda
            // 
            this.btnSaldarDeuda.AutoSize = false;
            this.btnSaldarDeuda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaldarDeuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnSaldarDeuda.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaldarDeuda.Depth = 0;
            this.btnSaldarDeuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSaldarDeuda.HighEmphasis = true;
            this.btnSaldarDeuda.Icon = global::UI.Desktop.Properties.Resources.paying_money_invoice_payment_your_bill_icon_220368;
            this.btnSaldarDeuda.Location = new System.Drawing.Point(645, 102);
            this.btnSaldarDeuda.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaldarDeuda.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaldarDeuda.Name = "btnSaldarDeuda";
            this.btnSaldarDeuda.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaldarDeuda.Size = new System.Drawing.Size(119, 51);
            this.btnSaldarDeuda.TabIndex = 14;
            this.btnSaldarDeuda.Text = "Saldar Deuda";
            this.ayudaPago.SetToolTip(this.btnSaldarDeuda, "Al presionar se añadirá un pago en \"efectivo\" con un importe igual al total a pag" +
        "ar. \r\nPor favor, utilizar si desea cancelar el total de una deuda.");
            this.btnSaldarDeuda.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaldarDeuda.UseAccentColor = false;
            this.btnSaldarDeuda.UseVisualStyleBackColor = false;
            this.btnSaldarDeuda.Click += new System.EventHandler(this.btnSaldarDeuda_Click);
            // 
            // ayudaPago
            // 
            this.ayudaPago.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // txtSenia
            // 
            this.txtSenia.AnimateReadOnly = false;
            this.txtSenia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtSenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenia.Depth = 0;
            this.txtSenia.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSenia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtSenia.Hint = "Seña";
            this.txtSenia.LeadingIcon = null;
            this.txtSenia.Location = new System.Drawing.Point(303, 103);
            this.txtSenia.MaxLength = 50;
            this.txtSenia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSenia.Multiline = false;
            this.txtSenia.Name = "txtSenia";
            this.txtSenia.Size = new System.Drawing.Size(163, 50);
            this.txtSenia.TabIndex = 15;
            this.txtSenia.Text = "";
            this.txtSenia.TrailingIcon = null;
            // 
            // PagoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 434);
            this.Controls.Add(this.txtSenia);
            this.Controls.Add(this.btnSaldarDeuda);
            this.Controls.Add(this.txtApagar);
            this.Controls.Add(this.txtTotalFactura);
            this.Controls.Add(this.btnAceptarPago);
            this.Controls.Add(this.btnCancelarPago);
            this.Controls.Add(this.txtNroFactura);
            this.Controls.Add(this.materialCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "PagoDesktop";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagos";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtNroFactura;
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
        private MaterialSkin.Controls.MaterialTextBox txtTotalFactura;
        private MaterialSkin.Controls.MaterialTextBox txtApagar;
        private MaterialSkin.Controls.MaterialButton btnSaldarDeuda;
        private System.Windows.Forms.ToolTip ayudaPago;
        private MaterialSkin.Controls.MaterialTextBox txtSenia;
    }
}