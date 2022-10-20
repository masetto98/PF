
namespace UI.Desktop
{
    partial class InsumoDesktop
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
            this.txtIDInsumo = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDescInsumo = new MaterialSkin.Controls.MaterialTextBox();
            this.txtExistenciaInsumo = new MaterialSkin.Controls.MaterialTextBox();
            this.btnAceptarInsumo = new MaterialSkin.Controls.MaterialButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.cmbUnidadMedida = new MaterialSkin.Controls.MaterialComboBox();
            this.SuspendLayout();
            // 
            // txtIDInsumo
            // 
            this.txtIDInsumo.AnimateReadOnly = false;
            this.txtIDInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtIDInsumo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDInsumo.Depth = 0;
            this.txtIDInsumo.Enabled = false;
            this.txtIDInsumo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIDInsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtIDInsumo.Hint = "ID";
            this.txtIDInsumo.LeadingIcon = null;
            this.txtIDInsumo.Location = new System.Drawing.Point(46, 90);
            this.txtIDInsumo.MaxLength = 50;
            this.txtIDInsumo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIDInsumo.Multiline = false;
            this.txtIDInsumo.Name = "txtIDInsumo";
            this.txtIDInsumo.Size = new System.Drawing.Size(119, 50);
            this.txtIDInsumo.TabIndex = 0;
            this.txtIDInsumo.Text = "";
            this.txtIDInsumo.TrailingIcon = null;
            // 
            // txtDescInsumo
            // 
            this.txtDescInsumo.AnimateReadOnly = false;
            this.txtDescInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtDescInsumo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescInsumo.Depth = 0;
            this.txtDescInsumo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescInsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDescInsumo.Hint = "Descripción";
            this.txtDescInsumo.LeadingIcon = null;
            this.txtDescInsumo.Location = new System.Drawing.Point(46, 146);
            this.txtDescInsumo.MaxLength = 50;
            this.txtDescInsumo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescInsumo.Multiline = false;
            this.txtDescInsumo.Name = "txtDescInsumo";
            this.txtDescInsumo.Size = new System.Drawing.Size(344, 50);
            this.txtDescInsumo.TabIndex = 3;
            this.txtDescInsumo.Text = "";
            this.txtDescInsumo.TrailingIcon = null;
            // 
            // txtExistenciaInsumo
            // 
            this.txtExistenciaInsumo.AnimateReadOnly = false;
            this.txtExistenciaInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtExistenciaInsumo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExistenciaInsumo.Depth = 0;
            this.txtExistenciaInsumo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtExistenciaInsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtExistenciaInsumo.Hint = "Existencia";
            this.txtExistenciaInsumo.LeadingIcon = null;
            this.txtExistenciaInsumo.Location = new System.Drawing.Point(46, 201);
            this.txtExistenciaInsumo.MaxLength = 50;
            this.txtExistenciaInsumo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtExistenciaInsumo.Multiline = false;
            this.txtExistenciaInsumo.Name = "txtExistenciaInsumo";
            this.txtExistenciaInsumo.Size = new System.Drawing.Size(119, 50);
            this.txtExistenciaInsumo.TabIndex = 5;
            this.txtExistenciaInsumo.Text = "";
            this.txtExistenciaInsumo.TrailingIcon = null;
            this.txtExistenciaInsumo.TextChanged += new System.EventHandler(this.txtExistenciaInsumo_TextChanged);
            // 
            // btnAceptarInsumo
            // 
            this.btnAceptarInsumo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptarInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAceptarInsumo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAceptarInsumo.Depth = 0;
            this.btnAceptarInsumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAceptarInsumo.HighEmphasis = true;
            this.btnAceptarInsumo.Icon = null;
            this.btnAceptarInsumo.Location = new System.Drawing.Point(200, 273);
            this.btnAceptarInsumo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAceptarInsumo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptarInsumo.Name = "btnAceptarInsumo";
            this.btnAceptarInsumo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAceptarInsumo.Size = new System.Drawing.Size(86, 36);
            this.btnAceptarInsumo.TabIndex = 6;
            this.btnAceptarInsumo.Text = "Aceptar";
            this.btnAceptarInsumo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAceptarInsumo.UseAccentColor = false;
            this.btnAceptarInsumo.UseVisualStyleBackColor = false;
            this.btnAceptarInsumo.Click += new System.EventHandler(this.btnAceptarInsumo_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(294, 273);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(96, 36);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbUnidadMedida
            // 
            this.cmbUnidadMedida.AutoResize = false;
            this.cmbUnidadMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cmbUnidadMedida.Depth = 0;
            this.cmbUnidadMedida.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbUnidadMedida.DropDownHeight = 174;
            this.cmbUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidadMedida.DropDownWidth = 121;
            this.cmbUnidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbUnidadMedida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbUnidadMedida.FormattingEnabled = true;
            this.cmbUnidadMedida.Hint = "Unidad de medida";
            this.cmbUnidadMedida.IntegralHeight = false;
            this.cmbUnidadMedida.ItemHeight = 43;
            this.cmbUnidadMedida.Location = new System.Drawing.Point(169, 201);
            this.cmbUnidadMedida.MaxDropDownItems = 4;
            this.cmbUnidadMedida.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbUnidadMedida.Name = "cmbUnidadMedida";
            this.cmbUnidadMedida.Size = new System.Drawing.Size(221, 49);
            this.cmbUnidadMedida.StartIndex = 0;
            this.cmbUnidadMedida.TabIndex = 9;
            // 
            // InsumoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 324);
            this.Controls.Add(this.cmbUnidadMedida);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptarInsumo);
            this.Controls.Add(this.txtExistenciaInsumo);
            this.Controls.Add(this.txtDescInsumo);
            this.Controls.Add(this.txtIDInsumo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "InsumoDesktop";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insumo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtIDInsumo;
        private MaterialSkin.Controls.MaterialTextBox txtDescInsumo;
        private MaterialSkin.Controls.MaterialTextBox txtExistenciaInsumo;
        private MaterialSkin.Controls.MaterialButton btnAceptarInsumo;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialComboBox cmbUnidadMedida;
    }
}