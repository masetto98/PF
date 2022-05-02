
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
            this.lblBienvenido = new MaterialSkin.Controls.MaterialLabel();
            this.lblNombreUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.lblContrasenia = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombreUsuario = new MaterialSkin.Controls.MaterialTextBox();
            this.txtContrasenia = new MaterialSkin.Controls.MaterialTextBox();
            this.btnIngresar = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Depth = 0;
            this.lblBienvenido.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBienvenido.Location = new System.Drawing.Point(77, 86);
            this.lblBienvenido.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(341, 19);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Bienvenido al Sistema de Gestión de Lavandería";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Depth = 0;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNombreUsuario.Location = new System.Drawing.Point(77, 167);
            this.lblNombreUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(140, 19);
            this.lblNombreUsuario.TabIndex = 1;
            this.lblNombreUsuario.Text = "Nombre de Usuario:";
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Depth = 0;
            this.lblContrasenia.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblContrasenia.Location = new System.Drawing.Point(77, 266);
            this.lblContrasenia.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(86, 19);
            this.lblContrasenia.TabIndex = 2;
            this.lblContrasenia.Text = "Contraseña:";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.AnimateReadOnly = false;
            this.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreUsuario.Depth = 0;
            this.txtNombreUsuario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreUsuario.LeadingIcon = null;
            this.txtNombreUsuario.Location = new System.Drawing.Point(77, 199);
            this.txtNombreUsuario.MaxLength = 50;
            this.txtNombreUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreUsuario.Multiline = false;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(298, 50);
            this.txtNombreUsuario.TabIndex = 3;
            this.txtNombreUsuario.Text = "";
            this.txtNombreUsuario.TrailingIcon = null;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.AnimateReadOnly = false;
            this.txtContrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasenia.Depth = 0;
            this.txtContrasenia.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtContrasenia.LeadingIcon = null;
            this.txtContrasenia.Location = new System.Drawing.Point(77, 297);
            this.txtContrasenia.MaxLength = 50;
            this.txtContrasenia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContrasenia.Multiline = false;
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Password = true;
            this.txtContrasenia.Size = new System.Drawing.Size(298, 50);
            this.txtContrasenia.TabIndex = 4;
            this.txtContrasenia.Text = "";
            this.txtContrasenia.TrailingIcon = null;
            // 
            // btnIngresar
            // 
            this.btnIngresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIngresar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnIngresar.Depth = 0;
            this.btnIngresar.HighEmphasis = true;
            this.btnIngresar.Icon = null;
            this.btnIngresar.Location = new System.Drawing.Point(284, 378);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIngresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnIngresar.Size = new System.Drawing.Size(91, 36);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnIngresar.UseAccentColor = false;
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 475);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.lblBienvenido);
            this.DoubleBuffered = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblBienvenido;
        private MaterialSkin.Controls.MaterialLabel lblNombreUsuario;
        private MaterialSkin.Controls.MaterialLabel lblContrasenia;
        private MaterialSkin.Controls.MaterialTextBox txtNombreUsuario;
        private MaterialSkin.Controls.MaterialTextBox txtContrasenia;
        private MaterialSkin.Controls.MaterialButton btnIngresar;
    }
}