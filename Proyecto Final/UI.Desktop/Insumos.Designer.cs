
namespace UI.Desktop
{
    partial class Insumos
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
            this.columnIDInsumo = new System.Windows.Forms.ColumnHeader();
            this.columnDesc = new System.Windows.Forms.ColumnHeader();
            this.btnDetalles = new MaterialSkin.Controls.MaterialButton();
            this.listConsumos = new MaterialSkin.Controls.MaterialListView();
            this.columnServicio = new System.Windows.Forms.ColumnHeader();
            this.columntp = new System.Windows.Forms.ColumnHeader();
            this.columnFecha = new System.Windows.Forms.ColumnHeader();
            this.columnCant = new System.Windows.Forms.ColumnHeader();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCerrar = new MaterialSkin.Controls.MaterialButton();
            this.btnAgregar = new MaterialSkin.Controls.MaterialButton();
            this.btnEditar = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // listInsumos
            // 
            this.listInsumos.AutoSizeTable = false;
            this.listInsumos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listInsumos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listInsumos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIDInsumo,
            this.columnDesc});
            this.listInsumos.Depth = 0;
            this.listInsumos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listInsumos.FullRowSelect = true;
            this.listInsumos.HideSelection = false;
            this.listInsumos.Location = new System.Drawing.Point(12, 93);
            this.listInsumos.MinimumSize = new System.Drawing.Size(200, 100);
            this.listInsumos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listInsumos.MouseState = MaterialSkin.MouseState.OUT;
            this.listInsumos.Name = "listInsumos";
            this.listInsumos.OwnerDraw = true;
            this.listInsumos.Size = new System.Drawing.Size(350, 348);
            this.listInsumos.TabIndex = 0;
            this.listInsumos.UseCompatibleStateImageBehavior = false;
            this.listInsumos.View = System.Windows.Forms.View.Details;
            this.listInsumos.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listInsumos_ColumnWidthChanging);
            // 
            // columnIDInsumo
            // 
            this.columnIDInsumo.Text = "ID";
            this.columnIDInsumo.Width = 100;
            // 
            // columnDesc
            // 
            this.columnDesc.Text = "Descripción";
            this.columnDesc.Width = 250;
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
            this.btnDetalles.Location = new System.Drawing.Point(369, 93);
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
            // listConsumos
            // 
            this.listConsumos.AutoSizeTable = false;
            this.listConsumos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listConsumos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listConsumos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnServicio,
            this.columntp,
            this.columnFecha,
            this.columnCant});
            this.listConsumos.Depth = 0;
            this.listConsumos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listConsumos.FullRowSelect = true;
            this.listConsumos.HideSelection = false;
            this.listConsumos.Location = new System.Drawing.Point(482, 185);
            this.listConsumos.MinimumSize = new System.Drawing.Size(200, 100);
            this.listConsumos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listConsumos.MouseState = MaterialSkin.MouseState.OUT;
            this.listConsumos.Name = "listConsumos";
            this.listConsumos.OwnerDraw = true;
            this.listConsumos.Size = new System.Drawing.Size(600, 256);
            this.listConsumos.TabIndex = 2;
            this.listConsumos.UseCompatibleStateImageBehavior = false;
            this.listConsumos.View = System.Windows.Forms.View.Details;
            // 
            // columnServicio
            // 
            this.columnServicio.Text = "Servicio";
            this.columnServicio.Width = 150;
            // 
            // columntp
            // 
            this.columntp.Text = "Tipo Prenda";
            this.columntp.Width = 150;
            // 
            // columnFecha
            // 
            this.columnFecha.Text = "Fecha desde";
            this.columnFecha.Width = 150;
            // 
            // columnCant
            // 
            this.columnCant.Text = "Cantidad";
            this.columnCant.Width = 150;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(482, 160);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(81, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Consumos:";
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
            this.btnCerrar.Location = new System.Drawing.Point(1126, 452);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCerrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCerrar.Size = new System.Drawing.Size(77, 36);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCerrar.UseAccentColor = false;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
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
            this.btnAgregar.Icon = null;
            this.btnAgregar.Location = new System.Drawing.Point(1089, 185);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregar.Size = new System.Drawing.Size(114, 51);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregar.UseAccentColor = false;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.AutoSize = false;
            this.btnEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditar.Depth = 0;
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditar.HighEmphasis = true;
            this.btnEditar.Icon = null;
            this.btnEditar.Location = new System.Drawing.Point(1089, 245);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditar.Size = new System.Drawing.Size(114, 51);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditar.UseAccentColor = false;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // Insumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 493);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.listConsumos);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.listInsumos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Insumos";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insumos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listInsumos;
        private System.Windows.Forms.ColumnHeader columnIDInsumo;
        private System.Windows.Forms.ColumnHeader columnDesc;
        private MaterialSkin.Controls.MaterialButton btnDetalles;
        private MaterialSkin.Controls.MaterialListView listConsumos;
        private System.Windows.Forms.ColumnHeader columnServicio;
        private System.Windows.Forms.ColumnHeader columntp;
        private System.Windows.Forms.ColumnHeader columnFecha;
        private System.Windows.Forms.ColumnHeader columnCant;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnCerrar;
        private MaterialSkin.Controls.MaterialButton btnAgregar;
        private MaterialSkin.Controls.MaterialButton btnEditar;
    }
}