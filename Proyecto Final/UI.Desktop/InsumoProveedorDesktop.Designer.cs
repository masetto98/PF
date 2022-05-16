﻿
namespace UI.Desktop
{
    partial class InsumoProveedorDesktop
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
            this.cbProveedores = new MaterialSkin.Controls.MaterialComboBox();
            this.cbInsumos = new MaterialSkin.Controls.MaterialComboBox();
            this.txtCantidad = new MaterialSkin.Controls.MaterialTextBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblProveedor = new MaterialSkin.Controls.MaterialLabel();
            this.lblInsumo = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechaIngreso = new MaterialSkin.Controls.MaterialLabel();
            this.lblCantidad = new MaterialSkin.Controls.MaterialLabel();
            this.btnAceptarIngreso = new MaterialSkin.Controls.MaterialButton();
            this.btnCancelarIngreso = new MaterialSkin.Controls.MaterialButton();
            this.btnNewProvIngreso = new MaterialSkin.Controls.MaterialButton();
            this.btnNewInsumoIngreso = new MaterialSkin.Controls.MaterialButton();
            this.txtUnidadMedidaIngreso = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // cbProveedores
            // 
            this.cbProveedores.AutoResize = false;
            this.cbProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cbProveedores.Depth = 0;
            this.cbProveedores.DisplayMember = "RazonSocial";
            this.cbProveedores.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbProveedores.DropDownHeight = 174;
            this.cbProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProveedores.DropDownWidth = 121;
            this.cbProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbProveedores.FormattingEnabled = true;
            this.cbProveedores.IntegralHeight = false;
            this.cbProveedores.ItemHeight = 43;
            this.cbProveedores.Location = new System.Drawing.Point(163, 81);
            this.cbProveedores.MaxDropDownItems = 4;
            this.cbProveedores.MouseState = MaterialSkin.MouseState.OUT;
            this.cbProveedores.Name = "cbProveedores";
            this.cbProveedores.Size = new System.Drawing.Size(252, 49);
            this.cbProveedores.StartIndex = 0;
            this.cbProveedores.TabIndex = 0;
            this.cbProveedores.ValueMember = "IdProveedor";
            // 
            // cbInsumos
            // 
            this.cbInsumos.AutoResize = false;
            this.cbInsumos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cbInsumos.Depth = 0;
            this.cbInsumos.DisplayMember = "Descripcion";
            this.cbInsumos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbInsumos.DropDownHeight = 174;
            this.cbInsumos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInsumos.DropDownWidth = 121;
            this.cbInsumos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbInsumos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbInsumos.FormattingEnabled = true;
            this.cbInsumos.IntegralHeight = false;
            this.cbInsumos.ItemHeight = 43;
            this.cbInsumos.Location = new System.Drawing.Point(163, 163);
            this.cbInsumos.MaxDropDownItems = 4;
            this.cbInsumos.MouseState = MaterialSkin.MouseState.OUT;
            this.cbInsumos.Name = "cbInsumos";
            this.cbInsumos.Size = new System.Drawing.Size(252, 49);
            this.cbInsumos.StartIndex = 0;
            this.cbInsumos.TabIndex = 1;
            this.cbInsumos.ValueMember = "IdInsumo";
            this.cbInsumos.SelectionChangeCommitted += new System.EventHandler(this.cbInsumos_SelectionChangeCommitted);
            // 
            // txtCantidad
            // 
            this.txtCantidad.AnimateReadOnly = false;
            this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Depth = 0;
            this.txtCantidad.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCantidad.LeadingIcon = null;
            this.txtCantidad.Location = new System.Drawing.Point(163, 317);
            this.txtCantidad.MaxLength = 50;
            this.txtCantidad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCantidad.Multiline = false;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(86, 50);
            this.txtCantidad.TabIndex = 2;
            this.txtCantidad.Text = "";
            this.txtCantidad.TrailingIcon = null;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dtpFechaIngreso.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpFechaIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(163, 254);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(200, 24);
            this.dtpFechaIngreso.TabIndex = 3;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblProveedor.Depth = 0;
            this.lblProveedor.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblProveedor.Location = new System.Drawing.Point(38, 96);
            this.lblProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(72, 19);
            this.lblProveedor.TabIndex = 4;
            this.lblProveedor.Text = "Proveedor";
            // 
            // lblInsumo
            // 
            this.lblInsumo.AutoSize = true;
            this.lblInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblInsumo.Depth = 0;
            this.lblInsumo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblInsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblInsumo.Location = new System.Drawing.Point(38, 177);
            this.lblInsumo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblInsumo.Name = "lblInsumo";
            this.lblInsumo.Size = new System.Drawing.Size(54, 19);
            this.lblInsumo.TabIndex = 5;
            this.lblInsumo.Text = "Insumo";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblFechaIngreso.Depth = 0;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFechaIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblFechaIngreso.Location = new System.Drawing.Point(38, 259);
            this.lblFechaIngreso.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(100, 19);
            this.lblFechaIngreso.TabIndex = 6;
            this.lblFechaIngreso.Text = "Fecha Ingreso";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblCantidad.Depth = 0;
            this.lblCantidad.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblCantidad.Location = new System.Drawing.Point(38, 330);
            this.lblCantidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(65, 19);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad";
            // 
            // btnAceptarIngreso
            // 
            this.btnAceptarIngreso.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptarIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAceptarIngreso.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAceptarIngreso.Depth = 0;
            this.btnAceptarIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAceptarIngreso.HighEmphasis = true;
            this.btnAceptarIngreso.Icon = null;
            this.btnAceptarIngreso.Location = new System.Drawing.Point(163, 396);
            this.btnAceptarIngreso.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAceptarIngreso.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptarIngreso.Name = "btnAceptarIngreso";
            this.btnAceptarIngreso.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAceptarIngreso.Size = new System.Drawing.Size(86, 36);
            this.btnAceptarIngreso.TabIndex = 8;
            this.btnAceptarIngreso.Text = "Aceptar";
            this.btnAceptarIngreso.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAceptarIngreso.UseAccentColor = false;
            this.btnAceptarIngreso.UseVisualStyleBackColor = false;
            this.btnAceptarIngreso.Click += new System.EventHandler(this.btnAceptarIngreso_Click);
            // 
            // btnCancelarIngreso
            // 
            this.btnCancelarIngreso.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelarIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCancelarIngreso.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelarIngreso.Depth = 0;
            this.btnCancelarIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancelarIngreso.HighEmphasis = true;
            this.btnCancelarIngreso.Icon = null;
            this.btnCancelarIngreso.Location = new System.Drawing.Point(319, 396);
            this.btnCancelarIngreso.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelarIngreso.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelarIngreso.Name = "btnCancelarIngreso";
            this.btnCancelarIngreso.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelarIngreso.Size = new System.Drawing.Size(96, 36);
            this.btnCancelarIngreso.TabIndex = 9;
            this.btnCancelarIngreso.Text = "Cancelar";
            this.btnCancelarIngreso.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelarIngreso.UseAccentColor = false;
            this.btnCancelarIngreso.UseVisualStyleBackColor = false;
            this.btnCancelarIngreso.Click += new System.EventHandler(this.btnCancelarIngreso_Click);
            // 
            // btnNewProvIngreso
            // 
            this.btnNewProvIngreso.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNewProvIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnNewProvIngreso.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNewProvIngreso.Depth = 0;
            this.btnNewProvIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNewProvIngreso.HighEmphasis = true;
            this.btnNewProvIngreso.Icon = global::UI.Desktop.Properties.Resources.plus_icon_icons_com_70890;
            this.btnNewProvIngreso.Location = new System.Drawing.Point(432, 86);
            this.btnNewProvIngreso.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNewProvIngreso.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNewProvIngreso.Name = "btnNewProvIngreso";
            this.btnNewProvIngreso.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNewProvIngreso.Size = new System.Drawing.Size(81, 36);
            this.btnNewProvIngreso.TabIndex = 10;
            this.btnNewProvIngreso.Text = "new";
            this.btnNewProvIngreso.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNewProvIngreso.UseAccentColor = false;
            this.btnNewProvIngreso.UseVisualStyleBackColor = false;
            this.btnNewProvIngreso.Click += new System.EventHandler(this.btnNewProvIngreso_Click);
            // 
            // btnNewInsumoIngreso
            // 
            this.btnNewInsumoIngreso.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNewInsumoIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnNewInsumoIngreso.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNewInsumoIngreso.Depth = 0;
            this.btnNewInsumoIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNewInsumoIngreso.HighEmphasis = true;
            this.btnNewInsumoIngreso.Icon = global::UI.Desktop.Properties.Resources.plus_icon_icons_com_70890;
            this.btnNewInsumoIngreso.Location = new System.Drawing.Point(432, 167);
            this.btnNewInsumoIngreso.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNewInsumoIngreso.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNewInsumoIngreso.Name = "btnNewInsumoIngreso";
            this.btnNewInsumoIngreso.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNewInsumoIngreso.Size = new System.Drawing.Size(81, 36);
            this.btnNewInsumoIngreso.TabIndex = 11;
            this.btnNewInsumoIngreso.Text = "new";
            this.btnNewInsumoIngreso.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNewInsumoIngreso.UseAccentColor = false;
            this.btnNewInsumoIngreso.UseVisualStyleBackColor = false;
            this.btnNewInsumoIngreso.Click += new System.EventHandler(this.btnNewInsumoIngreso_Click);
            // 
            // txtUnidadMedidaIngreso
            // 
            this.txtUnidadMedidaIngreso.AnimateReadOnly = false;
            this.txtUnidadMedidaIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtUnidadMedidaIngreso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUnidadMedidaIngreso.Depth = 0;
            this.txtUnidadMedidaIngreso.Enabled = false;
            this.txtUnidadMedidaIngreso.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUnidadMedidaIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtUnidadMedidaIngreso.LeadingIcon = null;
            this.txtUnidadMedidaIngreso.Location = new System.Drawing.Point(281, 316);
            this.txtUnidadMedidaIngreso.MaxLength = 50;
            this.txtUnidadMedidaIngreso.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUnidadMedidaIngreso.Multiline = false;
            this.txtUnidadMedidaIngreso.Name = "txtUnidadMedidaIngreso";
            this.txtUnidadMedidaIngreso.Size = new System.Drawing.Size(134, 50);
            this.txtUnidadMedidaIngreso.TabIndex = 12;
            this.txtUnidadMedidaIngreso.Text = "";
            this.txtUnidadMedidaIngreso.TrailingIcon = null;
            // 
            // InsumoProveedorDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 460);
            this.Controls.Add(this.txtUnidadMedidaIngreso);
            this.Controls.Add(this.btnNewInsumoIngreso);
            this.Controls.Add(this.btnNewProvIngreso);
            this.Controls.Add(this.btnCancelarIngreso);
            this.Controls.Add(this.btnAceptarIngreso);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.lblInsumo);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cbInsumos);
            this.Controls.Add(this.cbProveedores);
            this.Name = "InsumoProveedorDesktop";
            this.Sizable = false;
            this.Text = "Nuevo Ingreso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox cbProveedores;
        private MaterialSkin.Controls.MaterialComboBox cbInsumos;
        private MaterialSkin.Controls.MaterialTextBox txtCantidad;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private MaterialSkin.Controls.MaterialLabel lblProveedor;
        private MaterialSkin.Controls.MaterialLabel lblInsumo;
        private MaterialSkin.Controls.MaterialLabel lblFechaIngreso;
        private MaterialSkin.Controls.MaterialLabel lblCantidad;
        private MaterialSkin.Controls.MaterialButton btnAceptarIngreso;
        private MaterialSkin.Controls.MaterialButton btnCancelarIngreso;
        private MaterialSkin.Controls.MaterialButton btnNewProvIngreso;
        private MaterialSkin.Controls.MaterialButton btnNewInsumoIngreso;
        private MaterialSkin.Controls.MaterialTextBox txtUnidadMedidaIngreso;
    }
}