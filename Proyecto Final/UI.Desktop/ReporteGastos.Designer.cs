
namespace UI.Desktop
{
    partial class ReporteGastos
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
            this.listGastos = new MaterialSkin.Controls.MaterialListView();
            this.columnFechaRealizado = new System.Windows.Forms.ColumnHeader();
            this.columnTipoGasto = new System.Windows.Forms.ColumnHeader();
            this.columnDescripcion = new System.Windows.Forms.ColumnHeader();
            this.columnImporte = new System.Windows.Forms.ColumnHeader();
            this.btnCerrar = new MaterialSkin.Controls.MaterialButton();
            this.btnReporteGastos = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // listGastos
            // 
            this.listGastos.AutoSizeTable = false;
            this.listGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listGastos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listGastos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFechaRealizado,
            this.columnTipoGasto,
            this.columnDescripcion,
            this.columnImporte});
            this.listGastos.Depth = 0;
            this.listGastos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listGastos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listGastos.FullRowSelect = true;
            this.listGastos.HideSelection = false;
            this.listGastos.Location = new System.Drawing.Point(12, 115);
            this.listGastos.MinimumSize = new System.Drawing.Size(200, 100);
            this.listGastos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listGastos.MouseState = MaterialSkin.MouseState.OUT;
            this.listGastos.MultiSelect = false;
            this.listGastos.Name = "listGastos";
            this.listGastos.OwnerDraw = true;
            this.listGastos.Size = new System.Drawing.Size(690, 328);
            this.listGastos.TabIndex = 0;
            this.listGastos.UseCompatibleStateImageBehavior = false;
            this.listGastos.View = System.Windows.Forms.View.Details;
            this.listGastos.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listGastos_ColumnWidthChanging);
            // 
            // columnFechaRealizado
            // 
            this.columnFechaRealizado.Text = "Fecha Realizado";
            this.columnFechaRealizado.Width = 180;
            // 
            // columnTipoGasto
            // 
            this.columnTipoGasto.Text = "Tipo Gasto";
            this.columnTipoGasto.Width = 150;
            // 
            // columnDescripcion
            // 
            this.columnDescripcion.Text = "Descripción";
            this.columnDescripcion.Width = 240;
            // 
            // columnImporte
            // 
            this.columnImporte.Text = "Monto";
            this.columnImporte.Width = 120;
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
            this.btnCerrar.Location = new System.Drawing.Point(625, 449);
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
            this.btnReporteGastos.Size = new System.Drawing.Size(145, 36);
            this.btnReporteGastos.TabIndex = 2;
            this.btnReporteGastos.Text = "Reporte Gastos";
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
            this.materialLabel1.Size = new System.Drawing.Size(94, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Fecha desde:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaDesde.Location = new System.Drawing.Point(112, 86);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(122, 23);
            this.dtpFechaDesde.TabIndex = 4;
            this.dtpFechaDesde.CloseUp += new System.EventHandler(this.dtpFechaDesde_CloseUp);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHasta.Location = new System.Drawing.Point(338, 86);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(122, 23);
            this.dtpFechaHasta.TabIndex = 5;
            this.dtpFechaHasta.CloseUp += new System.EventHandler(this.dtpFechaHasta_CloseUp);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(240, 90);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(92, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Fecha hasta:";
            // 
            // ReporteGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 500);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnReporteGastos);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.listGastos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ReporteGastos";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gastos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listGastos;
        private System.Windows.Forms.ColumnHeader columnFechaRealizado;
        private System.Windows.Forms.ColumnHeader columnTipoGasto;
        private System.Windows.Forms.ColumnHeader columnDescripcion;
        private System.Windows.Forms.ColumnHeader columnImporte;
        private MaterialSkin.Controls.MaterialButton btnCerrar;
        private MaterialSkin.Controls.MaterialButton btnReporteGastos;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}