using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Datos.Core;
using Datos;
using Datos.BaseDatos;
using Datos.Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Presentacion
{
    public partial class PCliente : Form
    {
        private NCliente _clienteNegocio;
        public PCliente()
        {
            InitializeComponent();
            var context = new ExaIIRTeatroConec();
            var unitOfWork = new UnitOfWork(context);
            _clienteNegocio = new NCliente(unitOfWork);
           BTNGUARDAR.Click += BTNGUARDAR_Click;
           BTNMODIFICAR.Click += BTNMODIFICAR_Click;
            BTNELIMINAR.Click += BTNELIMINAR_Click;

        }




        private void PCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'exaIIRADDataSet.DClientes' Puede moverla o quitarla según sea necesario.
            this.dClientesTableAdapter.Fill(this.exaIIRADDataSet.DClientes);


            int proximoId = ObtenerProximoId();
            TXTID.Text = proximoId.ToString();

            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
        }

        private int ObtenerProximoId()
        {
            int maxId = 0;
            using (var context = new ExaIIRTeatroConec())
            {
                maxId = context.Set<DCliente>().Max(g => g.ClienteId);
            }
            return maxId + 1;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                TXTID.Text = row.Cells["clienteIdDataGridViewTextBoxColumn"].Value.ToString();
                TXTIDENTIDAD.Text = row.Cells["identidadDataGridViewTextBoxColumn"].Value.ToString();
                TXTNOMBRE.Text = row.Cells["nombresDataGridViewTextBoxColumn"].Value.ToString();
                TXTAPELLIDO.Text = row.Cells["apellidosDataGridViewTextBoxColumn"].Value.ToString();
                TXTCORREO.Text = row.Cells["correoDataGridViewTextBoxColumn"].Value.ToString();
                TXTCELULAR.Text = row.Cells["celularDataGridViewTextBoxColumn"].Value.ToString();
            }
        }

        private void limpiar()
        {
            TXTID.Clear();
            TXTNOMBRE.Clear();
            TXTAPELLIDO.Clear();
            TXTCORREO.Clear();
            TXTCELULAR.Clear();

        }

        //BOTONES

        private bool ValidarCamposVacios()
        {
            if (string.IsNullOrWhiteSpace(TXTID.Text) || string.IsNullOrWhiteSpace(TXTNOMBRE.Text) || string.IsNullOrWhiteSpace(TXTAPELLIDO.Text) || string.IsNullOrWhiteSpace(TXTCORREO.Text) || string.IsNullOrWhiteSpace(TXTCELULAR.Text) || string.IsNullOrWhiteSpace(TXTIDENTIDAD.Text))
            {
                return false;
            }
            return true;
        }
        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {
            if (ValidarCamposVacios())
            {
                if (MessageBox.Show("¿Desea guardar los cambios?", "Guardar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var cliente = new DCliente
                    {
                        ClienteId = int.Parse(TXTID.Text),
                        Identidad = decimal.Parse(TXTIDENTIDAD.Text),
                        Nombres = TXTNOMBRE.Text,
                        Apellidos = TXTAPELLIDO.Text,
                        Correo = TXTCELULAR.Text,
                        Celular = int.Parse(TXTCELULAR.Text)
                    };

                    _clienteNegocio.AgregarCliente(cliente);

                    MessageBox.Show("Los cambios se guardaron correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpiar();
                    this.dClientesTableAdapter.Fill(this.exaIIRADDataSet.DClientes);
                }
            }
            else
            {
                MessageBox.Show("No se pueden guardar los cambios porque hay campos vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BTNMODIFICAR_Click(object sender, EventArgs e)
        {
            if (ValidarCamposVacios())
            {
                if (MessageBox.Show("¿Desea modificar el cliente?", "Modificar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var cliente = new DCliente
                    {
                        ClienteId = int.Parse(TXTID.Text),
                        Identidad = decimal.Parse(TXTIDENTIDAD.Text),
                        Nombres = TXTNOMBRE.Text,
                        Apellidos = TXTAPELLIDO.Text,
                        Correo = TXTCORREO.Text,
                        Celular = int.Parse(TXTCELULAR.Text)
                    };

                    _clienteNegocio.ActualizarCliente(cliente);

                    MessageBox.Show("El cliente se modificó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.dClientesTableAdapter.Fill(this.exaIIRADDataSet.DClientes);
                    limpiar();
                }
            }
            else
            {
                MessageBox.Show("No se puede modificar el cliente porque hay campos vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BTNELIMINAR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea eliminar este cliente?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (int.TryParse(TXTID.Text, out int clienteId))
                {
                    EliminarCliente(clienteId);
                }
                else
                {
                    MessageBox.Show("El ID del cliente no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EliminarCliente(int clienteId)
        {

            _clienteNegocio.EliminarCliente(clienteId);

            MessageBox.Show("El cliente se eliminó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            limpiar();
            this.dClientesTableAdapter.Fill(this.exaIIRADDataSet.DClientes);
        }
    }
}
