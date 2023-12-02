
namespace UI.Desktop
{
    partial class ReporteEnvioDomicilio
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
            this.listOrd = new MaterialSkin.Controls.MaterialListView();
            this.columnCliente = new System.Windows.Forms.ColumnHeader();
            this.columnNroOrden = new System.Windows.Forms.ColumnHeader();
            this.columnFechaEntrega = new System.Windows.Forms.ColumnHeader();
            this.columnServicios = new System.Windows.Forms.ColumnHeader();
            this.columnDomicilio = new System.Windows.Forms.ColumnHeader();
            this.columnTelef = new System.Windows.Forms.ColumnHeader();
            this.columnImporte = new System.Windows.Forms.ColumnHeader();
            this.btnCerrar = new MaterialSkin.Controls.MaterialButton();
            this.btnReporteGastos = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // listOrd
            // 
            this.listOrd.AutoSizeTable = false;
            this.listOrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listOrd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listOrd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCliente,
            this.columnNroOrden,
            this.columnFechaEntrega,
            this.columnServicios,
            this.columnDomicilio,
            this.columnTelef,
            this.columnImporte});
            this.listOrd.Depth = 0;
            this.listOrd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listOrd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listOrd.FullRowSelect = true;
            this.listOrd.HideSelection = false;
            this.listOrd.Location = new System.Drawing.Point(12, 115);
            this.listOrd.MinimumSize = new System.Drawing.Size(200, 100);
            this.listOrd.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listOrd.MouseState = MaterialSkin.MouseState.OUT;
            this.listOrd.MultiSelect = false;
            this.listOrd.Name = "listOrd";
            this.listOrd.OwnerDraw = true;
            this.listOrd.ShowItemToolTips = true;
            this.listOrd.Size = new System.Drawing.Size(1035, 328);
            this.listOrd.TabIndex = 0;
            this.listOrd.UseCompatibleStateImageBehavior = false;
            this.listOrd.View = System.Windows.Forms.View.Details;
            this.listOrd.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listGastos_ColumnWidthChanging);
            // 
            // columnCliente
            // 
            this.columnCliente.Text = "Cliente";
            this.columnCliente.Width = 150;
            // 
            // columnNroOrden
            // 
            this.columnNroOrden.Text = "N° Orden";
            this.columnNroOrden.Width = 100;
            // 
            // columnFechaEntrega
            // 
            this.columnFechaEntrega.Text = "Fecha Entrega";
            this.columnFechaEntrega.Width = 165;
            // 
            // columnServicios
            // 
            this.columnServicios.Text = "Servicios";
            this.columnServicios.Width = 200;
            // 
            // columnDomicilio
            // 
            this.columnDomicilio.Text = "Domicilio";
            this.columnDomicilio.Width = 160;
            // 
            // columnTelef
            // 
            this.columnTelef.Text = "Telefono";
            this.columnTelef.Width = 130;
            // 
            // columnImporte
            // 
            this.columnImporte.Text = "Monto a pagar";
            this.columnImporte.Width = 130;
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
            this.btnCerrar.Location = new System.Drawing.Point(970, 449);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCerrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCerrar.Size = new System.Drawing.Size(77, 36);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCerrar.UseAccentColor = false;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnReporteGastos
            // 
            this.btnReporteGastos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReporteGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnReporteGastos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReporteGastos.Depth = 0;
            this.btnReporteGastos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReporteGastos.HighEmphasis = true;
            this.btnReporteGastos.Icon = null;
            this.btnReporteGastos.Location = new System.Drawing.Point(12, 449);
            this.btnReporteGastos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReporteGastos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReporteGastos.Name = "btnReporteGastos";
            this.btnReporteGastos.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReporteGastos.Size = new System.Drawing.Size(232, 36);
            this.btnReporteGastos.TabIndex = 2;
            this.btnReporteGastos.Text = "Reporte Envios Pendientes";
            this.btnReporteGastos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReporteGastos.UseAccentColor = false;
            this.btnReporteGastos.UseVisualStyleBackColor = false;
            this.btnReporteGastos.Click += new System.EventHandler(this.btnReporteGastos_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 90);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(399, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Ordenes finalizadas y pendientes de entrega a domicilio:";
            // 
            // ReporteEnvioDomicilio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 500);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnReporteGastos);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.listOrd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ReporteEnvioDomicilio";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envios a domicilio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listOrd;
        private System.Windows.Forms.ColumnHeader columnCliente;
        private System.Windows.Forms.ColumnHeader columnFechaEntrega;
        private System.Windows.Forms.ColumnHeader columnDomicilio;
        private MaterialSkin.Controls.MaterialButton btnCerrar;
        private MaterialSkin.Controls.MaterialButton btnReporteGastos;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ColumnHeader columnNroOrden;
        private System.Windows.Forms.ColumnHeader columnTelef;
        private System.Windows.Forms.ColumnHeader columnImporte;
        private System.Windows.Forms.ColumnHeader columnServicios;
    }
}