
namespace UI.Desktop
{
    partial class Usuarios
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
            this.listUsuarios = new MaterialSkin.Controls.MaterialListView();
            this.columnID = new System.Windows.Forms.ColumnHeader();
            this.columnNombreUsuario = new System.Windows.Forms.ColumnHeader();
            this.columnCuitEmpleado = new System.Windows.Forms.ColumnHeader();
            this.columnNombre = new System.Windows.Forms.ColumnHeader();
            this.columnApellido = new System.Windows.Forms.ColumnHeader();
            this.columnTipoEmpleado = new System.Windows.Forms.ColumnHeader();
            this.btnEditarCliente = new MaterialSkin.Controls.MaterialButton();
            this.btnEliminarCliente = new MaterialSkin.Controls.MaterialButton();
            this.btnAgregarCliente = new MaterialSkin.Controls.MaterialButton();
            this.btnCerrar = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // listUsuarios
            // 
            this.listUsuarios.AutoSizeTable = false;
            this.listUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listUsuarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnNombreUsuario,
            this.columnCuitEmpleado,
            this.columnNombre,
            this.columnApellido,
            this.columnTipoEmpleado});
            this.listUsuarios.Depth = 0;
            this.listUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listUsuarios.FullRowSelect = true;
            this.listUsuarios.HideSelection = false;
            this.listUsuarios.Location = new System.Drawing.Point(12, 143);
            this.listUsuarios.MinimumSize = new System.Drawing.Size(200, 100);
            this.listUsuarios.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listUsuarios.MouseState = MaterialSkin.MouseState.OUT;
            this.listUsuarios.Name = "listUsuarios";
            this.listUsuarios.OwnerDraw = true;
            this.listUsuarios.Size = new System.Drawing.Size(660, 390);
            this.listUsuarios.TabIndex = 0;
            this.listUsuarios.UseCompatibleStateImageBehavior = false;
            this.listUsuarios.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            // 
            // columnNombreUsuario
            // 
            this.columnNombreUsuario.Text = "Usuario";
            this.columnNombreUsuario.Width = 100;
            // 
            // columnCuitEmpleado
            // 
            this.columnCuitEmpleado.Text = "Cuit Empleado";
            this.columnCuitEmpleado.Width = 150;
            // 
            // columnNombre
            // 
            this.columnNombre.Text = "Nombre";
            this.columnNombre.Width = 100;
            // 
            // columnApellido
            // 
            this.columnApellido.Text = "Apellido";
            this.columnApellido.Width = 100;
            // 
            // columnTipoEmpleado
            // 
            this.columnTipoEmpleado.Text = "Tipo Empleado";
            this.columnTipoEmpleado.Width = 150;
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.AutoSize = false;
            this.btnEditarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEditarCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditarCliente.Depth = 0;
            this.btnEditarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditarCliente.HighEmphasis = true;
            this.btnEditarCliente.Icon = global::UI.Desktop.Properties.Resources._353430_checkbox_edit_pen_pencil_107516;
            this.btnEditarCliente.Location = new System.Drawing.Point(136, 98);
            this.btnEditarCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditarCliente.Size = new System.Drawing.Size(116, 36);
            this.btnEditarCliente.TabIndex = 6;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditarCliente.UseAccentColor = false;
            this.btnEditarCliente.UseVisualStyleBackColor = false;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEliminarCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarCliente.Depth = 0;
            this.btnEliminarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarCliente.HighEmphasis = true;
            this.btnEliminarCliente.Icon = global::UI.Desktop.Properties.Resources.trash_bin_icon_icons_com_67981;
            this.btnEliminarCliente.Location = new System.Drawing.Point(260, 98);
            this.btnEliminarCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminarCliente.Size = new System.Drawing.Size(116, 36);
            this.btnEliminarCliente.TabIndex = 5;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminarCliente.UseAccentColor = false;
            this.btnEliminarCliente.UseVisualStyleBackColor = false;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAgregarCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarCliente.Depth = 0;
            this.btnAgregarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAgregarCliente.HighEmphasis = true;
            this.btnAgregarCliente.Icon = global::UI.Desktop.Properties.Resources.adduser_añadir_3553;
            this.btnAgregarCliente.Location = new System.Drawing.Point(12, 98);
            this.btnAgregarCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarCliente.Size = new System.Drawing.Size(116, 36);
            this.btnAgregarCliente.TabIndex = 4;
            this.btnAgregarCliente.Text = "Agregar";
            this.btnAgregarCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarCliente.UseAccentColor = false;
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
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
            this.btnCerrar.Location = new System.Drawing.Point(598, 542);
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
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 590);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.listUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Usuarios";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listUsuarios;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnNombreUsuario;
        private System.Windows.Forms.ColumnHeader columnCuitEmpleado;
        private System.Windows.Forms.ColumnHeader columnNombre;
        private System.Windows.Forms.ColumnHeader columnApellido;
        private System.Windows.Forms.ColumnHeader columnTipoEmpleado;
        private MaterialSkin.Controls.MaterialButton btnEditarCliente;
        private MaterialSkin.Controls.MaterialButton btnEliminarCliente;
        private MaterialSkin.Controls.MaterialButton btnAgregarCliente;
        private MaterialSkin.Controls.MaterialButton btnCerrar;
    }
}