
namespace UI.Desktop
{
    partial class frmLogin
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
            this.btnIngresar = new MaterialSkin.Controls.MaterialButton();
            this.txtNombreUsuario = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtContrasenia = new MaterialSkin.Controls.MaterialTextBox2();
            this.showPass1 = new System.Windows.Forms.PictureBox();
            this.hidePass1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCuenta = new MaterialSkin.Controls.MaterialLabel();
            this.btnCrearCuenta = new MaterialSkin.Controls.MaterialButton();
            this.linklblLoginHelp = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.showPass1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePass1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnIngresar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnIngresar.Depth = 0;
            this.btnIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIngresar.HighEmphasis = true;
            this.btnIngresar.Icon = null;
            this.btnIngresar.Location = new System.Drawing.Point(348, 296);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIngresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnIngresar.Size = new System.Drawing.Size(91, 36);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnIngresar.UseAccentColor = false;
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.AnimateReadOnly = false;
            this.txtNombreUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreUsuario.Depth = 0;
            this.txtNombreUsuario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNombreUsuario.Hint = "Nombre de usuario";
            this.txtNombreUsuario.LeadingIcon = null;
            this.txtNombreUsuario.Location = new System.Drawing.Point(202, 120);
            this.txtNombreUsuario.MaxLength = 50;
            this.txtNombreUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreUsuario.Multiline = false;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(237, 50);
            this.txtNombreUsuario.TabIndex = 1;
            this.txtNombreUsuario.Text = "";
            this.txtNombreUsuario.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(202, 98);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(136, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Nombre de Usuario";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(202, 173);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(82, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Contraseña";
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.AnimateReadOnly = false;
            this.txtContrasenia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtContrasenia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtContrasenia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtContrasenia.Depth = 0;
            this.txtContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtContrasenia.HelperText = "Incluir minúsculas/mayúsculas";
            this.txtContrasenia.HideSelection = true;
            this.txtContrasenia.Hint = "Password";
            this.txtContrasenia.LeadingIcon = null;
            this.txtContrasenia.Location = new System.Drawing.Point(202, 200);
            this.txtContrasenia.MaxLength = 32767;
            this.txtContrasenia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '●';
            this.txtContrasenia.PrefixSuffixText = null;
            this.txtContrasenia.ReadOnly = false;
            this.txtContrasenia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtContrasenia.SelectedText = "";
            this.txtContrasenia.SelectionLength = 0;
            this.txtContrasenia.SelectionStart = 0;
            this.txtContrasenia.ShortcutsEnabled = true;
            this.txtContrasenia.ShowAssistiveText = true;
            this.txtContrasenia.Size = new System.Drawing.Size(237, 64);
            this.txtContrasenia.TabIndex = 5;
            this.txtContrasenia.TabStop = false;
            this.txtContrasenia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContrasenia.TrailingIcon = null;
            this.txtContrasenia.UseSystemPasswordChar = true;
            // 
            // showPass1
            // 
            this.showPass1.BackColor = System.Drawing.Color.Transparent;
            this.showPass1.Image = global::UI.Desktop.Properties.Resources.show_icon_215343;
            this.showPass1.Location = new System.Drawing.Point(445, 209);
            this.showPass1.Name = "showPass1";
            this.showPass1.Size = new System.Drawing.Size(33, 30);
            this.showPass1.TabIndex = 21;
            this.showPass1.TabStop = false;
            this.showPass1.Click += new System.EventHandler(this.showPass1_Click);
            // 
            // hidePass1
            // 
            this.hidePass1.BackColor = System.Drawing.Color.Transparent;
            this.hidePass1.Image = global::UI.Desktop.Properties.Resources.hide_icon_183908;
            this.hidePass1.Location = new System.Drawing.Point(445, 209);
            this.hidePass1.Name = "hidePass1";
            this.hidePass1.Size = new System.Drawing.Size(33, 30);
            this.hidePass1.TabIndex = 22;
            this.hidePass1.TabStop = false;
            this.hidePass1.Click += new System.EventHandler(this.hidePass1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::UI.Desktop.Properties.Resources.laundry_washing_machine_clothes_clean_wash_icon_196839__1_;
            this.pictureBox1.Location = new System.Drawing.Point(37, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 131);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblCuenta.Depth = 0;
            this.lblCuenta.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCuenta.Location = new System.Drawing.Point(21, 271);
            this.lblCuenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(166, 19);
            this.lblCuenta.TabIndex = 24;
            this.lblCuenta.Text = "¿No tienes una cuenta?";
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCrearCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCrearCuenta.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCrearCuenta.Depth = 0;
            this.btnCrearCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCrearCuenta.HighEmphasis = true;
            this.btnCrearCuenta.Icon = null;
            this.btnCrearCuenta.Location = new System.Drawing.Point(37, 296);
            this.btnCrearCuenta.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCrearCuenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCrearCuenta.Size = new System.Drawing.Size(128, 36);
            this.btnCrearCuenta.TabIndex = 25;
            this.btnCrearCuenta.Text = "Crear cuenta";
            this.btnCrearCuenta.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCrearCuenta.UseAccentColor = false;
            this.btnCrearCuenta.UseVisualStyleBackColor = false;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // linklblLoginHelp
            // 
            this.linklblLoginHelp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linklblLoginHelp.Location = new System.Drawing.Point(224, 269);
            this.linklblLoginHelp.Name = "linklblLoginHelp";
            this.linklblLoginHelp.Size = new System.Drawing.Size(216, 23);
            this.linklblLoginHelp.TabIndex = 27;
            this.linklblLoginHelp.TabStop = true;
            this.linklblLoginHelp.Text = "¿No recuerdas tu contraseña?";
            this.linklblLoginHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblLoginHelp_LinkClicked);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 343);
            this.Controls.Add(this.linklblLoginHelp);
            this.Controls.Add(this.btnCrearCuenta);
            this.Controls.Add(this.lblCuenta);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.showPass1);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.hidePass1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar";
            ((System.ComponentModel.ISupportInitialize)(this.showPass1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePass1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnIngresar;
        private MaterialSkin.Controls.MaterialTextBox txtNombreUsuario;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 txtContrasenia;
        private System.Windows.Forms.PictureBox showPass1;
        private System.Windows.Forms.PictureBox hidePass1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel lblCuenta;
        private MaterialSkin.Controls.MaterialButton btnCrearCuenta;
        private System.Windows.Forms.LinkLabel linklblLoginHelp;
    }
}