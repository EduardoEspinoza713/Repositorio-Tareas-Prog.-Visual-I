using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea7_Prog_Vis_I
{
    public partial class Form3 : Form
    {
        private const string cadcon = "Data Source = ECEP7\\SQLEXPRESS;Initial Catalog = bd_ventas; Integrated Security = True;";
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ((Form2)(this.MdiParent)).abierto(true, "fac");
            DataClasses1DataContext db = new DataClasses1DataContext(cadcon);

            try
            {
                var codigosFactura = (from i in db.Factura
                                      select i.Codigo).ToList();

                cbCod.Items.Clear();
                foreach (var cod in codigosFactura)
                {
                    cbCod.Items.Add((int)cod);
                }

                if (cbCod.Items.Count > 0)
                {
                    cbCod.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}");
                this.Close();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((Form2)(this.MdiParent)).abierto(false, "fac");  
        }

        private void cbCod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCod.SelectedItem != null)
            {
                int codigo = (int)cbCod.SelectedItem;
                CargarDetallesFactura(codigo);
            }
        }
        private void CargarDetallesFactura(int codigoFactura)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(cadcon);

            var facSel = (from i in db.Factura
                                       where i.Codigo == codigoFactura
                                       select i).FirstOrDefault();

            if (facSel != null)
            {
                ctFacML.Text = $"Cliente: {facSel.Cliente}{Environment.NewLine}" +
                                         $"Fecha de Compra: {facSel.Fecha}";

                var prodDet = from i in facSel.Producto
                                       select new
                                       {
                                           i.Nombre,
                                           i.Cantidad,
                                           i.Precio,
                                           SubTot = i.Precio * i.Cantidad
                                       };

                dgvVis.DataSource = prodDet.ToList();

                double total = prodDet.Sum(p => p.SubTot);
                ctTotal.Text = total.ToString("C2");
            }
            else
            {
                ctFacML.Text = "Factura no encontrada.";
                dgvVis.DataSource = null;
                ctTotal.Text = string.Empty;
            }
        }

        private void dgvVisN_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if(e.ColumnIndex != 0) return;
            DataGridViewComboBoxCell combo = dgvVisN.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewComboBoxCell;
            DataClasses1DataContext db = new DataClasses1DataContext(cadcon);

            try
            {
                var ValCB = (from c in db.Catalogo
                                       select c.Nombre).ToList();

                combo.DataSource = ValCB;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los valores: {ex.Message}");
                e.Cancel = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(cadcon);
            if (ctFac.Text == "" || ctCli.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos de la factura.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int codigoFactura = Convert.ToInt32(ctFac.Text);
                Factura facturaExistente = (from f in db.Factura
                                            where f.Codigo == codigoFactura
                                            select f).FirstOrDefault();

                Factura facturaGuardar;

                if (facturaExistente != null)
                {
                    facturaExistente.Cliente = ctCli.Text;
                    facturaExistente.Fecha = dtpFecha.Value.ToShortDateString();
                    db.Producto.DeleteAllOnSubmit(facturaExistente.Producto);
                    facturaGuardar = facturaExistente;
                }
                else
                {
                    Factura nuevaFactura = new Factura
                    {
                        Codigo = codigoFactura,
                        Cliente = ctCli.Text,
                        Fecha = dtpFecha.Value.ToShortDateString()
                    };
                    db.Factura.InsertOnSubmit(nuevaFactura);
                    facturaGuardar = nuevaFactura;
                }

                if (facturaGuardar == null) return;
                if (facturaGuardar.Producto.Any())
                {
                    facturaGuardar.Producto.Clear();
                }

                foreach (DataGridViewRow row in dgvVisN.Rows)
                {
                    if (row.IsNewRow || row.Cells[0].Value == null || row.Cells[1].Value == null) continue;

                    string nomProd = row.Cells[0].Value.ToString();
                    int cant = Convert.ToInt32(row.Cells[1].Value);

                    var nuevo = (from i in db.Catalogo
                                 where i.Nombre == nomProd
                                 select i).FirstOrDefault();
                    if (nuevo != null)
                    {
                        Producto nuevoProducto = new Producto
                        {
                            Codigo = nuevo.Codigo,
                            Nombre = nuevo.Nombre,
                            Precio = nuevo.Precio,
                            Cantidad = cant,
                        };

                        facturaGuardar.Producto.Add(nuevoProducto);
                    }
                }

                db.SubmitChanges();
                Form3_Load(sender, e);
                MessageBox.Show("Factura guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la factura: {ex.Message}", "Error de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
