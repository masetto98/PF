
namespace UI.Desktop
{
    partial class ReporteCuentaCorriente
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
            this.txtBuscarCliente = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnBuscar = new MaterialSkin.Controls.MaterialButton();
            this.columnOrden = new System.Windows.Forms.ColumnHeader();
            this.columnFecha = new System.Windows.Forms.ColumnHeader();
            this.columnNroFactura = new System.Windows.Forms.ColumnHeader();
            this.columnImporte = new System.Windows.Forms.ColumnHeader();
            this.columnPagado = new System.Windows.Forms.ColumnHeader();
            this.columnSaldo = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // listOrdenesCliente
            // 
            this.listOrdenesCliente.AutoSizeTable = false;
            this.listOrdenesCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listOrdenesCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listOrdenesCliente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnOrden,
            this.columnFecha,
            this.columnNroFactura,
            this.columnImporte,
            this.columnPagado,
            this.columnSaldo});
            this.listOrdenesCliente.Depth = 0;
            this.listOrdenesCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listOrdenesCliente.FullRowSelect = true;
            this.listOrdenesCliente.HideSelection = false;
            this.listOrdenesCliente.Location = new System.Drawing.Point(33, 171);
            this.listOrdenesCliente.MinimumSize = new System.Drawing.Size(200, 100);
            this.listOrdenesCliente.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listOrdenesCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.listOrdenesCliente.Name = "listOrdenesCliente";
            this.listOrdenesCliente.OwnerDraw = true;
            this.listOrdenesCliente.Size = new System.Drawing.Size(740, 212);
            this.listOrdenesCliente.TabIndex = 0;
            this.listOrdenesCliente.UseCompatibleStateImageBehavior = false;
            this.listOrdenesCliente.View = System.Windows.Forms.View.Details;
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.AnimateReadOnly = false;
            this.txtBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarCliente.Depth = 0;
            this.txtBuscarCliente.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBuscarCliente.Hint = "Ingrese nombre, apellido o cuit del cliente";
            this.txtBuscarCliente.LeadingIcon = null;
            this.txtBuscarCliente.Location = new System.Drawing.Point(92, 104);
            this.txtBuscarCliente.MaxLength = 50;
            this.txtBuscarCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscarCliente.Multiline = false;
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(318, 50);
            this.txtBuscarCliente.TabIndex = 1;
            this.txtBuscarCliente.Text = "";
            this.txtBuscarCliente.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(33, 118);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(53, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Cliente:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBuscar.HighEmphasis = true;
            this.btnBuscar.Icon = null;
            this.btnBuscar.Location = new System.Drawing.Point(417, 108);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscar.Size = new System.Drawing.Size(77, 36);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscar.UseAccentColor = false;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // columnOrden
            // 
            this.columnOrden.Text = "Nro Orden";
            this.columnOrden.Width = 120;
            // 
            // columnFecha
            // 
            this.columnFecha.Text = "Fecha";
            this.columnFecha.Width = 200;
            // 
            // columnNroFactura
            // 
            this.columnNroFactura.Text = "Nro Factura";
            this.columnNroFactura.Width = 120;
            // 
            // columnImporte
            // 
            this.columnImporte.Text = "Importe";
            this.columnImporte.Width = 100;
            // 
            // columnPagado
            // 
            this.columnPagado.Text = "Pagado";
            this.columnPagado.Width = 100;
            // 
            // columnSaldo
            // 
            this.columnSaldo.Text = "Saldo";
            this.columnSaldo.Width = 100;
            // 
            // ReporteCuentaCorriente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 489);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.listOrdenesCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReporteCuentaCorriente";
            this.Text = "Cuenta corriente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listOrdenesCliente;
        private System.Windows.Forms.ColumnHeader columnOrden;
        private System.Windows.Forms.ColumnHeader columnFecha;
        private System.Windows.Forms.ColumnHeader columnNroFactura;
        private System.Windows.Forms.ColumnHeader columnImporte;
        private System.Windows.Forms.ColumnHeader columnPagado;
        private System.Windows.Forms.ColumnHeader columnSaldo;
        private MaterialSkin.Controls.MaterialTextBox txtBuscarCliente;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnBuscar;
    }
}