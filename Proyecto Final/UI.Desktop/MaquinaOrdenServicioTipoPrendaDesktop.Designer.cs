
namespace UI.Desktop
{
    partial class MaquinaOrdenServicioTipoPrendaDesktop
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
            this.btnIniciar = new MaterialSkin.Controls.MaterialButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.txtNroOrden = new MaterialSkin.Controls.MaterialTextBox();
            this.txtServicio = new MaterialSkin.Controls.MaterialTextBox();
            this.txtOrdenItem = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTipoPrenda = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbMaquinas = new MaterialSkin.Controls.MaterialComboBox();
            this.listEstadoMaquinas = new MaterialSkin.Controls.MaterialListView();
            this.columnMaquina = new System.Windows.Forms.ColumnHeader();
            this.columnEstado = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.AutoSize = false;
            this.btnIniciar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnIniciar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnIniciar.Depth = 0;
            this.btnIniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIniciar.HighEmphasis = true;
            this.btnIniciar.Icon = null;
            this.btnIniciar.Location = new System.Drawing.Point(121, 319);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIniciar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnIniciar.Size = new System.Drawing.Size(96, 36);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnIniciar.UseAccentColor = false;
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(225, 319);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(96, 36);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtNroOrden
            // 
            this.txtNroOrden.AnimateReadOnly = false;
            this.txtNroOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtNroOrden.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNroOrden.Depth = 0;
            this.txtNroOrden.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNroOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNroOrden.Hint = "Nro Orden";
            this.txtNroOrden.LeadingIcon = null;
            this.txtNroOrden.Location = new System.Drawing.Point(15, 93);
            this.txtNroOrden.MaxLength = 50;
            this.txtNroOrden.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNroOrden.Multiline = false;
            this.txtNroOrden.Name = "txtNroOrden";
            this.txtNroOrden.Size = new System.Drawing.Size(148, 50);
            this.txtNroOrden.TabIndex = 2;
            this.txtNroOrden.Text = "";
            this.txtNroOrden.TrailingIcon = null;
            // 
            // txtServicio
            // 
            this.txtServicio.AnimateReadOnly = false;
            this.txtServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtServicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServicio.Depth = 0;
            this.txtServicio.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtServicio.Hint = "Servicio";
            this.txtServicio.LeadingIcon = null;
            this.txtServicio.Location = new System.Drawing.Point(15, 149);
            this.txtServicio.MaxLength = 50;
            this.txtServicio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtServicio.Multiline = false;
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(306, 50);
            this.txtServicio.TabIndex = 3;
            this.txtServicio.Text = "";
            this.txtServicio.TrailingIcon = null;
            // 
            // txtOrdenItem
            // 
            this.txtOrdenItem.AnimateReadOnly = false;
            this.txtOrdenItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtOrdenItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOrdenItem.Depth = 0;
            this.txtOrdenItem.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtOrdenItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtOrdenItem.Hint = "Orden Item";
            this.txtOrdenItem.LeadingIcon = null;
            this.txtOrdenItem.Location = new System.Drawing.Point(169, 93);
            this.txtOrdenItem.MaxLength = 50;
            this.txtOrdenItem.MouseState = MaterialSkin.MouseState.OUT;
            this.txtOrdenItem.Multiline = false;
            this.txtOrdenItem.Name = "txtOrdenItem";
            this.txtOrdenItem.Size = new System.Drawing.Size(152, 50);
            this.txtOrdenItem.TabIndex = 4;
            this.txtOrdenItem.Text = "";
            this.txtOrdenItem.TrailingIcon = null;
            // 
            // txtTipoPrenda
            // 
            this.txtTipoPrenda.AnimateReadOnly = false;
            this.txtTipoPrenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtTipoPrenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipoPrenda.Depth = 0;
            this.txtTipoPrenda.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTipoPrenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTipoPrenda.Hint = "Tipo de Prenda";
            this.txtTipoPrenda.LeadingIcon = null;
            this.txtTipoPrenda.Location = new System.Drawing.Point(15, 205);
            this.txtTipoPrenda.MaxLength = 50;
            this.txtTipoPrenda.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTipoPrenda.Multiline = false;
            this.txtTipoPrenda.Name = "txtTipoPrenda";
            this.txtTipoPrenda.Size = new System.Drawing.Size(306, 50);
            this.txtTipoPrenda.TabIndex = 5;
            this.txtTipoPrenda.Text = "";
            this.txtTipoPrenda.TrailingIcon = null;
            // 
            // cmbMaquinas
            // 
            this.cmbMaquinas.AutoResize = false;
            this.cmbMaquinas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cmbMaquinas.Depth = 0;
            this.cmbMaquinas.DisplayMember = "Descripcion";
            this.cmbMaquinas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbMaquinas.DropDownHeight = 174;
            this.cmbMaquinas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaquinas.DropDownWidth = 121;
            this.cmbMaquinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbMaquinas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbMaquinas.FormattingEnabled = true;
            this.cmbMaquinas.Hint = "Máquinas";
            this.cmbMaquinas.IntegralHeight = false;
            this.cmbMaquinas.ItemHeight = 43;
            this.cmbMaquinas.Location = new System.Drawing.Point(15, 261);
            this.cmbMaquinas.MaxDropDownItems = 4;
            this.cmbMaquinas.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbMaquinas.Name = "cmbMaquinas";
            this.cmbMaquinas.Size = new System.Drawing.Size(306, 49);
            this.cmbMaquinas.StartIndex = 0;
            this.cmbMaquinas.TabIndex = 7;
            this.cmbMaquinas.ValueMember = "IdMaquina";
            // 
            // listEstadoMaquinas
            // 
            this.listEstadoMaquinas.AutoSizeTable = false;
            this.listEstadoMaquinas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listEstadoMaquinas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listEstadoMaquinas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMaquina,
            this.columnEstado});
            this.listEstadoMaquinas.Depth = 0;
            this.listEstadoMaquinas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listEstadoMaquinas.FullRowSelect = true;
            this.listEstadoMaquinas.HideSelection = false;
            this.listEstadoMaquinas.Location = new System.Drawing.Point(328, 93);
            this.listEstadoMaquinas.MinimumSize = new System.Drawing.Size(200, 100);
            this.listEstadoMaquinas.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listEstadoMaquinas.MouseState = MaterialSkin.MouseState.OUT;
            this.listEstadoMaquinas.MultiSelect = false;
            this.listEstadoMaquinas.Name = "listEstadoMaquinas";
            this.listEstadoMaquinas.OwnerDraw = true;
            this.listEstadoMaquinas.Size = new System.Drawing.Size(200, 217);
            this.listEstadoMaquinas.TabIndex = 8;
            this.listEstadoMaquinas.UseCompatibleStateImageBehavior = false;
            this.listEstadoMaquinas.View = System.Windows.Forms.View.Details;
            this.listEstadoMaquinas.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listEstadoMaquinas_ColumnWidthChanging);
            // 
            // columnMaquina
            // 
            this.columnMaquina.Text = "Maquina";
            this.columnMaquina.Width = 100;
            // 
            // columnEstado
            // 
            this.columnEstado.Text = "Estado";
            this.columnEstado.Width = 100;
            // 
            // MaquinaOrdenServicioTipoPrendaDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 365);
            this.Controls.Add(this.listEstadoMaquinas);
            this.Controls.Add(this.cmbMaquinas);
            this.Controls.Add(this.txtTipoPrenda);
            this.Controls.Add(this.txtOrdenItem);
            this.Controls.Add(this.txtServicio);
            this.Controls.Add(this.txtNroOrden);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIniciar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MaquinaOrdenServicioTipoPrendaDesktop";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Trabajo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnIniciar;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialTextBox txtNroOrden;
        private MaterialSkin.Controls.MaterialTextBox txtServicio;
        private MaterialSkin.Controls.MaterialTextBox txtOrdenItem;
        private MaterialSkin.Controls.MaterialTextBox txtTipoPrenda;
        private MaterialSkin.Controls.MaterialComboBox cmbMaquinas;
        private MaterialSkin.Controls.MaterialListView listEstadoMaquinas;
        private System.Windows.Forms.ColumnHeader columnMaquina;
        private System.Windows.Forms.ColumnHeader columnEstado;
    }
}