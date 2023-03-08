
namespace UI.Desktop
{
    partial class Maquinas
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
            FastReport.DataVisualization.Charting.ChartArea chartArea1 = new FastReport.DataVisualization.Charting.ChartArea();
            FastReport.DataVisualization.Charting.Series series1 = new FastReport.DataVisualization.Charting.Series();
            FastReport.DataVisualization.Charting.Title title1 = new FastReport.DataVisualization.Charting.Title();
            this.listMaquinas = new MaterialSkin.Controls.MaterialListView();
            this.columnID = new System.Windows.Forms.ColumnHeader();
            this.columnDescripcion = new System.Windows.Forms.ColumnHeader();
            this.btnEditarMaquina = new MaterialSkin.Controls.MaterialButton();
            this.btnEliminarMaquina = new MaterialSkin.Controls.MaterialButton();
            this.btnAgregarMaquina = new MaterialSkin.Controls.MaterialButton();
            this.listMantenimientos = new MaterialSkin.Controls.MaterialListView();
            this.columnFechaRealizacion = new System.Windows.Forms.ColumnHeader();
            this.columnDescripcion2 = new System.Windows.Forms.ColumnHeader();
            this.columnCosto = new System.Windows.Forms.ColumnHeader();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lblMantenimientosRealizados = new MaterialSkin.Controls.MaterialLabel();
            this.lblOrdenesAtendidas = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lblEstadisticas = new MaterialSkin.Controls.MaterialLabel();
            this.btnEditarMantenimiento = new MaterialSkin.Controls.MaterialButton();
            this.btnEliminarMantenimiento = new MaterialSkin.Controls.MaterialButton();
            this.btnAgregarMantenimiento = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCerrar = new MaterialSkin.Controls.MaterialButton();
            this.listTiposMaquina = new MaterialSkin.Controls.MaterialListView();
            this.columnIdTpm = new System.Windows.Forms.ColumnHeader();
            this.columnDescripcionTpm = new System.Windows.Forms.ColumnHeader();
            this.btnEditarTipoMaquina = new MaterialSkin.Controls.MaterialButton();
            this.btnEliminarTipoMaquina = new MaterialSkin.Controls.MaterialButton();
            this.btnAgregarTipoMaquina = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.chartUsoMaq = new FastReport.DataVisualization.Charting.Chart();
            this.dtpMaquinaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpMaquinaHasta = new System.Windows.Forms.DateTimePicker();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsoMaq)).BeginInit();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listMaquinas
            // 
            this.listMaquinas.AutoSizeTable = false;
            this.listMaquinas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listMaquinas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listMaquinas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnDescripcion});
            this.listMaquinas.Depth = 0;
            this.listMaquinas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listMaquinas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listMaquinas.FullRowSelect = true;
            this.listMaquinas.HideSelection = false;
            this.listMaquinas.Location = new System.Drawing.Point(12, 435);
            this.listMaquinas.MinimumSize = new System.Drawing.Size(200, 100);
            this.listMaquinas.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listMaquinas.MouseState = MaterialSkin.MouseState.OUT;
            this.listMaquinas.MultiSelect = false;
            this.listMaquinas.Name = "listMaquinas";
            this.listMaquinas.OwnerDraw = true;
            this.listMaquinas.Size = new System.Drawing.Size(363, 243);
            this.listMaquinas.TabIndex = 0;
            this.listMaquinas.UseCompatibleStateImageBehavior = false;
            this.listMaquinas.View = System.Windows.Forms.View.Details;
            this.listMaquinas.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listMaquinas_ColumnWidthChanging);
            this.listMaquinas.SelectedIndexChanged += new System.EventHandler(this.listMaquinas_SelectedIndexChanged);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 70;
            // 
            // columnDescripcion
            // 
            this.columnDescripcion.Text = "Descripción";
            this.columnDescripcion.Width = 293;
            // 
            // btnEditarMaquina
            // 
            this.btnEditarMaquina.AutoSize = false;
            this.btnEditarMaquina.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditarMaquina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEditarMaquina.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditarMaquina.Depth = 0;
            this.btnEditarMaquina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditarMaquina.HighEmphasis = true;
            this.btnEditarMaquina.Icon = global::UI.Desktop.Properties.Resources._353430_checkbox_edit_pen_pencil_107516;
            this.btnEditarMaquina.Location = new System.Drawing.Point(134, 390);
            this.btnEditarMaquina.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditarMaquina.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarMaquina.Name = "btnEditarMaquina";
            this.btnEditarMaquina.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditarMaquina.Size = new System.Drawing.Size(110, 36);
            this.btnEditarMaquina.TabIndex = 14;
            this.btnEditarMaquina.Text = "Editar";
            this.btnEditarMaquina.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditarMaquina.UseAccentColor = false;
            this.btnEditarMaquina.UseVisualStyleBackColor = false;
            this.btnEditarMaquina.Click += new System.EventHandler(this.btnEditarMaquina_Click);
            // 
            // btnEliminarMaquina
            // 
            this.btnEliminarMaquina.AutoSize = false;
            this.btnEliminarMaquina.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarMaquina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEliminarMaquina.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarMaquina.Depth = 0;
            this.btnEliminarMaquina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarMaquina.HighEmphasis = true;
            this.btnEliminarMaquina.Icon = global::UI.Desktop.Properties.Resources.trash_bin_icon_icons_com_67981;
            this.btnEliminarMaquina.Location = new System.Drawing.Point(252, 390);
            this.btnEliminarMaquina.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarMaquina.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarMaquina.Name = "btnEliminarMaquina";
            this.btnEliminarMaquina.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminarMaquina.Size = new System.Drawing.Size(114, 36);
            this.btnEliminarMaquina.TabIndex = 13;
            this.btnEliminarMaquina.Text = "Eliminar";
            this.btnEliminarMaquina.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminarMaquina.UseAccentColor = false;
            this.btnEliminarMaquina.UseVisualStyleBackColor = false;
            this.btnEliminarMaquina.Click += new System.EventHandler(this.btnEliminarMaquina_Click);
            // 
            // btnAgregarMaquina
            // 
            this.btnAgregarMaquina.AutoSize = false;
            this.btnAgregarMaquina.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarMaquina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAgregarMaquina.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarMaquina.Depth = 0;
            this.btnAgregarMaquina.Enabled = false;
            this.btnAgregarMaquina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAgregarMaquina.HighEmphasis = true;
            this.btnAgregarMaquina.Icon = global::UI.Desktop.Properties.Resources.plus_icon_icons_com_70890;
            this.btnAgregarMaquina.Location = new System.Drawing.Point(12, 390);
            this.btnAgregarMaquina.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarMaquina.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarMaquina.Name = "btnAgregarMaquina";
            this.btnAgregarMaquina.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarMaquina.Size = new System.Drawing.Size(114, 36);
            this.btnAgregarMaquina.TabIndex = 12;
            this.btnAgregarMaquina.Text = "Agregar";
            this.btnAgregarMaquina.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarMaquina.UseAccentColor = false;
            this.btnAgregarMaquina.UseVisualStyleBackColor = false;
            this.btnAgregarMaquina.Click += new System.EventHandler(this.btnAgregarMaquina_Click);
            // 
            // listMantenimientos
            // 
            this.listMantenimientos.AutoSizeTable = false;
            this.listMantenimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listMantenimientos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listMantenimientos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFechaRealizacion,
            this.columnDescripcion2,
            this.columnCosto});
            this.listMantenimientos.Depth = 0;
            this.listMantenimientos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listMantenimientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listMantenimientos.FullRowSelect = true;
            this.listMantenimientos.HideSelection = false;
            this.listMantenimientos.Location = new System.Drawing.Point(386, 522);
            this.listMantenimientos.MinimumSize = new System.Drawing.Size(200, 100);
            this.listMantenimientos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listMantenimientos.MouseState = MaterialSkin.MouseState.OUT;
            this.listMantenimientos.MultiSelect = false;
            this.listMantenimientos.Name = "listMantenimientos";
            this.listMantenimientos.OwnerDraw = true;
            this.listMantenimientos.Size = new System.Drawing.Size(505, 156);
            this.listMantenimientos.TabIndex = 15;
            this.listMantenimientos.UseCompatibleStateImageBehavior = false;
            this.listMantenimientos.View = System.Windows.Forms.View.Details;
            this.listMantenimientos.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listMantenimientos_ColumnWidthChanging);
            // 
            // columnFechaRealizacion
            // 
            this.columnFechaRealizacion.Text = "Fecha";
            this.columnFechaRealizacion.Width = 200;
            // 
            // columnDescripcion2
            // 
            this.columnDescripcion2.Text = "Descripción";
            this.columnDescripcion2.Width = 210;
            // 
            // columnCosto
            // 
            this.columnCosto.Text = "Costo";
            this.columnCosto.Width = 95;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblMantenimientosRealizados);
            this.materialCard1.Controls.Add(this.lblOrdenesAtendidas);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.lblEstadisticas);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(384, 371);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(507, 97);
            this.materialCard1.TabIndex = 17;
            // 
            // lblMantenimientosRealizados
            // 
            this.lblMantenimientosRealizados.AutoSize = true;
            this.lblMantenimientosRealizados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblMantenimientosRealizados.Depth = 0;
            this.lblMantenimientosRealizados.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMantenimientosRealizados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMantenimientosRealizados.Location = new System.Drawing.Point(302, 62);
            this.lblMantenimientosRealizados.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMantenimientosRealizados.Name = "lblMantenimientosRealizados";
            this.lblMantenimientosRealizados.Size = new System.Drawing.Size(5, 19);
            this.lblMantenimientosRealizados.TabIndex = 4;
            this.lblMantenimientosRealizados.Text = "-";
            // 
            // lblOrdenesAtendidas
            // 
            this.lblOrdenesAtendidas.AutoSize = true;
            this.lblOrdenesAtendidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblOrdenesAtendidas.Depth = 0;
            this.lblOrdenesAtendidas.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblOrdenesAtendidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOrdenesAtendidas.Location = new System.Drawing.Point(249, 32);
            this.lblOrdenesAtendidas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOrdenesAtendidas.Name = "lblOrdenesAtendidas";
            this.lblOrdenesAtendidas.Size = new System.Drawing.Size(5, 19);
            this.lblOrdenesAtendidas.TabIndex = 3;
            this.lblOrdenesAtendidas.Text = "-";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(9, 62);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(286, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Cantidad de mantenimientos realizados:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(9, 32);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(233, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Cantidad de ordenes antendidas:";
            // 
            // lblEstadisticas
            // 
            this.lblEstadisticas.AutoSize = true;
            this.lblEstadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblEstadisticas.Depth = 0;
            this.lblEstadisticas.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEstadisticas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEstadisticas.Location = new System.Drawing.Point(9, 9);
            this.lblEstadisticas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstadisticas.Name = "lblEstadisticas";
            this.lblEstadisticas.Size = new System.Drawing.Size(91, 19);
            this.lblEstadisticas.TabIndex = 0;
            this.lblEstadisticas.Text = "Estadísticas:";
            // 
            // btnEditarMantenimiento
            // 
            this.btnEditarMantenimiento.AutoSize = false;
            this.btnEditarMantenimiento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditarMantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEditarMantenimiento.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditarMantenimiento.Depth = 0;
            this.btnEditarMantenimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditarMantenimiento.HighEmphasis = true;
            this.btnEditarMantenimiento.Icon = global::UI.Desktop.Properties.Resources._353430_checkbox_edit_pen_pencil_107516;
            this.btnEditarMantenimiento.Location = new System.Drawing.Point(665, 475);
            this.btnEditarMantenimiento.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditarMantenimiento.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarMantenimiento.Name = "btnEditarMantenimiento";
            this.btnEditarMantenimiento.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditarMantenimiento.Size = new System.Drawing.Size(109, 36);
            this.btnEditarMantenimiento.TabIndex = 20;
            this.btnEditarMantenimiento.Text = "Editar";
            this.btnEditarMantenimiento.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditarMantenimiento.UseAccentColor = false;
            this.btnEditarMantenimiento.UseVisualStyleBackColor = false;
            this.btnEditarMantenimiento.Click += new System.EventHandler(this.btnEditarMantenimiento_Click);
            // 
            // btnEliminarMantenimiento
            // 
            this.btnEliminarMantenimiento.AutoSize = false;
            this.btnEliminarMantenimiento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarMantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEliminarMantenimiento.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarMantenimiento.Depth = 0;
            this.btnEliminarMantenimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarMantenimiento.HighEmphasis = true;
            this.btnEliminarMantenimiento.Icon = global::UI.Desktop.Properties.Resources.trash_bin_icon_icons_com_67981;
            this.btnEliminarMantenimiento.Location = new System.Drawing.Point(782, 475);
            this.btnEliminarMantenimiento.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarMantenimiento.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarMantenimiento.Name = "btnEliminarMantenimiento";
            this.btnEliminarMantenimiento.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminarMantenimiento.Size = new System.Drawing.Size(109, 36);
            this.btnEliminarMantenimiento.TabIndex = 19;
            this.btnEliminarMantenimiento.Text = "Eliminar";
            this.btnEliminarMantenimiento.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminarMantenimiento.UseAccentColor = false;
            this.btnEliminarMantenimiento.UseVisualStyleBackColor = false;
            this.btnEliminarMantenimiento.Click += new System.EventHandler(this.btnEliminarMantenimiento_Click);
            // 
            // btnAgregarMantenimiento
            // 
            this.btnAgregarMantenimiento.AutoSize = false;
            this.btnAgregarMantenimiento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarMantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAgregarMantenimiento.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarMantenimiento.Depth = 0;
            this.btnAgregarMantenimiento.Enabled = false;
            this.btnAgregarMantenimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAgregarMantenimiento.HighEmphasis = true;
            this.btnAgregarMantenimiento.Icon = global::UI.Desktop.Properties.Resources.plus_icon_icons_com_70890;
            this.btnAgregarMantenimiento.Location = new System.Drawing.Point(548, 475);
            this.btnAgregarMantenimiento.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarMantenimiento.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarMantenimiento.Name = "btnAgregarMantenimiento";
            this.btnAgregarMantenimiento.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarMantenimiento.Size = new System.Drawing.Size(109, 36);
            this.btnAgregarMantenimiento.TabIndex = 18;
            this.btnAgregarMantenimiento.Text = "Agregar";
            this.btnAgregarMantenimiento.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarMantenimiento.UseAccentColor = false;
            this.btnAgregarMantenimiento.UseVisualStyleBackColor = false;
            this.btnAgregarMantenimiento.Click += new System.EventHandler(this.btnAgregarMantenimiento_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(386, 489);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(120, 19);
            this.materialLabel4.TabIndex = 21;
            this.materialLabel4.Text = "Mantenimientos:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCerrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCerrar.Depth = 0;
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.HighEmphasis = true;
            this.btnCerrar.Icon = null;
            this.btnCerrar.Location = new System.Drawing.Point(814, 687);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCerrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCerrar.Size = new System.Drawing.Size(77, 36);
            this.btnCerrar.TabIndex = 22;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCerrar.UseAccentColor = false;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // listTiposMaquina
            // 
            this.listTiposMaquina.AutoSizeTable = false;
            this.listTiposMaquina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listTiposMaquina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listTiposMaquina.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIdTpm,
            this.columnDescripcionTpm});
            this.listTiposMaquina.Depth = 0;
            this.listTiposMaquina.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listTiposMaquina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listTiposMaquina.FullRowSelect = true;
            this.listTiposMaquina.HideSelection = false;
            this.listTiposMaquina.Location = new System.Drawing.Point(12, 150);
            this.listTiposMaquina.MinimumSize = new System.Drawing.Size(200, 100);
            this.listTiposMaquina.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listTiposMaquina.MouseState = MaterialSkin.MouseState.OUT;
            this.listTiposMaquina.MultiSelect = false;
            this.listTiposMaquina.Name = "listTiposMaquina";
            this.listTiposMaquina.OwnerDraw = true;
            this.listTiposMaquina.Size = new System.Drawing.Size(355, 212);
            this.listTiposMaquina.TabIndex = 23;
            this.listTiposMaquina.UseCompatibleStateImageBehavior = false;
            this.listTiposMaquina.View = System.Windows.Forms.View.Details;
            this.listTiposMaquina.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listTiposMaquina_ColumnWidthChanging);
            this.listTiposMaquina.SelectedIndexChanged += new System.EventHandler(this.listTiposMaquina_SelectedIndexChanged);
            // 
            // columnIdTpm
            // 
            this.columnIdTpm.Text = "ID";
            this.columnIdTpm.Width = 80;
            // 
            // columnDescripcionTpm
            // 
            this.columnDescripcionTpm.Text = "Descripción";
            this.columnDescripcionTpm.Width = 275;
            // 
            // btnEditarTipoMaquina
            // 
            this.btnEditarTipoMaquina.AutoSize = false;
            this.btnEditarTipoMaquina.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditarTipoMaquina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEditarTipoMaquina.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditarTipoMaquina.Depth = 0;
            this.btnEditarTipoMaquina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditarTipoMaquina.HighEmphasis = true;
            this.btnEditarTipoMaquina.Icon = global::UI.Desktop.Properties.Resources._353430_checkbox_edit_pen_pencil_107516;
            this.btnEditarTipoMaquina.Location = new System.Drawing.Point(134, 109);
            this.btnEditarTipoMaquina.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditarTipoMaquina.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarTipoMaquina.Name = "btnEditarTipoMaquina";
            this.btnEditarTipoMaquina.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditarTipoMaquina.Size = new System.Drawing.Size(110, 36);
            this.btnEditarTipoMaquina.TabIndex = 26;
            this.btnEditarTipoMaquina.Text = "Editar";
            this.btnEditarTipoMaquina.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditarTipoMaquina.UseAccentColor = false;
            this.btnEditarTipoMaquina.UseVisualStyleBackColor = false;
            this.btnEditarTipoMaquina.Click += new System.EventHandler(this.btnEditarTipoMaquina_Click);
            // 
            // btnEliminarTipoMaquina
            // 
            this.btnEliminarTipoMaquina.AutoSize = false;
            this.btnEliminarTipoMaquina.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarTipoMaquina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEliminarTipoMaquina.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarTipoMaquina.Depth = 0;
            this.btnEliminarTipoMaquina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarTipoMaquina.HighEmphasis = true;
            this.btnEliminarTipoMaquina.Icon = global::UI.Desktop.Properties.Resources.trash_bin_icon_icons_com_67981;
            this.btnEliminarTipoMaquina.Location = new System.Drawing.Point(252, 109);
            this.btnEliminarTipoMaquina.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarTipoMaquina.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarTipoMaquina.Name = "btnEliminarTipoMaquina";
            this.btnEliminarTipoMaquina.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminarTipoMaquina.Size = new System.Drawing.Size(114, 36);
            this.btnEliminarTipoMaquina.TabIndex = 25;
            this.btnEliminarTipoMaquina.Text = "Eliminar";
            this.btnEliminarTipoMaquina.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminarTipoMaquina.UseAccentColor = false;
            this.btnEliminarTipoMaquina.UseVisualStyleBackColor = false;
            this.btnEliminarTipoMaquina.Click += new System.EventHandler(this.btnEliminarTipoMaquina_Click);
            // 
            // btnAgregarTipoMaquina
            // 
            this.btnAgregarTipoMaquina.AutoSize = false;
            this.btnAgregarTipoMaquina.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarTipoMaquina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAgregarTipoMaquina.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarTipoMaquina.Depth = 0;
            this.btnAgregarTipoMaquina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAgregarTipoMaquina.HighEmphasis = true;
            this.btnAgregarTipoMaquina.Icon = global::UI.Desktop.Properties.Resources.plus_icon_icons_com_70890;
            this.btnAgregarTipoMaquina.Location = new System.Drawing.Point(12, 109);
            this.btnAgregarTipoMaquina.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarTipoMaquina.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarTipoMaquina.Name = "btnAgregarTipoMaquina";
            this.btnAgregarTipoMaquina.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarTipoMaquina.Size = new System.Drawing.Size(114, 36);
            this.btnAgregarTipoMaquina.TabIndex = 24;
            this.btnAgregarTipoMaquina.Text = "Agregar";
            this.btnAgregarTipoMaquina.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarTipoMaquina.UseAccentColor = false;
            this.btnAgregarTipoMaquina.UseVisualStyleBackColor = false;
            this.btnAgregarTipoMaquina.Click += new System.EventHandler(this.btnAgregarTipoMaquina_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(12, 88);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(133, 19);
            this.materialLabel5.TabIndex = 27;
            this.materialLabel5.Text = "Tipos de máquina:";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(12, 365);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(76, 19);
            this.materialLabel6.TabIndex = 28;
            this.materialLabel6.Text = "Máquinas:";
            // 
            // chartUsoMaq
            // 
            this.chartUsoMaq.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AlignmentOrientation = FastReport.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            chartArea1.Name = "ChartArea1";
            this.chartUsoMaq.ChartAreas.Add(chartArea1);
            this.chartUsoMaq.Location = new System.Drawing.Point(9, 7);
            this.chartUsoMaq.Name = "chartUsoMaq";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = FastReport.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Name = "UsoMaq";
            this.chartUsoMaq.Series.Add(series1);
            this.chartUsoMaq.Size = new System.Drawing.Size(319, 251);
            this.chartUsoMaq.TabIndex = 29;
            this.chartUsoMaq.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Uso de máquinas";
            this.chartUsoMaq.Titles.Add(title1);
            // 
            // dtpMaquinaDesde
            // 
            this.dtpMaquinaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMaquinaDesde.Location = new System.Drawing.Point(349, 58);
            this.dtpMaquinaDesde.Name = "dtpMaquinaDesde";
            this.dtpMaquinaDesde.Size = new System.Drawing.Size(104, 23);
            this.dtpMaquinaDesde.TabIndex = 30;
            this.dtpMaquinaDesde.ValueChanged += new System.EventHandler(this.dtpMaquinaDesde_ValueChanged);
            // 
            // dtpMaquinaHasta
            // 
            this.dtpMaquinaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMaquinaHasta.Location = new System.Drawing.Point(349, 106);
            this.dtpMaquinaHasta.Name = "dtpMaquinaHasta";
            this.dtpMaquinaHasta.Size = new System.Drawing.Size(104, 23);
            this.dtpMaquinaHasta.TabIndex = 31;
            this.dtpMaquinaHasta.ValueChanged += new System.EventHandler(this.dtpMaquinaHasta_ValueChanged);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(349, 36);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(94, 19);
            this.materialLabel7.TabIndex = 32;
            this.materialLabel7.Text = "Fecha desde:";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(349, 84);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(47, 19);
            this.materialLabel8.TabIndex = 33;
            this.materialLabel8.Text = "Hasta:";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dtpMaquinaDesde);
            this.materialCard2.Controls.Add(this.chartUsoMaq);
            this.materialCard2.Controls.Add(this.materialLabel8);
            this.materialCard2.Controls.Add(this.dtpMaquinaHasta);
            this.materialCard2.Controls.Add(this.materialLabel7);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(386, 96);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(507, 266);
            this.materialCard2.TabIndex = 34;
            // 
            // Maquinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 727);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.btnEditarTipoMaquina);
            this.Controls.Add(this.btnEliminarTipoMaquina);
            this.Controls.Add(this.btnAgregarMaquina);
            this.Controls.Add(this.btnAgregarTipoMaquina);
            this.Controls.Add(this.listTiposMaquina);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.btnEditarMantenimiento);
            this.Controls.Add(this.btnEliminarMantenimiento);
            this.Controls.Add(this.btnAgregarMantenimiento);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.listMantenimientos);
            this.Controls.Add(this.btnEditarMaquina);
            this.Controls.Add(this.btnEliminarMaquina);
            this.Controls.Add(this.listMaquinas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Maquinas";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Máquinas";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsoMaq)).EndInit();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listMaquinas;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnDescripcion;
        private MaterialSkin.Controls.MaterialButton btnEditarMaquina;
        private MaterialSkin.Controls.MaterialButton btnEliminarMaquina;
        private MaterialSkin.Controls.MaterialButton btnAgregarMaquina;
        private MaterialSkin.Controls.MaterialListView listMantenimientos;
        private System.Windows.Forms.ColumnHeader columnFechaRealizacion;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ColumnHeader columnDescripcion2;
        private System.Windows.Forms.ColumnHeader columnCosto;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton btnEditarMantenimiento;
        private MaterialSkin.Controls.MaterialButton btnEliminarMantenimiento;
        private MaterialSkin.Controls.MaterialButton btnAgregarMantenimiento;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton btnCerrar;
        private MaterialSkin.Controls.MaterialLabel lblMantenimientosRealizados;
        private MaterialSkin.Controls.MaterialLabel lblOrdenesAtendidas;
        private MaterialSkin.Controls.MaterialListView listTiposMaquina;
        private System.Windows.Forms.ColumnHeader columnIdTpm;
        private System.Windows.Forms.ColumnHeader columnDescripcionTpm;
        private MaterialSkin.Controls.MaterialButton btnEditarTipoMaquina;
        private MaterialSkin.Controls.MaterialButton btnEliminarTipoMaquina;
        private MaterialSkin.Controls.MaterialButton btnAgregarTipoMaquina;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private FastReport.DataVisualization.Charting.Chart chartUsoMaq;
        private System.Windows.Forms.DateTimePicker dtpMaquinaDesde;
        private System.Windows.Forms.DateTimePicker dtpMaquinaHasta;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel lblEstadisticas;
    }
}