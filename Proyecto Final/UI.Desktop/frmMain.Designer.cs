
namespace UI.Desktop
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnNuevoCliente = new MaterialSkin.Controls.MaterialButton();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNuevoEmpleado = new MaterialSkin.Controls.MaterialButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevoCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNuevoCliente.Depth = 0;
            this.btnNuevoCliente.HighEmphasis = true;
            this.btnNuevoCliente.Icon = null;
            this.btnNuevoCliente.Location = new System.Drawing.Point(63, 29);
            this.btnNuevoCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNuevoCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNuevoCliente.Size = new System.Drawing.Size(131, 36);
            this.btnNuevoCliente.TabIndex = 0;
            this.btnNuevoCliente.Text = "Nuevo Cliente";
            this.btnNuevoCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNuevoCliente.UseAccentColor = false;
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(794, 383);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.btnNuevoEmpleado);
            this.tabPage1.Controls.Add(this.btnNuevoCliente);
            this.tabPage1.ImageKey = "adduser_añadir_3553.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(786, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo Cliente";
            // 
            // btnNuevoEmpleado
            // 
            this.btnNuevoEmpleado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevoEmpleado.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNuevoEmpleado.Depth = 0;
            this.btnNuevoEmpleado.HighEmphasis = true;
            this.btnNuevoEmpleado.Icon = null;
            this.btnNuevoEmpleado.Location = new System.Drawing.Point(63, 93);
            this.btnNuevoEmpleado.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNuevoEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevoEmpleado.Name = "btnNuevoEmpleado";
            this.btnNuevoEmpleado.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNuevoEmpleado.Size = new System.Drawing.Size(150, 36);
            this.btnNuevoEmpleado.TabIndex = 1;
            this.btnNuevoEmpleado.Text = "Nuevo Empleado";
            this.btnNuevoEmpleado.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNuevoEmpleado.UseAccentColor = false;
            this.btnNuevoEmpleado.UseVisualStyleBackColor = true;
            this.btnNuevoEmpleado.Click += new System.EventHandler(this.btnNuevoEmpleado_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(786, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "adduser_añadir_3553.png");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialTabControl1);
            this.DoubleBuffered = false;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = " Lavanderia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            //this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnNuevoCliente;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialButton btnNuevoEmpleado;
    }
}

