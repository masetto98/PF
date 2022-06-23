﻿
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
            this.btnDetalles = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lblMantenimientosRealizados = new MaterialSkin.Controls.MaterialLabel();
            this.lblOrdenesAtendidas = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnEditarMantenimiento = new MaterialSkin.Controls.MaterialButton();
            this.btnEliminarMantenimiento = new MaterialSkin.Controls.MaterialButton();
            this.btnAgregarMantenimiento = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCerrar = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
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
            this.listMaquinas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listMaquinas.FullRowSelect = true;
            this.listMaquinas.HideSelection = false;
            this.listMaquinas.Location = new System.Drawing.Point(19, 140);
            this.listMaquinas.MinimumSize = new System.Drawing.Size(200, 100);
            this.listMaquinas.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listMaquinas.MouseState = MaterialSkin.MouseState.OUT;
            this.listMaquinas.Name = "listMaquinas";
            this.listMaquinas.OwnerDraw = true;
            this.listMaquinas.Size = new System.Drawing.Size(359, 391);
            this.listMaquinas.TabIndex = 0;
            this.listMaquinas.UseCompatibleStateImageBehavior = false;
            this.listMaquinas.View = System.Windows.Forms.View.Details;
            this.listMaquinas.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listMaquinas_ColumnWidthChanging);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 70;
            // 
            // columnDescripcion
            // 
            this.columnDescripcion.Text = "Descripción";
            this.columnDescripcion.Width = 289;
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
            this.btnEditarMaquina.Location = new System.Drawing.Point(142, 86);
            this.btnEditarMaquina.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditarMaquina.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarMaquina.Name = "btnEditarMaquina";
            this.btnEditarMaquina.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditarMaquina.Size = new System.Drawing.Size(114, 51);
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
            this.btnEliminarMaquina.Location = new System.Drawing.Point(264, 86);
            this.btnEliminarMaquina.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarMaquina.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarMaquina.Name = "btnEliminarMaquina";
            this.btnEliminarMaquina.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminarMaquina.Size = new System.Drawing.Size(114, 51);
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
            this.btnAgregarMaquina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAgregarMaquina.HighEmphasis = true;
            this.btnAgregarMaquina.Icon = global::UI.Desktop.Properties.Resources.plus_icon_icons_com_70890;
            this.btnAgregarMaquina.Location = new System.Drawing.Point(20, 86);
            this.btnAgregarMaquina.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarMaquina.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarMaquina.Name = "btnAgregarMaquina";
            this.btnAgregarMaquina.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarMaquina.Size = new System.Drawing.Size(114, 51);
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
            this.listMantenimientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listMantenimientos.FullRowSelect = true;
            this.listMantenimientos.HideSelection = false;
            this.listMantenimientos.Location = new System.Drawing.Point(385, 322);
            this.listMantenimientos.MinimumSize = new System.Drawing.Size(200, 100);
            this.listMantenimientos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listMantenimientos.MouseState = MaterialSkin.MouseState.OUT;
            this.listMantenimientos.Name = "listMantenimientos";
            this.listMantenimientos.OwnerDraw = true;
            this.listMantenimientos.Size = new System.Drawing.Size(502, 209);
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
            this.columnCosto.Width = 92;
            // 
            // btnDetalles
            // 
            this.btnDetalles.AutoSize = false;
            this.btnDetalles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDetalles.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDetalles.Depth = 0;
            this.btnDetalles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDetalles.HighEmphasis = true;
            this.btnDetalles.Icon = global::UI.Desktop.Properties.Resources.document_3530;
            this.btnDetalles.Location = new System.Drawing.Point(385, 140);
            this.btnDetalles.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDetalles.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDetalles.Size = new System.Drawing.Size(114, 51);
            this.btnDetalles.TabIndex = 16;
            this.btnDetalles.Text = "Detalles";
            this.btnDetalles.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDetalles.UseAccentColor = false;
            this.btnDetalles.UseVisualStyleBackColor = false;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblMantenimientosRealizados);
            this.materialCard1.Controls.Add(this.lblOrdenesAtendidas);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(507, 94);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(501, 185);
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
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(9, 9);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(91, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Estadisticas:";
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
            this.btnEditarMantenimiento.Location = new System.Drawing.Point(894, 385);
            this.btnEditarMantenimiento.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditarMantenimiento.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarMantenimiento.Name = "btnEditarMantenimiento";
            this.btnEditarMantenimiento.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditarMantenimiento.Size = new System.Drawing.Size(114, 51);
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
            this.btnEliminarMantenimiento.Location = new System.Drawing.Point(894, 448);
            this.btnEliminarMantenimiento.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarMantenimiento.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarMantenimiento.Name = "btnEliminarMantenimiento";
            this.btnEliminarMantenimiento.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEliminarMantenimiento.Size = new System.Drawing.Size(114, 51);
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
            this.btnAgregarMantenimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAgregarMantenimiento.HighEmphasis = true;
            this.btnAgregarMantenimiento.Icon = global::UI.Desktop.Properties.Resources.plus_icon_icons_com_70890;
            this.btnAgregarMantenimiento.Location = new System.Drawing.Point(894, 322);
            this.btnAgregarMantenimiento.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarMantenimiento.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarMantenimiento.Name = "btnAgregarMantenimiento";
            this.btnAgregarMantenimiento.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarMantenimiento.Size = new System.Drawing.Size(114, 51);
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
            this.materialLabel4.Location = new System.Drawing.Point(385, 300);
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
            this.btnCerrar.Location = new System.Drawing.Point(931, 540);
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
            // Maquinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 600);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.btnEditarMantenimiento);
            this.Controls.Add(this.btnEliminarMantenimiento);
            this.Controls.Add(this.btnAgregarMantenimiento);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.listMantenimientos);
            this.Controls.Add(this.btnEditarMaquina);
            this.Controls.Add(this.btnEliminarMaquina);
            this.Controls.Add(this.btnAgregarMaquina);
            this.Controls.Add(this.listMaquinas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Maquinas";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maquinas";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
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
        private MaterialSkin.Controls.MaterialButton btnDetalles;
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
    }
}