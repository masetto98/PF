
namespace UI.Desktop
{
    partial class ClienteOrdenDesktop
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
            this.listOrdenesCliente = new MaterialSkin.Controls.MaterialListView();
            this.columnNroOrden = new System.Windows.Forms.ColumnHeader();
            this.columnEstadoOrden = new System.Windows.Forms.ColumnHeader();
            this.columnFechaEntrada = new System.Windows.Forms.ColumnHeader();
            this.columnFechaSalida = new System.Windows.Forms.ColumnHeader();
            this.columnTiempoFinalizacion = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // listOrdenesCliente
            // 
            this.listOrdenesCliente.AutoSizeTable = false;
            this.listOrdenesCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listOrdenesCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listOrdenesCliente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNroOrden,
            this.columnEstadoOrden,
            this.columnFechaEntrada,
            this.columnFechaSalida,
            this.columnTiempoFinalizacion});
            this.listOrdenesCliente.Depth = 0;
            this.listOrdenesCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listOrdenesCliente.FullRowSelect = true;
            this.listOrdenesCliente.HideSelection = false;
            this.listOrdenesCliente.Location = new System.Drawing.Point(90, 116);
            this.listOrdenesCliente.MinimumSize = new System.Drawing.Size(200, 100);
            this.listOrdenesCliente.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listOrdenesCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.listOrdenesCliente.Name = "listOrdenesCliente";
            this.listOrdenesCliente.OwnerDraw = true;
            this.listOrdenesCliente.Size = new System.Drawing.Size(772, 351);
            this.listOrdenesCliente.TabIndex = 0;
            this.listOrdenesCliente.UseCompatibleStateImageBehavior = false;
            this.listOrdenesCliente.View = System.Windows.Forms.View.Details;
            // 
            // columnNroOrden
            // 
            this.columnNroOrden.Text = "Nro Orden";
            this.columnNroOrden.Width = 120;
            // 
            // columnEstadoOrden
            // 
            this.columnEstadoOrden.Text = "Estado";
            this.columnEstadoOrden.Width = 150;
            // 
            // columnFechaEntrada
            // 
            this.columnFechaEntrada.Text = "Fecha de Entrada";
            this.columnFechaEntrada.Width = 210;
            // 
            // columnFechaSalida
            // 
            this.columnFechaSalida.Text = "Fecha de Salida";
            this.columnFechaSalida.Width = 210;
            // 
            // columnTiempoFinalizacion
            // 
            this.columnTiempoFinalizacion.Text = "Tiempo de Finalización";
            this.columnTiempoFinalizacion.Width = 230;
            // 
            // ClienteOrdenDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 552);
            this.Controls.Add(this.listOrdenesCliente);
            this.Name = "ClienteOrdenDesktop";
            this.Text = "";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listOrdenesCliente;
        private System.Windows.Forms.ColumnHeader columnNroOrden;
        private System.Windows.Forms.ColumnHeader columnEstadoOrden;
        private System.Windows.Forms.ColumnHeader columnFechaEntrada;
        private System.Windows.Forms.ColumnHeader columnFechaSalida;
        private System.Windows.Forms.ColumnHeader columnTiempoFinalizacion;
    }
}