﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;
using Data.Database;

namespace UI.Desktop
{
    public partial class Maquinas : ApplicationForm
    {
        private readonly MaquinaLogic _maquinaLogic;
        private readonly MaquinaOrdenServicioTipoPrendaLogic _itemServidos;
        private readonly TiposMaquinaLogic _tiposMaquinaLogic;
        private readonly LavanderiaContext _context;
        public TiposMaquina tipoMaqActual;

        public Maquina MaquinaActual { get; set; }

        public Maquinas(LavanderiaContext context)
        {
            InitializeComponent();
            _context = context;
            _maquinaLogic = new MaquinaLogic(new MaquinaAdapter(context));
            _tiposMaquinaLogic = new TiposMaquinaLogic(new TiposMaquinaAdapter(context));
            _itemServidos = new MaquinaOrdenServicioTipoPrendaLogic(new MaquinaOrdenServicioTipoPrendaAdapter(context));
            //ListarMaquinas();
            ListarTiposMaquinas();
            CargarSerieGrafico();
        }

        private void ListarTiposMaquinas() 
        {
            listTiposMaquina.Items.Clear();
            List<TiposMaquina> tiposMaquinas = _tiposMaquinaLogic.GetAll();
            if (tiposMaquinas is not null)
            {
                foreach (TiposMaquina m in tiposMaquinas)
                {
                    ListViewItem item = new ListViewItem(m.IdTipoMaquina.ToString());
                    item.SubItems.Add(m.Descripcion);
                    listTiposMaquina.Items.Add(item);
                }
            }
        }
        private double CalcularUsoMaquina(Maquina m)
        {
            List<MaquinaOrdenServicioTipoPrenda> itemsServidos = _itemServidos.GetAll().FindAll(
                delegate (MaquinaOrdenServicioTipoPrenda items) { return items.Maquina == m; });
            if(itemsServidos is not null)
            {
                return itemsServidos.Count;
            }
            else
            {
                return 0;
            }
        }
        private double CalcularTotalTipoMaq(TiposMaquina tm)
        {
            double cantAtendidosTotal = 0;
            foreach(Maquina m in tm.Maquinas)
            {
                cantAtendidosTotal += m.itemsAtendidos.Count;
            }
            return cantAtendidosTotal;
        }
        private void CargarSerieGrafico()
        {
            
            double cantAtendidosTotal = 0;
            double cantAtendidosxMaq = 0;
            List<TiposMaquina> tiposMaq = _tiposMaquinaLogic.GetAll();
            tipoMaqActual = tiposMaq[0];
            foreach(TiposMaquina tm in tiposMaq)
            {
                if(tipoMaqActual != tm)
                {
                    cantAtendidosTotal = CalcularTotalTipoMaq(tm);
                    foreach (Maquina m in tm.Maquinas)
                    {
                        cantAtendidosxMaq = CalcularUsoMaquina(m);
                        double mostrar = Math.Round((cantAtendidosxMaq / cantAtendidosTotal) * 100, 2);
                        chartUsoMaq.Series["Series1"].Points.AddXY(m.Descripcion + "\n" + mostrar.ToString() + "%", cantAtendidosxMaq / cantAtendidosTotal);
                        
                        
                    }
                }
                else
                {
                    cantAtendidosTotal = CalcularTotalTipoMaq(tm);
                    foreach (Maquina m in tm.Maquinas)
                    {
                        cantAtendidosxMaq = CalcularUsoMaquina(m);
                        double mostrar = Math.Round((cantAtendidosxMaq / cantAtendidosTotal)*100,2);

                        chartUsoMaq.Series["UsoMaq"].Points.AddXY(m.Descripcion + "\n" + mostrar.ToString()+"%", cantAtendidosxMaq / cantAtendidosTotal);
                    }
                }
               
            }

        }
        private void listTiposMaquina_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarMaquinas();
        }

        private void listMaquinas_SelectedIndexChanged(object sender, EventArgs e)
        {
            listMantenimientos.Items.Clear();
            if (listMaquinas.SelectedItems.Count > 0)
            {
                int idMaquina = Int32.Parse(listMaquinas.SelectedItems[0].Text);
                MaquinaActual = _maquinaLogic.GetOne(idMaquina);
                if (MaquinaActual.itemsAtendidos is not null)
                {
                    this.lblOrdenesAtendidas.Text = MaquinaActual.itemsAtendidos.Count.ToString();
                }
                if (MaquinaActual.Mantenimientos is not null)
                {
                    this.lblMantenimientosRealizados.Text = MaquinaActual.Mantenimientos.Count.ToString();

                }

            }
            //else
            //{
            //    MessageBox.Show("Debe seleccionar una fila en la lista para poder observar los detalles", "Máquina Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            ListarMantenimientos();

        }
        /*
        private void ListarMaquinas() 
        {
            listMaquinas.Items.Clear();
            List<Maquina> maquinas = _maquinaLogic.GetAll();
            if (maquinas is not null) 
            {
                foreach (Maquina m in maquinas) 
                {
                    ListViewItem item = new ListViewItem(m.IdMaquina.ToString());
                    item.SubItems.Add(m.Descripcion);
                    listMaquinas.Items.Add(item);
                }
            }
        }*/

        private void ListarMaquinas() 
        {
            listMaquinas.Items.Clear();
            if (listTiposMaquina.SelectedItems.Count > 0)
            {
                TiposMaquina tipoMaquinaActual = _tiposMaquinaLogic.GetOne(Int32.Parse(listTiposMaquina.SelectedItems[0].Text));
                if (tipoMaquinaActual is not null && tipoMaquinaActual.Maquinas is not null)
                {
                    foreach (Maquina m in tipoMaquinaActual.Maquinas)
                    {
                        ListViewItem item = new ListViewItem(m.IdMaquina.ToString());
                        item.SubItems.Add(m.Descripcion);
                        listMaquinas.Items.Add(item);
                    }
                }
            }
        }

        private void btnAgregarMaquina_Click(object sender, EventArgs e)
        {
            MaquinaDesktop frmMaquinaDesktop = new MaquinaDesktop(ApplicationForm.ModoForm.Alta, _context);
            frmMaquinaDesktop.ShowDialog();
            ListarMaquinas();
        }

        private void btnEditarMaquina_Click(object sender, EventArgs e)
        {
            if (listMaquinas.SelectedItems.Count > 0) 
            {
                int idMaquina = Int32.Parse(listMaquinas.SelectedItems[0].Text);
                MaquinaDesktop frmMaquinaDesktop = new MaquinaDesktop(idMaquina,ApplicationForm.ModoForm.Modificacion, _context);
                frmMaquinaDesktop.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila en la lista para poder editar", "Máquina", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListarMaquinas();
        }

        private void btnEliminarMaquina_Click(object sender, EventArgs e)
        {
            if (listMaquinas.SelectedItems.Count > 0)
            {
                int idMaquina = Int32.Parse(listMaquinas.SelectedItems[0].Text);
                MaquinaDesktop frmMaquinaDesktop = new MaquinaDesktop(idMaquina, ApplicationForm.ModoForm.Baja, _context);
                frmMaquinaDesktop.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila en la lista para poder eliminar", "Máquina", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListarMaquinas();

        }
        
        private void btnDetalles_Click(object sender, EventArgs e)
        {/*
            listMantenimientos.Items.Clear();
            if (listMaquinas.SelectedItems.Count > 0)
            {
                int idMaquina = Int32.Parse(listMaquinas.SelectedItems[0].Text);
                MaquinaActual = _maquinaLogic.GetOne(idMaquina);
                if (MaquinaActual.itemsAtendidos is not null) 
                {
                    this.lblOrdenesAtendidas.Text = MaquinaActual.itemsAtendidos.Count.ToString();
                }
                if (MaquinaActual.Mantenimientos is not null) 
                {
                    this.lblMantenimientosRealizados.Text = MaquinaActual.Mantenimientos.Count.ToString();
                    
                }
                
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila en la lista para poder observar los detalles", "Máquina Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListarMantenimientos();*/
        }

        public void ListarMantenimientos() 
        {
            listMantenimientos.Items.Clear();
            if (listMaquinas.SelectedItems.Count > 0)
            {
                int idMaquina = Int32.Parse(listMaquinas.SelectedItems[0].Text);
                MaquinaActual = _maquinaLogic.GetOne(idMaquina);
                if (MaquinaActual.Mantenimientos is not null)
                {
                    foreach (Mantenimiento ma in MaquinaActual.Mantenimientos)
                    {
                        ListViewItem item = new ListViewItem(ma.FechaRealizado.ToString("yyyy-MM-dd HH:mm:ss.fffffff"));
                        item.SubItems.Add(ma.Descripcion);
                        item.SubItems.Add(ma.Costo.ToString());
                        listMantenimientos.Items.Add(item);
                    }
                }
            }

        }

        private void btnAgregarMantenimiento_Click(object sender, EventArgs e)
        {
            if (listMaquinas.SelectedItems.Count > 0)
            {
                int idMaquina = Int32.Parse(listMaquinas.SelectedItems[0].Text);
                MantenimientoDesktop frmMantenimientoDesktop = new MantenimientoDesktop(idMaquina,ApplicationForm.ModoForm.Alta,_context);
                frmMantenimientoDesktop.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila en la lista de \"Máquinas\" para poder agregar un mantenimiento", "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListarMantenimientos();
        }

        private void btnEditarMantenimiento_Click(object sender, EventArgs e)
        {
            if (listMaquinas.SelectedItems.Count > 0)
            {
                if (listMantenimientos.SelectedItems.Count > 0)
                {
                    int idMaquina = Int32.Parse(listMaquinas.SelectedItems[0].Text);
                    DateTime fechaRealizacion = DateTime.Parse(listMantenimientos.SelectedItems[0].Text);
                    MantenimientoDesktop frmMantenimientoDesktop = new MantenimientoDesktop(idMaquina,fechaRealizacion, ApplicationForm.ModoForm.Modificacion, _context);
                    frmMantenimientoDesktop.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila en la lista para poder editar un mantenimiento", "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila en la lista de \"Máquinas\" para poder editar un mantenimiento", "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListarMantenimientos();

        }

        private void btnEliminarMantenimiento_Click(object sender, EventArgs e)
        {
            if (listMaquinas.SelectedItems.Count > 0)
            {
                if (listMantenimientos.SelectedItems.Count > 0)
                {
                    int idMaquina = Int32.Parse(listMaquinas.SelectedItems[0].Text);
                    DateTime fechaRealizacion = DateTime.Parse(listMantenimientos.SelectedItems[0].Text);
                    MantenimientoDesktop frmMantenimientoDesktop = new MantenimientoDesktop(idMaquina, fechaRealizacion, ApplicationForm.ModoForm.Baja, _context);
                    frmMantenimientoDesktop.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila en la lista para poder eliminar un mantenimiento", "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila en la lista de \"Máquinas\" para poder eliminar un mantenimiento", "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListarMantenimientos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listMaquinas_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listMaquinas.Columns[e.ColumnIndex].Width;
        }

        private void listMantenimientos_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listMantenimientos.Columns[e.ColumnIndex].Width;
        }

        private void listTiposMaquina_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listTiposMaquina.Columns[e.ColumnIndex].Width;
        }

        private void btnAgregarTipoMaquina_Click(object sender, EventArgs e)
        {
            TipoMaquinaDesktop frmTipoMaquinaDesktop = new TipoMaquinaDesktop(ApplicationForm.ModoForm.Alta, _context);
            frmTipoMaquinaDesktop.ShowDialog();
            ListarTiposMaquinas();
        }

        private void btnEditarTipoMaquina_Click(object sender, EventArgs e)
        {
            if (listTiposMaquina.SelectedItems.Count > 0)
            {
                int idTipoMaquina = Int32.Parse(listTiposMaquina.SelectedItems[0].Text);
                TipoMaquinaDesktop frmTipoMaquinaDesktop = new TipoMaquinaDesktop(idTipoMaquina, ApplicationForm.ModoForm.Modificacion, _context);
                frmTipoMaquinaDesktop.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila en la lista para poder editar", "Tipo de Máquina", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListarTiposMaquinas();
        }

        private void btnEliminarTipoMaquina_Click(object sender, EventArgs e)
        {
            if (listTiposMaquina.SelectedItems.Count > 0)
            {
                int idTipoMaquina = Int32.Parse(listTiposMaquina.SelectedItems[0].Text);
                TipoMaquinaDesktop frmTipoMaquinaDesktop = new TipoMaquinaDesktop(idTipoMaquina, ApplicationForm.ModoForm.Baja, _context);
                frmTipoMaquinaDesktop.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila en la lista para poder eliminar", "Tipo de Máquina", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListarTiposMaquinas();
        }
    }
}
