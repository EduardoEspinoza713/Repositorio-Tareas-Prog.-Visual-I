using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Tarea7_Prog_Vis_I
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void catalogoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.catalogoBindingSource.EndEdit();
            }
            catch (System.Data.NoNullAllowedException)
            {
                MessageBox.Show("No puedes dejar vacíos los campos obligatorios (Código, Nombre, Precio).", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var catalogoTabla = this.bd_ventasDataSet.Catalogo;

            foreach (DataRow row in catalogoTabla.Rows)
            {
                if (row.RowState == DataRowState.Added || row.RowState == DataRowState.Modified)
                {
                    if (row["Nombre"] == DBNull.Value || string.IsNullOrWhiteSpace(row["Nombre"].ToString()))
                    {
                        MessageBox.Show("El campo Nombre no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        row.RejectChanges();
                        return;
                    }

                    if (!int.TryParse(row["Codigo"].ToString(), out _))
                    {
                        MessageBox.Show("El campo Código debe ser un número válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        row.RejectChanges();
                        return;
                    }

                    if (!decimal.TryParse(row["Precio"].ToString(), out _))
                    {
                        MessageBox.Show("El campo Precio debe ser un valor numérico válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        row.RejectChanges();
                        return;
                    }
                }
            }

            try
            {
                this.catalogoTableAdapter.Update(catalogoTabla);

                MessageBox.Show("Cambios guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos: {ex.Message}", "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd_ventasDataSet.Catalogo' Puede moverla o quitarla según sea necesario.
            this.catalogoTableAdapter.Fill(this.bd_ventasDataSet.Catalogo);
            ((Form2)this.MdiParent).abierto(true, "cat");
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((Form2)this.MdiParent).abierto(false, "cat");
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
