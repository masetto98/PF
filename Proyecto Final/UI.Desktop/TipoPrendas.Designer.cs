
namespace UI.Desktop
{
    partial class TipoPrendas
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
            this.listTipoPrendas = new MaterialSkin.Controls.MaterialListView();
            this.columnID = new System.Windows.Forms.ColumnHeader();
            this.columnDescripcion = new System.Windows.Forms.ColumnHeader();
            this.btnCerrar = new MaterialSkin.Controls.MaterialButton();
            this.btnAgregar = new MaterialSkin.Controls.MaterialButton();
            this.btnEditar = new MaterialSkin.Controls.MaterialButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // listTipoPrendas
            // 
            this.listTipoPrendas.AutoSizeTable = false;
            this.listTipoPrendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listTipoPrendas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listTipoPrendas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnDescripcion});
            this.listTipoPrendas.Depth = 0;
            this.listTipoPrendas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listTipoPrendas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listTipoPrendas.FullRowSelect = true;
            this.listTipoPrendas.HideSelection = false;
            this.listTipoPrendas.Location = new System.Drawing.Point(12, 144);
            this.listTipoPrendas.MinimumSize = new System.Drawing.Size(200, 100);
            this.listTipoPrendas.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listTipoPrendas.MouseState = MaterialSkin.MouseState.OUT;
            this.listTipoPrendas.MultiSelect = false;
            this.listTipoPrendas.Name = "listTipoPrendas";
            this.listTipoPrendas.OwnerDraw = true;
            this.listTipoPrendas.Size = new System.Drawing.Size(358, 341);
            this.listTipoPrendas.TabIndex = 0;
            this.listTipoPrendas.UseCompatibleStateImageBehavior = false;
            this.listTipoPrendas.View = System.Windows.Forms.View.Details;
            this.listTipoPrendas.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listTipoPrendas_ColumnWidthChanging);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 75;
            // 
            // columnDescripcion
            // 
            this.columnDescripcion.Text = "Descripción";
            this.columnDescripcion.Width = 283;
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
            this.btnCerrar.Location = new System.Drawing.Point(293, 494);
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
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = false;
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAgregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAgregar.HighEmphasis = true;
            this.btnAgregar.Icon = global::UI.Desktop.Properties.Resources.plus_icon_icons_com_70890;
            this.btnAgregar.Location = new System.Drawing.Point(13, 84);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregar.Size = new System.Drawing.Size(114, 51);
            this.btnAgregar.TabIndex = 2;
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
            this.btnEditar.Icon = global::UI.Desktop.Properties.Resources._353430_checkbox_edit_pen_pencil_107516;
            this.btnEditar.Location = new System.Drawing.Point(135, 84);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditar.Size = new System.Drawing.Size(114, 51);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditar.UseAccentColor = false;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = false;
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.HighEmphasis = true;
            this.btnEliminar.Icon = global::UI.Desktop.Properties.Resources.trash_bin_icon_icons_com_67981;
            this.btnEliminar.Location = new System.Drawing.Point(256, 84);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminar.Size = new System.Drawing.Size(114, 51);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminar.UseAccentColor = false;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // TipoPrendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 540);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.listTipoPrendas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "TipoPrendas";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de prendas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listTipoPrendas;
        private MaterialSkin.Controls.MaterialButton btnCerrar;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnDescripcion;
        private MaterialSkin.Controls.MaterialButton btnAgregar;
        private MaterialSkin.Controls.MaterialButton btnEditar;
        private MaterialSkin.Controls.MaterialButton btnEliminar;
    }
}