
namespace UI.Desktop
{
    partial class UsuarioDesktop
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
            this.components = new System.ComponentModel.Container();
            this.txtIdUsuario = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCuit = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.txtApellido = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNombreUsuario = new MaterialSkin.Controls.MaterialTextBox();
            this.chkHabilitado = new MaterialSkin.Controls.MaterialCheckbox();
            this.btnAceptarUsuario = new MaterialSkin.Controls.MaterialButton();
            this.btnCancelarUsuario = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btnBuscar = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.toolTipUsuario = new System.Windows.Forms.ToolTip(this.components);
            this.txtClaveUser = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtConfirmarClave = new MaterialSkin.Controls.MaterialTextBox2();
            this.showPass1 = new System.Windows.Forms.PictureBox();
            this.hidePass1 = new System.Windows.Forms.PictureBox();
            this.showPass2 = new System.Windows.Forms.PictureBox();
            this.hidePass2 = new System.Windows.Forms.PictureBox();
            this.cmbPreguntas = new MaterialSkin.Controls.MaterialComboBox();
            this.txtRespuesta = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPass1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePass1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPass2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePass2)).BeginInit();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.AnimateReadOnly = false;
            this.txtIdUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtIdUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdUsuario.Depth = 0;
            this.txtIdUsuario.Enabled = false;
            this.txtIdUsuario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtIdUsuario.Hint = "ID";
            this.txtIdUsuario.LeadingIcon = null;
            this.txtIdUsuario.Location = new System.Drawing.Point(39, 265);
            this.txtIdUsuario.MaxLength = 50;
            this.txtIdUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdUsuario.Multiline = false;
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(76, 50);
            this.txtIdUsuario.TabIndex = 4;
            this.txtIdUsuario.Text = "";
            this.txtIdUsuario.TrailingIcon = null;
            // 
            // txtCuit
            // 
            this.txtCuit.AnimateReadOnly = false;
            this.txtCuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtCuit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCuit.Depth = 0;
            this.txtCuit.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtCuit.Hint = "Cuit";
            this.txtCuit.LeadingIcon = null;
            this.txtCuit.Location = new System.Drawing.Point(13, 40);
            this.txtCuit.MaxLength = 50;
            this.txtCuit.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCuit.Multiline = false;
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(237, 50);
            this.txtCuit.TabIndex = 0;
            this.txtCuit.Text = "";
            this.toolTipUsuario.SetToolTip(this.txtCuit, "Ingrese un cuit de empleado y presiona buscar antes\r\nde ingresar los datos del us" +
        "uario.");
            this.txtCuit.TrailingIcon = null;
            // 
            // txtNombre
            // 
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Depth = 0;
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNombre.Hint = "Nombre";
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(13, 96);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(237, 50);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Text = "";
            this.txtNombre.TrailingIcon = null;
            // 
            // txtApellido
            // 
            this.txtApellido.AnimateReadOnly = false;
            this.txtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Depth = 0;
            this.txtApellido.Enabled = false;
            this.txtApellido.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtApellido.Hint = "Apellido";
            this.txtApellido.LeadingIcon = null;
            this.txtApellido.Location = new System.Drawing.Point(260, 96);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.MouseState = MaterialSkin.MouseState.OUT;
            this.txtApellido.Multiline = false;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(237, 50);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.Text = "";
            this.txtApellido.TrailingIcon = null;
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
            this.txtNombreUsuario.Location = new System.Drawing.Point(39, 321);
            this.txtNombreUsuario.MaxLength = 50;
            this.txtNombreUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreUsuario.Multiline = false;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(322, 50);
            this.txtNombreUsuario.TabIndex = 5;
            this.txtNombreUsuario.Text = "";
            this.txtNombreUsuario.TrailingIcon = null;
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.chkHabilitado.Depth = 0;
            this.chkHabilitado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkHabilitado.Location = new System.Drawing.Point(39, 688);
            this.chkHabilitado.Margin = new System.Windows.Forms.Padding(0);
            this.chkHabilitado.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkHabilitado.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.ReadOnly = false;
            this.chkHabilitado.Ripple = true;
            this.chkHabilitado.Size = new System.Drawing.Size(108, 37);
            this.chkHabilitado.TabIndex = 8;
            this.chkHabilitado.Text = "Habilitado";
            this.chkHabilitado.UseVisualStyleBackColor = false;
            // 
            // btnAceptarUsuario
            // 
            this.btnAceptarUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAceptarUsuario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAceptarUsuario.Depth = 0;
            this.btnAceptarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAceptarUsuario.HighEmphasis = true;
            this.btnAceptarUsuario.Icon = null;
            this.btnAceptarUsuario.Location = new System.Drawing.Point(362, 689);
            this.btnAceptarUsuario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAceptarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptarUsuario.Name = "btnAceptarUsuario";
            this.btnAceptarUsuario.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAceptarUsuario.Size = new System.Drawing.Size(86, 36);
            this.btnAceptarUsuario.TabIndex = 15;
            this.btnAceptarUsuario.Text = "Aceptar";
            this.btnAceptarUsuario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAceptarUsuario.UseAccentColor = false;
            this.btnAceptarUsuario.UseVisualStyleBackColor = false;
            this.btnAceptarUsuario.Click += new System.EventHandler(this.btnAceptarUsuario_Click);
            // 
            // btnCancelarUsuario
            // 
            this.btnCancelarUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCancelarUsuario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelarUsuario.Depth = 0;
            this.btnCancelarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelarUsuario.HighEmphasis = true;
            this.btnCancelarUsuario.Icon = null;
            this.btnCancelarUsuario.Location = new System.Drawing.Point(456, 689);
            this.btnCancelarUsuario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelarUsuario.Name = "btnCancelarUsuario";
            this.btnCancelarUsuario.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelarUsuario.Size = new System.Drawing.Size(96, 36);
            this.btnCancelarUsuario.TabIndex = 16;
            this.btnCancelarUsuario.Text = "Cancelar";
            this.btnCancelarUsuario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelarUsuario.UseAccentColor = false;
            this.btnCancelarUsuario.UseVisualStyleBackColor = false;
            this.btnCancelarUsuario.Click += new System.EventHandler(this.btnCancelarUsuario_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btnBuscar);
            this.materialCard1.Controls.Add(this.materialLabel8);
            this.materialCard1.Controls.Add(this.txtCuit);
            this.materialCard1.Controls.Add(this.txtNombre);
            this.materialCard1.Controls.Add(this.txtApellido);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(26, 92);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(526, 164);
            this.materialCard1.TabIndex = 17;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBuscar.HighEmphasis = true;
            this.btnBuscar.Icon = global::UI.Desktop.Properties.Resources.searcher_magnifyng_glass_search_locate_find_icon_123813;
            this.btnBuscar.Location = new System.Drawing.Point(260, 46);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscar.Size = new System.Drawing.Size(105, 36);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscar.UseAccentColor = false;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(13, 14);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(72, 19);
            this.materialLabel8.TabIndex = 0;
            this.materialLabel8.Text = "Empleado";
            // 
            // toolTipUsuario
            // 
            this.toolTipUsuario.AutoPopDelay = 5000;
            this.toolTipUsuario.InitialDelay = 300;
            this.toolTipUsuario.ReshowDelay = 100;
            this.toolTipUsuario.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipUsuario.ToolTipTitle = "Info";
            // 
            // txtClaveUser
            // 
            this.txtClaveUser.AnimateReadOnly = false;
            this.txtClaveUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtClaveUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtClaveUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtClaveUser.Depth = 0;
            this.txtClaveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtClaveUser.HideSelection = true;
            this.txtClaveUser.Hint = "Contraseña";
            this.txtClaveUser.LeadingIcon = null;
            this.txtClaveUser.Location = new System.Drawing.Point(39, 379);
            this.txtClaveUser.MaxLength = 32767;
            this.txtClaveUser.MouseState = MaterialSkin.MouseState.OUT;
            this.txtClaveUser.Name = "txtClaveUser";
            this.txtClaveUser.PasswordChar = '●';
            this.txtClaveUser.PrefixSuffixText = null;
            this.txtClaveUser.ReadOnly = false;
            this.txtClaveUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClaveUser.SelectedText = "";
            this.txtClaveUser.SelectionLength = 0;
            this.txtClaveUser.SelectionStart = 0;
            this.txtClaveUser.ShortcutsEnabled = true;
            this.txtClaveUser.Size = new System.Drawing.Size(322, 48);
            this.txtClaveUser.TabIndex = 18;
            this.txtClaveUser.TabStop = false;
            this.txtClaveUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClaveUser.TrailingIcon = null;
            this.txtClaveUser.UseSystemPasswordChar = true;
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.AnimateReadOnly = false;
            this.txtConfirmarClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtConfirmarClave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtConfirmarClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtConfirmarClave.Depth = 0;
            this.txtConfirmarClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtConfirmarClave.HideSelection = true;
            this.txtConfirmarClave.Hint = "Confirmar contraseña";
            this.txtConfirmarClave.LeadingIcon = null;
            this.txtConfirmarClave.Location = new System.Drawing.Point(39, 435);
            this.txtConfirmarClave.MaxLength = 32767;
            this.txtConfirmarClave.MouseState = MaterialSkin.MouseState.OUT;
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.PasswordChar = '●';
            this.txtConfirmarClave.PrefixSuffixText = null;
            this.txtConfirmarClave.ReadOnly = false;
            this.txtConfirmarClave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtConfirmarClave.SelectedText = "";
            this.txtConfirmarClave.SelectionLength = 0;
            this.txtConfirmarClave.SelectionStart = 0;
            this.txtConfirmarClave.ShortcutsEnabled = true;
            this.txtConfirmarClave.Size = new System.Drawing.Size(322, 48);
            this.txtConfirmarClave.TabIndex = 19;
            this.txtConfirmarClave.TabStop = false;
            this.txtConfirmarClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtConfirmarClave.TrailingIcon = null;
            this.txtConfirmarClave.UseSystemPasswordChar = true;
            // 
            // showPass1
            // 
            this.showPass1.BackColor = System.Drawing.Color.Transparent;
            this.showPass1.Image = global::UI.Desktop.Properties.Resources.show_icon_215343;
            this.showPass1.Location = new System.Drawing.Point(367, 388);
            this.showPass1.Name = "showPass1";
            this.showPass1.Size = new System.Drawing.Size(33, 30);
            this.showPass1.TabIndex = 20;
            this.showPass1.TabStop = false;
            this.showPass1.Click += new System.EventHandler(this.showPass1_Click);
            // 
            // hidePass1
            // 
            this.hidePass1.BackColor = System.Drawing.Color.Transparent;
            this.hidePass1.Image = global::UI.Desktop.Properties.Resources.hide_icon_183908;
            this.hidePass1.Location = new System.Drawing.Point(367, 388);
            this.hidePass1.Name = "hidePass1";
            this.hidePass1.Size = new System.Drawing.Size(33, 30);
            this.hidePass1.TabIndex = 21;
            this.hidePass1.TabStop = false;
            this.hidePass1.Click += new System.EventHandler(this.hidePass1_Click);
            // 
            // showPass2
            // 
            this.showPass2.BackColor = System.Drawing.Color.Transparent;
            this.showPass2.Image = global::UI.Desktop.Properties.Resources.show_icon_215343;
            this.showPass2.Location = new System.Drawing.Point(367, 447);
            this.showPass2.Name = "showPass2";
            this.showPass2.Size = new System.Drawing.Size(33, 30);
            this.showPass2.TabIndex = 23;
            this.showPass2.TabStop = false;
            this.showPass2.Click += new System.EventHandler(this.showPass2_Click);
            // 
            // hidePass2
            // 
            this.hidePass2.BackColor = System.Drawing.Color.Transparent;
            this.hidePass2.Image = global::UI.Desktop.Properties.Resources.hide_icon_183908;
            this.hidePass2.Location = new System.Drawing.Point(367, 447);
            this.hidePass2.Name = "hidePass2";
            this.hidePass2.Size = new System.Drawing.Size(33, 30);
            this.hidePass2.TabIndex = 24;
            this.hidePass2.TabStop = false;
            this.hidePass2.Click += new System.EventHandler(this.hidePass2_Click);
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
            this.cmbPreguntas.IntegralHeight = false;
            this.cmbPreguntas.ItemHeight = 43;
            this.cmbPreguntas.Location = new System.Drawing.Point(13, 26);
            this.cmbPreguntas.MaxDropDownItems = 4;
            this.cmbPreguntas.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPreguntas.Name = "cmbPreguntas";
            this.cmbPreguntas.Size = new System.Drawing.Size(502, 49);
            this.cmbPreguntas.StartIndex = 0;
            this.cmbPreguntas.TabIndex = 25;
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
            this.txtRespuesta.Location = new System.Drawing.Point(13, 108);
            this.txtRespuesta.MaxLength = 50;
            this.txtRespuesta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRespuesta.Multiline = false;
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(502, 50);
            this.txtRespuesta.TabIndex = 26;
            this.txtRespuesta.Text = "";
            this.txtRespuesta.TrailingIcon = null;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialLabel3);
            this.materialCard2.Controls.Add(this.materialLabel2);
            this.materialCard2.Controls.Add(this.cmbPreguntas);
            this.materialCard2.Controls.Add(this.txtRespuesta);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(26, 511);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(526, 169);
            this.materialCard2.TabIndex = 27;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(13, 82);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(427, 19);
            this.materialLabel3.TabIndex = 28;
            this.materialLabel3.Text = "Indique una respuesta: (IMPORTANTE recordar la respuesta)";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(13, 4);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(424, 19);
            this.materialLabel2.TabIndex = 27;
            this.materialLabel2.Text = "Selecione una pregunta: (se utiliza para recuperar la cuenta)";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(43, 490);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(128, 19);
            this.materialLabel1.TabIndex = 28;
            this.materialLabel1.Text = "Recuperar cuenta:";
            // 
            // UsuarioDesktop
            // 
            this.AcceptButton = this.btnAceptarUsuario;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelarUsuario;
            this.ClientSize = new System.Drawing.Size(574, 740);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.showPass2);
            this.Controls.Add(this.showPass1);
            this.Controls.Add(this.hidePass1);
            this.Controls.Add(this.txtConfirmarClave);
            this.Controls.Add(this.txtClaveUser);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.btnCancelarUsuario);
            this.Controls.Add(this.btnAceptarUsuario);
            this.Controls.Add(this.chkHabilitado);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.hidePass2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "UsuarioDesktop";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPass1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePass1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPass2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePass2)).EndInit();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txtIdUsuario;
        private MaterialSkin.Controls.MaterialTextBox txtCuit;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private MaterialSkin.Controls.MaterialTextBox txtApellido;
        private MaterialSkin.Controls.MaterialTextBox txtNombreUsuario;
        private MaterialSkin.Controls.MaterialCheckbox chkHabilitado;
        private MaterialSkin.Controls.MaterialButton btnAceptarUsuario;
        private MaterialSkin.Controls.MaterialButton btnCancelarUsuario;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btnBuscar;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.ToolTip toolTipUsuario;
        private MaterialSkin.Controls.MaterialTextBox2 txtClaveUser;
        private MaterialSkin.Controls.MaterialTextBox2 txtConfirmarClave;
        private System.Windows.Forms.PictureBox showPass1;
        private System.Windows.Forms.PictureBox hidePass1;
        private System.Windows.Forms.PictureBox showPass2;
        private System.Windows.Forms.PictureBox hidePass2;
        private MaterialSkin.Controls.MaterialComboBox cmbPreguntas;
        private MaterialSkin.Controls.MaterialTextBox txtRespuesta;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}