
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
            this.listOrdenes = new MaterialSkin.Controls.MaterialListView();
            this.columnNro = new System.Windows.Forms.ColumnHeader();
            this.columnFechaSalida = new System.Windows.Forms.ColumnHeader();
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
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listOrdenes
            // 
            this.listOrdenes.AutoSizeTable = false;
            this.listOrdenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listOrdenes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listOrdenes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNro,
            this.columnFechaSalida});
            this.listOrdenes.Depth = 0;
            this.listOrdenes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listOrdenes.FullRowSelect = true;
            this.listOrdenes.HideSelection = false;
            this.listOrdenes.Location = new System.Drawing.Point(12, 158);
            this.listOrdenes.MinimumSize = new System.Drawing.Size(200, 100);
            this.listOrdenes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listOrdenes.MouseState = MaterialSkin.MouseState.OUT;
            this.listOrdenes.MultiSelect = false;
            this.listOrdenes.Name = "listOrdenes";
            this.listOrdenes.OwnerDraw = true;
            this.listOrdenes.Size = new System.Drawing.Size(251, 398);
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
            // dtpFecha
            // 
            this.dtpFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dtpFecha.CustomFormat = "dd/MM/yyyy";
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(67, 95);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(196, 23);
            this.dtpFecha.TabIndex = 1;
            this.dtpFecha.Value = new System.DateTime(2022, 6, 18, 22, 9, 43, 0);
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
            this.materialCard1.Location = new System.Drawing.Point(280, 95);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(491, 141);
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
            this.materialLabel5.Size = new System.Drawing.Size(92, 19);
            this.materialLabel5.TabIndex = 6;
            this.materialLabel5.Text = "Balance hoy:";
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
            this.materialLabel6.Size = new System.Drawing.Size(106, 19);
            this.materialLabel6.TabIndex = 4;
            this.materialLabel6.Text = "Gastos del dia:";
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
            this.materialLabel2.Size = new System.Drawing.Size(116, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Ingresos del dia:";
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
            this.materialLabel1.Size = new System.Drawing.Size(48, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Fecha:";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(13, 136);
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
            this.btnCerrar.Location = new System.Drawing.Point(694, 568);
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
            this.listGastos.Location = new System.Drawing.Point(280, 272);
            this.listGastos.MinimumSize = new System.Drawing.Size(200, 100);
            this.listGastos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listGastos.MouseState = MaterialSkin.MouseState.OUT;
            this.listGastos.MultiSelect = false;
            this.listGastos.Name = "listGastos";
            this.listGastos.OwnerDraw = true;
            this.listGastos.Size = new System.Drawing.Size(491, 284);
            this.listGastos.TabIndex = 6;
            this.listGastos.UseCompatibleStateImageBehavior = false;
            this.listGastos.View = System.Windows.Forms.View.Details;
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
            this.columnFecha.Width = 155;
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
            this.materialLabel4.Location = new System.Drawing.Point(280, 250);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(106, 19);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Gastos del dia:";
            // 
            // Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 619);
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
    }
}