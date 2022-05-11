
namespace UI.Desktop
{
    partial class frmLogin2
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
            this.txtContrasenia = new MaterialSkin.Controls.MaterialTextBox();
            this.lblBienvenido = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIngresar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnIngresar.Depth = 0;
            this.btnIngresar.HighEmphasis = true;
            this.btnIngresar.Icon = null;
            this.btnIngresar.Location = new System.Drawing.Point(282, 238);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIngresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnIngresar.Size = new System.Drawing.Size(91, 36);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnIngresar.UseAccentColor = false;
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.AnimateReadOnly = false;
            this.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreUsuario.Depth = 0;
            this.txtNombreUsuario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreUsuario.Hint = "Nombre de usuario";
            this.txtNombreUsuario.LeadingIcon = null;
            this.txtNombreUsuario.Location = new System.Drawing.Point(80, 110);
            this.txtNombreUsuario.MaxLength = 50;
            this.txtNombreUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreUsuario.Multiline = false;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(293, 50);
            this.txtNombreUsuario.TabIndex = 1;
            this.txtNombreUsuario.Text = "";
            this.txtNombreUsuario.TrailingIcon = null;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.AnimateReadOnly = false;
            this.txtContrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasenia.Depth = 0;
            this.txtContrasenia.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtContrasenia.Hint = "Contraseña";
            this.txtContrasenia.LeadingIcon = null;
            this.txtContrasenia.Location = new System.Drawing.Point(80, 179);
            this.txtContrasenia.MaxLength = 50;
            this.txtContrasenia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContrasenia.Multiline = false;
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(293, 50);
            this.txtContrasenia.TabIndex = 2;
            this.txtContrasenia.Text = "";
            this.txtContrasenia.TrailingIcon = null;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Depth = 0;
            this.lblBienvenido.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBienvenido.Location = new System.Drawing.Point(16, 77);
            this.lblBienvenido.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(396, 19);
            this.lblBienvenido.TabIndex = 3;
            this.lblBienvenido.Text = "Bienvenido al software de administracion de lavanderia!";
            // 
            // frmLogin2
            // 
            this.AcceptButton = this.btnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 302);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.btnIngresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin2";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnIngresar;
        private MaterialSkin.Controls.MaterialTextBox txtNombreUsuario;
        private MaterialSkin.Controls.MaterialTextBox txtContrasenia;
        private MaterialSkin.Controls.MaterialLabel lblBienvenido;
    }
}