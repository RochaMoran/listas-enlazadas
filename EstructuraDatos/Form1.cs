using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDatos
{
    public partial class Form1 : Form
    {
        string id, nombre;
        int cantidad;
        double precio, total;
        string x;
        Lista list = new Lista();
        Nodo n = new Nodo();

        public Form1()
        {
            InitializeComponent();
            gpbDatos.Visible = false;
            btnInsertarInicio.Visible = false;
            gpbReferences.Visible = false;
            btnEliminarFInal.Visible = false;
            dgv.Visible = false;
        }

        #region MenuScript Validaciones
        private void insertarAlInicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnInsertarInicio.Visible = true;
            btnEliminarDespuesX.Visible = false;
            gpbDatos.Visible = true;
            btnEliminarX.Visible = false;
            btnInsertarAntesX.Visible = false;
            btnInsertarDespuesX.Visible = false;
            btnInsertarFinal.Visible = false;
            btnInsertarInicio.Visible = true;
            gpbReferences.Visible = true;
            gpbReferences.Enabled = false;
            btnInsertarInicio.Enabled = true;
            gpbDatos.Enabled = true;
            eliminarToolStripMenuItem.Enabled = true;
            recorridosToolStripMenuItem.Enabled = true;
            busquedaToolStripMenuItem.Enabled = true;
            btnBusquedaRecursiva.Visible = false;
            btnRecorridoIterativo.Visible = false;
            btnBusquedaOrdenada.Visible = false;
            btnBusqudaDesordenada.Visible = false;
            btnBusquedaAvanzada.Visible = false;
            btnEliminarFInal.Visible = false;
            dgv.Visible = true;
        }

        private void insertarAlFinalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            btnEliminarDespuesX.Visible = false;
            gpbDatos.Visible = true;
            btnEliminarX.Visible = false;
            btnInsertarAntesX.Visible = false;
            btnInsertarDespuesX.Visible = false;
            btnInsertarFinal.Visible = true;
            btnInsertarInicio.Visible = false;
            gpbReferences.Visible = true;
            gpbReferences.Enabled = false;
            btnInsertarInicio.Enabled = true;
            gpbDatos.Enabled = true;
            eliminarToolStripMenuItem.Enabled = true;
            recorridosToolStripMenuItem.Enabled = true;
            busquedaToolStripMenuItem.Enabled = true;
            btnBusquedaRecursiva.Visible = false;
            btnRecorridoIterativo.Visible = false;
            btnBusquedaOrdenada.Visible = false;
            btnBusqudaDesordenada.Visible = false;
            btnBusquedaAvanzada.Visible = false;
            btnEliminarFInal.Visible = false;
            dgv.Visible = true;
        }

        private void insertarAntesDeXToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            btnEliminarDespuesX.Visible = false;
            btnEliminarX.Visible = false;
            btnInsertarAntesX.Visible = false;
            btnInsertarDespuesX.Visible = false;
            btnInsertarFinal.Visible = false;
            btnInsertarInicio.Visible = false;
            btnInsertarAntesX.Visible = true;
            gpbReferences.Visible = true;
            gpbReferences.Enabled = true;
            btnInsertarInicio.Enabled = true;
            gpbDatos.Enabled = true;
            eliminarToolStripMenuItem.Enabled = true;
            recorridosToolStripMenuItem.Enabled = true;
            busquedaToolStripMenuItem.Enabled = true;
            btnBusquedaRecursiva.Visible = false;
            btnRecorridoIterativo.Visible = false;
            btnBusquedaOrdenada.Visible = false;
            btnBusqudaDesordenada.Visible = false;
            btnBusquedaAvanzada.Visible = false;
            btnEliminarFInal.Visible = false;
            dgv.Visible = true;
        }

        private void insertarDespuesDeCToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            btnEliminarDespuesX.Visible = false;
            btnEliminarX.Visible = false;
            btnInsertarAntesX.Visible = false;
            btnInsertarFinal.Visible = false;
            btnInsertarInicio.Visible = false;
            btnInsertarAntesX.Visible = false;
            btnInsertarDespuesX.Visible = true;
            gpbReferences.Visible = true;
            gpbReferences.Enabled = true;
            btnInsertarInicio.Enabled = true;
            gpbDatos.Enabled = true;
            eliminarToolStripMenuItem.Enabled = true;
            recorridosToolStripMenuItem.Enabled = true;
            busquedaToolStripMenuItem.Enabled = true;
            btnBusquedaRecursiva.Visible = false;
            btnRecorridoIterativo.Visible = false;
            btnBusquedaOrdenada.Visible = false;
            btnBusqudaDesordenada.Visible = false;
            btnBusquedaAvanzada.Visible = false;
            btnEliminarFInal.Visible = false;
            dgv.Visible = true;
        }

        private void eliminarAlInicioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            btnEliminarDespuesX.Visible = false;
            btnEliminarX.Visible = false;
            btnInsertarAntesX.Visible = false;
            btnInsertarDespuesX.Visible = false;
            btnInsertarFinal.Visible = false;
            btnInsertarInicio.Visible = true;
            btnInsertarInicio.Enabled = false;
            gpbReferences.Enabled = false;
            gpbDatos.Enabled = false;
            btnEliminarInicio.Visible = true;
            btnBusquedaRecursiva.Visible = false;
            btnRecorridoIterativo.Visible = false;
            btnBusquedaOrdenada.Visible = false;
            btnBusqudaDesordenada.Visible = false;
            btnBusquedaAvanzada.Visible = false;
            btnEliminarFInal.Visible = false;
        }

        private void eliminarAlFinalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            btnEliminarDespuesX.Visible = false;
            btnEliminarFInal.Visible = true;
            btnEliminarX.Visible = false;
            btnInsertarAntesX.Visible = false;
            btnInsertarDespuesX.Visible = false;
            btnInsertarFinal.Visible = false;
            btnInsertarInicio.Visible = true;
            gpbReferences.Enabled = false;
            btnInsertarInicio.Enabled = false;
            gpbDatos.Enabled = false;
            btnEliminarInicio.Visible = false;
            btnBusquedaRecursiva.Visible = false;
            btnRecorridoIterativo.Visible = false;
            btnBusquedaOrdenada.Visible = false;
            btnBusqudaDesordenada.Visible = false;
            btnBusquedaAvanzada.Visible = false;

        }

        private void eliminarXToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            btnEliminarDespuesX.Visible = false;
            gpbReferences.Visible = true;
            btnEliminarX.Visible = true;
            btnInsertarAntesX.Visible = false;
            btnInsertarDespuesX.Visible = false;
            btnInsertarFinal.Visible = false;
            btnInsertarInicio.Visible = true;
            gpbReferences.Enabled = true;
            btnInsertarInicio.Enabled = false;
            gpbDatos.Enabled = false;
            btnEliminarInicio.Visible = false;
            btnBusquedaRecursiva.Visible = false;
            btnRecorridoIterativo.Visible = false;
            btnBusquedaOrdenada.Visible = false;
            btnBusqudaDesordenada.Visible = false;
            btnBusquedaAvanzada.Visible = false;
            btnEliminarFInal.Visible = false;
        }

        private void eliminarAntesDeXToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            btnEliminarDespuesX.Visible = false;
            gpbReferences.Visible = true;
            btnEliminarX.Visible = false;
            btnInsertarAntesX.Visible = false;
            btnInsertarDespuesX.Visible = false;
            btnInsertarFinal.Visible = false;
            btnInsertarInicio.Visible = true;
            gpbReferences.Enabled = true;
            btnInsertarInicio.Enabled = false;
            gpbDatos.Enabled = false;
            btnEliminarInicio.Visible = false;
            btnEliminarDespuesX.Visible = false;
            btnEliminarAntesX.Visible = true;
            btnBusquedaRecursiva.Visible = false;
            btnRecorridoIterativo.Visible = false;
            btnBusquedaOrdenada.Visible = false;
            btnBusqudaDesordenada.Visible = false;
            btnBusquedaAvanzada.Visible = false;
            btnEliminarFInal.Visible = false;
        }

        private void eliminarDespuesDeXToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            gpbReferences.Visible = true;
            btnEliminarX.Visible = false;
            btnInsertarAntesX.Visible = false;
            btnInsertarDespuesX.Visible = false;
            btnInsertarFinal.Visible = false;
            btnInsertarInicio.Visible = true;
            gpbReferences.Enabled = true;
            btnInsertarInicio.Enabled = false;
            gpbDatos.Enabled = false;
            btnEliminarInicio.Visible = false;
            btnEliminarDespuesX.Visible = true;
            btnEliminarAntesX.Visible = false;
            btnBusquedaRecursiva.Visible = false;
            btnRecorridoIterativo.Visible = false;
            btnBusquedaOrdenada.Visible = false;
            btnBusqudaDesordenada.Visible = false;
            btnBusquedaAvanzada.Visible = false;
            btnEliminarFInal.Visible = false;
        }

        private void busquedaOrdenadaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            btnEliminarDespuesX.Visible = false;
            gpbReferences.Visible = true;
            btnEliminarX.Visible = false;
            btnInsertarAntesX.Visible = false;
            btnInsertarDespuesX.Visible = false;
            btnInsertarFinal.Visible = false;
            btnInsertarInicio.Visible = true;
            gpbReferences.Enabled = true;
            btnInsertarInicio.Enabled = false;
            gpbDatos.Enabled = false;
            btnEliminarInicio.Visible = false;
            btnEliminarDespuesX.Visible = false;
            btnEliminarAntesX.Visible = false;
            btnBusquedaRecursiva.Visible = false;
            btnRecorridoIterativo.Visible = false;
            btnBusquedaOrdenada.Visible = true;
            btnBusquedaAvanzada.Visible = false;
            btnBusqudaDesordenada.Visible = false;
            btnEliminarFInal.Visible = false;
        }

        private void busquedaDesordenadaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            btnEliminarDespuesX.Visible = false;
            gpbReferences.Visible = true;
            btnEliminarX.Visible = false;
            btnInsertarAntesX.Visible = false;
            btnInsertarDespuesX.Visible = false;
            btnInsertarFinal.Visible = false;
            btnInsertarInicio.Visible = true;
            gpbReferences.Enabled = true;
            btnInsertarInicio.Enabled = false;
            gpbDatos.Enabled = false;
            btnEliminarInicio.Visible = false;
            btnEliminarDespuesX.Visible = false;
            btnEliminarAntesX.Visible = false;
            btnBusquedaRecursiva.Visible = false;
            btnRecorridoIterativo.Visible = false;
            btnBusquedaAvanzada.Visible = false;
            btnBusquedaOrdenada.Visible = false;
            btnEliminarFInal.Visible = false;
            btnBusqudaDesordenada.Visible = true;
        }

        private void busquedaRecursivaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            btnEliminarDespuesX.Visible = false;
            gpbReferences.Visible = true;
            btnEliminarX.Visible = false;
            btnInsertarAntesX.Visible = false;
            btnInsertarDespuesX.Visible = false;
            btnInsertarFinal.Visible = false;
            btnInsertarInicio.Visible = true;
            gpbReferences.Enabled = true;
            btnInsertarInicio.Enabled = false;
            gpbDatos.Enabled = false;
            btnEliminarInicio.Visible = false;
            btnEliminarDespuesX.Visible = false;
            btnEliminarAntesX.Visible = false;
            btnBusquedaRecursiva.Visible = true;
            btnBusquedaAvanzada.Visible = false;
            btnRecorridoIterativo.Visible = false;
            btnBusquedaOrdenada.Visible = false;
            btnBusqudaDesordenada.Visible = false;
            btnEliminarFInal.Visible = false;
        }

        private void btnInsertarInicio_Click_1(object sender, EventArgs e)
        {
            nombre = txtNombreProducto.Text;
            id = txtIdProducto.Text;
            cantidad = Convert.ToInt32(txtCantidad.Text);
            precio = Convert.ToDouble(txtPrecio.Text);
            total = Convert.ToDouble(precio * cantidad);
            list.InsertarInicio(id, nombre, cantidad, total, dgv);
            list.Mostrar(dgv);
        }

        private void btnInsertarFinal_Click_1(object sender, EventArgs e)
        {
            nombre = txtNombreProducto.Text;
            id = txtIdProducto.Text;
            cantidad = Convert.ToInt32(txtCantidad.Text);
            precio = Convert.ToDouble(txtPrecio.Text);
            total = Convert.ToDouble(precio * cantidad);
            // x = int.Parse(txtReferences.Text);
            list.InsertarFinal(id, nombre, cantidad, total, dgv);
            list.Mostrar(dgv);
        }

        private void btnRecorridoIterativo_Click(object sender, EventArgs e)
        {
            list.RecorridoIterativo(dgv);
        }

        private void btnEliminarInicio_Click(object sender, EventArgs e)
        {
            list.EliminarInicio();
            list.Mostrar(dgv);
        }

        private void btnEliminarX_Click(object sender, EventArgs e)
        {
            x = txtReferencia.Text;
            list.EliminarX(x);
            list.Mostrar(dgv);
        }

        private void btnEliminarDespuesX_Click(object sender, EventArgs e)
        {
            x = txtReferencia.Text;
            list.EliminarDespuesX(x);
            list.Mostrar(dgv);
        }

        private void btnEliminarAntesX_Click(object sender, EventArgs e)
        {
            x = txtReferencia.Text;
            list.EliminarAntesX(x);
            list.Mostrar(dgv);
        }

        private void btnInsertarAntesX_Click(object sender, EventArgs e)
        {
            nombre = txtNombreProducto.Text;
            id = txtIdProducto.Text;
            cantidad = Convert.ToInt32(txtCantidad.Text);
            precio = Convert.ToDouble(txtPrecio.Text);
            total = Convert.ToDouble(precio * cantidad);
            x = txtReferencia.Text;
            list.InsertarAntesX(id, nombre, cantidad, total, x);
            list.Mostrar(dgv);
        }

        private void btnInsertarDespuesX_Click(object sender, EventArgs e)
        {
            nombre = txtNombreProducto.Text;
            id = txtIdProducto.Text;
            cantidad = Convert.ToInt32(txtCantidad.Text);
            precio = Convert.ToDouble(txtPrecio.Text);
            total = Convert.ToDouble(precio * cantidad);
            x = txtReferencia.Text;
            list.InsertarDespuesX(id, nombre, cantidad, total, x);
            list.Mostrar(dgv);
        }

        private void btnBusquedaRecursiva_Click(object sender, EventArgs e)
        {
            x = txtReferencia.Text;
            list.BusquedaRecursiva(list.primero, x);          
        }

        private void btnRecorridoRecursivo_Click(object sender, EventArgs e)
        {
            list.RecorridoRecursivo(list.primero);
        }

        private void btnBusqudaDesordenada_Click(object sender, EventArgs e)
        {
            x = txtReferencia.Text;
            list.BusquedaDesordenada(x);
        }

        private void btnBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            x = txtReferencia.Text;
          //  list.BusquedaAvanzada(x);
        }

        private void busquedaAvanzadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEliminarDespuesX.Visible = false;
            gpbReferences.Visible = true;
            btnEliminarX.Visible = false;
            btnInsertarAntesX.Visible = false;
            btnInsertarDespuesX.Visible = false;
            btnInsertarFinal.Visible = false;
            btnInsertarInicio.Visible = true;
            gpbReferences.Enabled = true;
            btnInsertarInicio.Enabled = false;
            gpbDatos.Enabled = false;
            btnEliminarInicio.Visible = false;
            btnEliminarDespuesX.Visible = false;
            btnEliminarAntesX.Visible = false;
            btnBusquedaRecursiva.Visible = false;
            btnBusquedaAvanzada.Visible = true;
            btnRecorridoIterativo.Visible = false;
            btnBusquedaOrdenada.Visible = false;
            btnBusqudaDesordenada.Visible = false;
        }

        private void btnBusquedaOrdenada_Click(object sender, EventArgs e)
        {
            x = txtReferencia.Text;
            list.BusquedaOrdenada(x);
        }

        private void btnEliminarFInal_Click(object sender, EventArgs e)
        {
            list.EliminarFinal();
            list.Mostrar(dgv);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void recorridoRecursivoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            btnEliminarDespuesX.Visible = false;
            gpbReferences.Visible = true;
            btnEliminarX.Visible = false;
            btnInsertarAntesX.Visible = false;
            btnInsertarDespuesX.Visible = false;
            btnInsertarFinal.Visible = false;
            btnInsertarInicio.Visible = true;
            gpbReferences.Enabled = false;
            btnInsertarInicio.Enabled = false;
            gpbDatos.Enabled = false;
            btnEliminarInicio.Visible = false;
            btnEliminarDespuesX.Visible = false;
            btnEliminarAntesX.Visible = false;
            btnBusquedaRecursiva.Visible = false;
            btnRecorridoIterativo.Visible = false;
            btnBusquedaOrdenada.Visible = false;
            btnBusqudaDesordenada.Visible = false;
            btnRecorridoRecursivo.Visible = true;
        }

        private void recorridoIterativoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            btnEliminarDespuesX.Visible = false;
            gpbReferences.Visible = true;
            btnEliminarX.Visible = false;
            btnInsertarAntesX.Visible = false;
            btnInsertarDespuesX.Visible = false;
            btnInsertarFinal.Visible = false;
            btnInsertarInicio.Visible = true;
            gpbReferences.Enabled = false;
            btnInsertarInicio.Enabled = false;
            gpbDatos.Enabled = false;
            btnEliminarInicio.Visible = false;
            btnEliminarDespuesX.Visible = false;
            btnEliminarAntesX.Visible = false;
            btnBusquedaRecursiva.Visible = false;
            btnRecorridoIterativo.Visible = true;
            btnBusquedaOrdenada.Visible = false;
            btnBusqudaDesordenada.Visible = false;
            btnRecorridoRecursivo.Visible = false;
        }

        #endregion


    }
}
