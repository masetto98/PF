﻿
namespace UI.Desktop
{
    partial class LoginHelpForm
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
            this.txtUsuario = new MaterialSkin.Controls.MaterialTextBox();
            this.btnBuscarUsuario = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btnEnviar = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtRespuesta = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbPreguntas = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btnAceptar = new MaterialSkin.Controls.MaterialButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtRepeatNewPass = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNewPass = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.AnimateReadOnly = false;
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtUsuario.Hint = "Usuario";
            this.txtUsuario.LeadingIcon = null;
            this.txtUsuario.Location = new System.Drawing.Point(13, 108);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(262, 50);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Text = "";
            this.txtUsuario.TrailingIcon = null;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnBuscarUsuario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscarUsuario.Depth = 0;
            this.btnBuscarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBuscarUsuario.HighEmphasis = true;
            this.btnBuscarUsuario.Icon = null;
            this.btnBuscarUsuario.Location = new System.Drawing.Point(282, 116);
            this.btnBuscarUsuario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscarUsuario.Size = new System.Drawing.Size(77, 36);
            this.btnBuscarUsuario.TabIndex = 1;
            this.btnBuscarUsuario.Text = "Buscar";
            this.btnBuscarUsuario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscarUsuario.UseAccentColor = false;
            this.btnBuscarUsuario.UseVisualStyleBackColor = false;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btnEnviar);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.txtRespuesta);
            this.materialCard1.Controls.Add(this.cmbPreguntas);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(13, 167);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(536, 216);
            this.materialCard1.TabIndex = 2;
            // 
            // btnEnviar
            // 
            this.btnEnviar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEnviar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEnviar.Depth = 0;
            this.btnEnviar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEnviar.HighEmphasis = true;
            this.btnEnviar.Icon = null;
            this.btnEnviar.Location = new System.Drawing.Point(445, 169);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEnviar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEnviar.Size = new System.Drawing.Size(73, 36);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEnviar.UseAccentColor = false;
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(17, 88);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(294, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Indica la respuesta indicada previamente:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(18, 6);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(179, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Seleccione una pregunta:";
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.AnimateReadOnly = false;
            this.txtRespuesta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtRespuesta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRespuesta.Depth = 0;
            this.txtRespuesta.Enabled = false;
            this.txtRespuesta.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRespuesta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtRespuesta.Hint = "Respuesta";
            this.txtRespuesta.LeadingIcon = null;
            this.txtRespuesta.Location = new System.Drawing.Point(17, 110);
            this.txtRespuesta.MaxLength = 50;
            this.txtRespuesta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRespuesta.Multiline = false;
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(501, 50);
            this.txtRespuesta.TabIndex = 1;
            this.txtRespuesta.Text = "";
            this.txtRespuesta.TrailingIcon = null;
            // 
            // cmbPreguntas
            // 
            this.cmbPreguntas.AutoResize = false;
            this.cmbPreguntas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cmbPreguntas.Depth = 0;
            this.cmbPreguntas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPreguntas.DropDownHeight = 174;
            this.cmbPreguntas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPreguntas.DropDownWidth = 121;
            this.cmbPreguntas.Enabled = false;
            this.cmbPreguntas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbPreguntas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbPreguntas.FormattingEnabled = true;
            this.cmbPreguntas.Hint = "Preguntas";
            this.cmbPreguntas.IntegralHeight = false;
            this.cmbPreguntas.ItemHeight = 43;
            this.cmbPreguntas.Location = new System.Drawing.Point(17, 31);
            this.cmbPreguntas.MaxDropDownItems = 4;
            this.cmbPreguntas.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPreguntas.Name = "cmbPreguntas";
            this.cmbPreguntas.Size = new System.Drawing.Size(501, 49);
            this.cmbPreguntas.StartIndex = 0;
            this.cmbPreguntas.TabIndex = 0;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(13, 83);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(213, 19);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Ingrese su nombre de usuario:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAceptar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAceptar.Depth = 0;
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAceptar.HighEmphasis = true;
            this.btnAceptar.Icon = null;
            this.btnAceptar.Location = new System.Drawing.Point(378, 559);
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
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
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
            this.btnCancelar.Location = new System.Drawing.Point(472, 559);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(77, 36);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialLabel4);
            this.materialCard2.Controls.Add(this.txtRepeatNewPass);
            this.materialCard2.Controls.Add(this.txtNewPass);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(13, 388);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(290, 166);
            this.materialCard2.TabIndex = 6;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(18, 9);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(133, 19);
            this.materialLabel4.TabIndex = 2;
            this.materialLabel4.Text = "Nueva contraseña:";
            // 
            // txtRepeatNewPass
            // 
            this.txtRepeatNewPass.AnimateReadOnly = false;
            this.txtRepeatNewPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtRepeatNewPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRepeatNewPass.Depth = 0;
            this.txtRepeatNewPass.Enabled = false;
            this.txtRepeatNewPass.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRepeatNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtRepeatNewPass.Hint = "Repita nueva contraseña";
            this.txtRepeatNewPass.LeadingIcon = null;
            this.txtRepeatNewPass.Location = new System.Drawing.Point(18, 88);
            this.txtRepeatNewPass.MaxLength = 50;
            this.txtRepeatNewPass.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRepeatNewPass.Multiline = false;
            this.txtRepeatNewPass.Name = "txtRepeatNewPass";
            this.txtRepeatNewPass.Size = new System.Drawing.Size(255, 50);
            this.txtRepeatNewPass.TabIndex = 1;
            this.txtRepeatNewPass.Text = "";
            this.txtRepeatNewPass.TrailingIcon = null;
            // 
            // txtNewPass
            // 
            this.txtNewPass.AnimateReadOnly = false;
            this.txtNewPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtNewPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPass.Depth = 0;
            this.txtNewPass.Enabled = false;
            this.txtNewPass.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNewPass.Hint = "Nueva contraseña";
            this.txtNewPass.LeadingIcon = null;
            this.txtNewPass.Location = new System.Drawing.Point(17, 31);
            this.txtNewPass.MaxLength = 50;
            this.txtNewPass.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNewPass.Multiline = false;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(256, 50);
            this.txtNewPass.TabIndex = 0;
            this.txtNewPass.Text = "";
            this.txtNewPass.TrailingIcon = null;
            // 
            // LoginHelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 610);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.btnBuscarUsuario);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "LoginHelpForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperar contraseña";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtUsuario;
        private MaterialSkin.Controls.MaterialButton btnBuscarUsuario;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtRespuesta;
        private MaterialSkin.Controls.MaterialComboBox cmbPreguntas;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton btnAceptar;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialButton btnEnviar;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox txtRepeatNewPass;
        private MaterialSkin.Controls.MaterialTextBox txtNewPass;
    }
}