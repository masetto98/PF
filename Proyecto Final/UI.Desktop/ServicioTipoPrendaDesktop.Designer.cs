
namespace UI.Desktop
{
    partial class ServicioTipoPrendaDesktop
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
            this.lblServicio = new MaterialSkin.Controls.MaterialLabel();
            this.lblTipoPrenda = new MaterialSkin.Controls.MaterialLabel();
            this.cmbServicios = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbTipoPrendas = new MaterialSkin.Controls.MaterialComboBox();
            this.btnAceptar = new MaterialSkin.Controls.MaterialButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.lblTiempoRequerido = new MaterialSkin.Controls.MaterialLabel();
            this.txtHoras = new MaterialSkin.Controls.MaterialTextBox();
            this.lblHoras = new MaterialSkin.Controls.MaterialLabel();
            this.txtMinutos = new MaterialSkin.Controls.MaterialTextBox();
            this.lblMinutos = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblServicio.Depth = 0;
            this.lblServicio.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblServicio.Location = new System.Drawing.Point(24, 116);
            this.lblServicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(57, 19);
            this.lblServicio.TabIndex = 0;
            this.lblServicio.Text = "Servicio";
            // 
            // lblTipoPrenda
            // 
            this.lblTipoPrenda.AutoSize = true;
            this.lblTipoPrenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblTipoPrenda.Depth = 0;
            this.lblTipoPrenda.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTipoPrenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTipoPrenda.Location = new System.Drawing.Point(24, 184);
            this.lblTipoPrenda.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTipoPrenda.Name = "lblTipoPrenda";
            this.lblTipoPrenda.Size = new System.Drawing.Size(87, 19);
            this.lblTipoPrenda.TabIndex = 1;
            this.lblTipoPrenda.Text = "Tipo Prenda";
            // 
            // cmbServicios
            // 
            this.cmbServicios.AutoResize = false;
            this.cmbServicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cmbServicios.Depth = 0;
            this.cmbServicios.DisplayMember = "Descripcion";
            this.cmbServicios.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbServicios.DropDownHeight = 174;
            this.cmbServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServicios.DropDownWidth = 121;
            this.cmbServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbServicios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbServicios.FormattingEnabled = true;
            this.cmbServicios.IntegralHeight = false;
            this.cmbServicios.ItemHeight = 43;
            this.cmbServicios.Location = new System.Drawing.Point(166, 86);
            this.cmbServicios.MaxDropDownItems = 4;
            this.cmbServicios.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbServicios.Name = "cmbServicios";
            this.cmbServicios.Size = new System.Drawing.Size(239, 49);
            this.cmbServicios.StartIndex = 0;
            this.cmbServicios.TabIndex = 2;
            this.cmbServicios.ValueMember = "IdServicio";
            // 
            // cmbTipoPrendas
            // 
            this.cmbTipoPrendas.AutoResize = false;
            this.cmbTipoPrendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cmbTipoPrendas.Depth = 0;
            this.cmbTipoPrendas.DisplayMember = "Descripcion";
            this.cmbTipoPrendas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbTipoPrendas.DropDownHeight = 174;
            this.cmbTipoPrendas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPrendas.DropDownWidth = 121;
            this.cmbTipoPrendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbTipoPrendas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbTipoPrendas.FormattingEnabled = true;
            this.cmbTipoPrendas.IntegralHeight = false;
            this.cmbTipoPrendas.ItemHeight = 43;
            this.cmbTipoPrendas.Location = new System.Drawing.Point(166, 154);
            this.cmbTipoPrendas.MaxDropDownItems = 4;
            this.cmbTipoPrendas.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTipoPrendas.Name = "cmbTipoPrendas";
            this.cmbTipoPrendas.Size = new System.Drawing.Size(239, 49);
            this.cmbTipoPrendas.StartIndex = 0;
            this.cmbTipoPrendas.TabIndex = 3;
            this.cmbTipoPrendas.ValueMember = "IdTipoPrenda";
            // 
            // btnAceptar
            // 
            this.btnAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAceptar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAceptar.Depth = 0;
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAceptar.HighEmphasis = true;
            this.btnAceptar.Icon = null;
            this.btnAceptar.Location = new System.Drawing.Point(215, 352);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAceptar.Size = new System.Drawing.Size(86, 36);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAceptar.UseAccentColor = false;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(309, 352);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(96, 36);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTiempoRequerido
            // 
            this.lblTiempoRequerido.AutoSize = true;
            this.lblTiempoRequerido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblTiempoRequerido.Depth = 0;
            this.lblTiempoRequerido.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTiempoRequerido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTiempoRequerido.Location = new System.Drawing.Point(24, 238);
            this.lblTiempoRequerido.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTiempoRequerido.Name = "lblTiempoRequerido";
            this.lblTiempoRequerido.Size = new System.Drawing.Size(133, 19);
            this.lblTiempoRequerido.TabIndex = 6;
            this.lblTiempoRequerido.Text = "Tiempo requerido: ";
            // 
            // txtHoras
            // 
            this.txtHoras.AnimateReadOnly = false;
            this.txtHoras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtHoras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoras.Depth = 0;
            this.txtHoras.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtHoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtHoras.LeadingIcon = null;
            this.txtHoras.Location = new System.Drawing.Point(219, 263);
            this.txtHoras.MaxLength = 50;
            this.txtHoras.MouseState = MaterialSkin.MouseState.OUT;
            this.txtHoras.Multiline = false;
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(50, 50);
            this.txtHoras.TabIndex = 7;
            this.txtHoras.Text = "";
            this.txtHoras.TrailingIcon = null;
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblHoras.Depth = 0;
            this.lblHoras.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblHoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblHoras.Location = new System.Drawing.Point(166, 294);
            this.lblHoras.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(47, 19);
            this.lblHoras.TabIndex = 8;
            this.lblHoras.Text = "Horas:";
            // 
            // txtMinutos
            // 
            this.txtMinutos.AnimateReadOnly = false;
            this.txtMinutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtMinutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMinutos.Depth = 0;
            this.txtMinutos.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMinutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtMinutos.LeadingIcon = null;
            this.txtMinutos.Location = new System.Drawing.Point(355, 263);
            this.txtMinutos.MaxLength = 50;
            this.txtMinutos.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMinutos.Multiline = false;
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(50, 50);
            this.txtMinutos.TabIndex = 10;
            this.txtMinutos.Text = "";
            this.txtMinutos.TrailingIcon = null;
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblMinutos.Depth = 0;
            this.lblMinutos.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMinutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblMinutos.Location = new System.Drawing.Point(286, 294);
            this.lblMinutos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(63, 19);
            this.lblMinutos.TabIndex = 12;
            this.lblMinutos.Text = "Minutos:";
            // 
            // ServicioTipoPrendaDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 410);
            this.Controls.Add(this.lblMinutos);
            this.Controls.Add(this.txtMinutos);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.lblTiempoRequerido);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbTipoPrendas);
            this.Controls.Add(this.cmbServicios);
            this.Controls.Add(this.lblTipoPrenda);
            this.Controls.Add(this.lblServicio);
            this.Name = "ServicioTipoPrendaDesktop";
            this.Text = "Nuevo Servicio-TipoPrenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblServicio;
        private MaterialSkin.Controls.MaterialLabel lblTipoPrenda;
        private MaterialSkin.Controls.MaterialComboBox cmbServicios;
        private MaterialSkin.Controls.MaterialComboBox cmbTipoPrendas;
        private MaterialSkin.Controls.MaterialButton btnAceptar;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialLabel lblTiempoRequerido;
        private MaterialSkin.Controls.MaterialTextBox txtHoras;
        private MaterialSkin.Controls.MaterialLabel lblHoras;
        private MaterialSkin.Controls.MaterialTextBox txtMinutos;
        private MaterialSkin.Controls.MaterialLabel lblMinutos;
    }
}