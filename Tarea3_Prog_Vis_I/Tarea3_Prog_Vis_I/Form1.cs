using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea3_Prog_Vis_I
{
    public partial class Form1 : Form
    {
        List<Tarea> listaTareas = new List<Tarea>();
        List<Tarea> listaAux = new List<Tarea>();
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != String.Empty)
            {
                txtDescripcion.Enabled = true;
            }
        }
        private void ActualizarGrid()
        {
            dgvTareas.DataSource = null;
            dgvTareas.DataSource = listaTareas;
        }
        void ActualizarGrid(List<Tarea> aux)
        {
            dgvTareas.DataSource = null;
            dgvTareas.DataSource = aux;
        }
        void limpCamp()
        {
            txtCodigo.Text = String.Empty;
            txtDescripcion.Text = String.Empty;
            txtLugar.Text = String.Empty;
            txtNombre.Text = String.Empty;
            dtpFecha.Value = DateTime.Now;
            cmbEstado.Text = String.Empty;
            txtDescripcion.Enabled = false;
            cmbEstado.Enabled = false;
            txtLugar.Enabled = false;
            txtNombre.Enabled = false;
            dtpFecha.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnAgregar.Enabled = false;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Tarea nueva = new Tarea()
            {
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Fecha = dtpFecha.Value,
                Lugar = txtLugar.Text,
                Estado = cmbEstado.SelectedItem.ToString()
            };

            listaTareas.Add(nueva);
            ActualizarGrid();
            MessageBox.Show("Tarea agregada correctamente.");
            btnEliminar.Enabled = true;
            btnEditar.Enabled = true;
            busDes(true);
            limpCamp();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == String.Empty)
            {
                btnEditar.Enabled = false;
                return;
            }
            if (dgvTareas.SelectedRows.Count > 0)
            {
                int index = dgvTareas.SelectedRows[0].Index;
                listaTareas[index].Codigo = txtCodigo.Text;
                listaTareas[index].Nombre = txtNombre.Text;
                listaTareas[index].Descripcion = txtDescripcion.Text;
                listaTareas[index].Fecha = dtpFecha.Value;
                listaTareas[index].Lugar = txtLugar.Text;
                listaTareas[index].Estado = cmbEstado.SelectedItem.ToString();

                ActualizarGrid();
                MessageBox.Show("Tarea editada correctamente.");
            }
            if (listaTareas.Count == 0)
            {
                btnEliminar.Enabled = false;
                btnEditar.Enabled = false;
            }
        }
        void limpBus()
        {
            txtBusCod.Text = String.Empty;
            txtBusCod.Enabled = true;
            cmbBusEst.Enabled = true;
            cmbBusEst.Text = String.Empty;
            checkFecha.Enabled = true;
            checkFecha.Checked = false;
        }
        void busDes(bool aux)
        {
           limpBus();
            cuadroBus.Enabled = aux;
            limpCBus.Enabled = aux;

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTareas.SelectedRows.Count > 0)
            {
                int index = dgvTareas.SelectedRows[0].Index;
                listaTareas.RemoveAt(index);
                ActualizarGrid();
                MessageBox.Show("Tarea eliminada correctamente.");
                btnAgregar.Enabled = true;
            }
            if (listaTareas.Count == 0)
            {
                btnEliminar.Enabled = false;
                btnEditar.Enabled = false;
                busDes(false);
            }
        }

        private void dgvTareas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCodigo.Text = dgvTareas.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNombre.Text = dgvTareas.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDescripcion.Text = dgvTareas.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpFecha.Value = (DateTime)dgvTareas.Rows[e.RowIndex].Cells[3].Value;
                txtLugar.Text = dgvTareas.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmbEstado.SelectedItem = dgvTareas.Rows[e.RowIndex].Cells[5].Value.ToString();
                cmbEstado.Text = dgvTareas.Rows[e.RowIndex].Cells[5].Value.ToString();
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != String.Empty)
            {
                txtNombre.Enabled = true;
            }
        }
        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (txtDescripcion.Text != String.Empty)
            {
                dtpFecha.Enabled = true;
                txtLugar.Enabled = true;
            }
        }
        private void txtLugar_TextChanged(object sender, EventArgs e)
        {
            if (txtLugar.Text != String.Empty)
            {
                cmbEstado.Enabled = true;
            }
        }
        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEstado.SelectedItem != null)
            {
                btnAgregar.Enabled = true;
            }
        }

        private void checkFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFecha.Checked)
            {
                dtpBusFMax.Enabled = true;
                dtpBusFMin.Enabled = true;
                txtBusCod.Enabled = false;
                cmbBusEst.Enabled = false;
                btnBus.Enabled = true;
            }
            else
            {
                dtpBusFMax.Enabled = false;
                dtpBusFMin.Enabled = false;
                txtBusCod.Enabled = true;
                cmbBusEst.Enabled = true;
                btnBus.Enabled = false;
            }
        }

        private void cmbBusEst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBusEst.SelectedItem != null)
            {
                dtpBusFMax.Enabled = false;
                dtpBusFMin.Enabled = false;
                txtBusCod.Enabled = false;
                checkFecha.Enabled = false;
                btnBus.Enabled = true;
            }
            else
            {
                dtpBusFMax.Enabled = false;
                dtpBusFMin.Enabled = false;
                txtBusCod.Enabled = true;
                checkFecha.Enabled = true;
                btnBus.Enabled = false;
            }
        }

        private void txtBusCod_TextChanged(object sender, EventArgs e)
        {
            if (txtBusCod.Text != String.Empty)
            {
                dtpBusFMax.Enabled = false;
                dtpBusFMin.Enabled = false;
                cmbBusEst.Enabled = false;
                checkFecha.Enabled = false;
                btnBus.Enabled = true;
            }
            else
            {
                dtpBusFMax.Enabled = false;
                dtpBusFMin.Enabled = false;
                cmbBusEst.Enabled = true;
                checkFecha.Enabled = true;
                btnBus.Enabled = false;
            }
        }

        private void btnBus_Click(object sender, EventArgs e)
        {
            listaAux.Clear();
            limpCBus.Enabled = true;
            limpVisor_Click(sender, e);
            limpC_Click(sender, e);
            //ActualizarGrid();
            if (txtBusCod.Enabled)
            {
                for(int i = 0; i < listaTareas.Count; i++)
                {
                    if (txtBusCod.Text == listaTareas[i].Codigo)
                    {
                        listaAux.Add(listaTareas[i]);
                        MessageBox.Show("Encontrado y viualizado en el visor de datos");
                        ActualizarGrid(listaAux);
                        limpBus();
                        return;
                    }
                }
                MessageBox.Show($"No se encontró ningún elemento con el codigo: {txtBusCod.Text}");
            }
            if (cmbBusEst.Enabled)
            {

                for (int i = 0; i < listaTareas.Count; i++)
                {
                    if (cmbBusEst.Text== listaTareas[i].Estado)
                    {
                        listaAux.Add(listaTareas[i]);
                    }
                }
                if(listaAux.Count > 0)
                {
                    MessageBox.Show("Datos Encontrados y viualizados en el visor de datos");
                    ActualizarGrid(listaAux);
                    limpBus();
                    return;
                }
                MessageBox.Show($"No se encontró ninguna tarea con el estado de <<{cmbBusEst.Text}>>");
            }
            if (checkFecha.Checked) { 
                for (int i = 0;i < listaTareas.Count; i++)
                {
                    if (listaTareas[i].Fecha >= dtpBusFMin.Value && listaTareas[i].Fecha<=dtpBusFMax.Value)
                    {
                        listaAux.Add(listaTareas[i]);
                    }
                }
                if (listaAux.Count > 0)
                {
                    MessageBox.Show("Datos Encontrados y viualizados en el visor de datos");
                    ActualizarGrid(listaAux);
                    limpBus();
                    return;
                }
                MessageBox.Show($"No se encontró ninguna tarea con entre el {dtpBusFMin.Value.ToString()} y {dtpBusFMax.Value.ToString()}");
            }
            limpBus();
        }            
        void limpVis()
        {
            dgvTareas.DataSource = null;
            dgvTareas.Rows.Clear();
        }
        private void limpVisor_Click(object sender, EventArgs e)
        {
            limpVis();
            MessageBox.Show("Visor limpiado correctamente");
        }
        private void limpT_Click(object sender, EventArgs e)
        {
            limpVis();
            limpCamp();
            limpBus();
            MessageBox.Show("Todos los campos y el visor han sido limpiados");
        }
        private void limpC_Click(object sender, EventArgs e)
        {
            limpCamp();
            MessageBox.Show("Campos principales limpiados");
        }

        private void limpCBus_Click(object sender, EventArgs e)
        {
            limpBus();
            MessageBox.Show("Campos de búsqueda limpiados");
        }

        private void btnMTodo_Click(object sender, EventArgs e)
        {
            if (listaTareas.Count == 0) {
                MessageBox.Show("La lista está vacía, no hay elementos para mostrar");
                return;
            }
            limpVis();
            dgvTareas.DataSource = listaTareas;
            MessageBox.Show("Mostrando todos los elementos de la lista");
        }
    }
}
