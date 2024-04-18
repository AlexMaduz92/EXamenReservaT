using Datos.BaseDatos;
using Datos.Entidades;
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

namespace Presentacion
{
    public partial class PTeatro : Form
    {
        private NTeatro _teatroNegocio;

        public PTeatro()
        {
            InitializeComponent();
            var context = new ExaIIRTeatroConec();
            var unitOfWork = new UnitOfWork(context);
            _teatroNegocio = new NTeatro(unitOfWork);
            BtnCerrar.Click += BtnCerrar_Click;
            BTNGUARDAR.Click += BTNGUARDAR_Click;
            BTNMODIFICAR.Click += BTNMODIFICAR_Click;
            BTNELIMINAR.Click += BTNELIMINAR_Click;
        }

        private void PTeatro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'exaIIRADDataSet1.DTeatroes' Puede moverla o quitarla según sea necesario.
            this.dTeatroesTableAdapter.Fill(this.exaIIRADDataSet1.DTeatroes);

            int proximoId = ObtenerProximoId();
            TXTID.Text = proximoId.ToString();

            DGVTEATRO.CellDoubleClick += DGVTEATRO_CellDoubleClick;
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

        private void DGVTEATRO_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(DGVTEATRO.CurrentRow.Cells["teatroIdDataGridViewTextBoxColumn"].Value.ToString());
            string nombre = DGVTEATRO.CurrentRow.Cells["nombreTeatroDataGridViewTextBoxColumn"].Value.ToString();
            int asientos = int.Parse(DGVTEATRO.CurrentRow.Cells["numeroAsientoDataGridViewTextBoxColumn"].Value.ToString());

            TXTID.Text = id.ToString();
            TXTNOMBRE.Text = nombre;
            TXTASIENTO.Text = asientos.ToString();
        }
        private void limpiar()
        {
            TXTID.Clear();
            TXTNOMBRE.Clear();
            TXTASIENTO.Clear();

        }

        private bool ValidarCamposVacios()
        {
            if (string.IsNullOrWhiteSpace(TXTID.Text) || string.IsNullOrWhiteSpace(TXTNOMBRE.Text) || string.IsNullOrWhiteSpace(TXTASIENTO.Text))
            {
                return false;
            }

            return true;
        }

        //BOTONES
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {
            if (ValidarCamposVacios())
            {
                if (MessageBox.Show("¿Desea guardar el teatro?", "Guardar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    GuardarTeatro();
                }
            }
            else
            {
                MessageBox.Show("No se puede guardar el teatro porque hay campos vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarTeatro()
        {
            DTeatro teatro = new DTeatro
            {
                TeatroId = int.Parse(TXTID.Text),
                NombreTeatro = TXTNOMBRE.Text,
                NumeroAsiento = int.Parse(TXTASIENTO.Text)
            };

            _teatroNegocio.AgregarTeatro(teatro);

            MessageBox.Show("Teatro agregado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.dTeatroesTableAdapter.Fill(this.exaIIRADDataSet1.DTeatroes);
            limpiar();
        }

        private void BTNMODIFICAR_Click(object sender, EventArgs e)
        {
            if (ValidarCamposVacios())
            {
                if (MessageBox.Show("¿Desea modificar el teatro?", "Modificar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ModificarTeatro();
                }
            }
            else
            {
                MessageBox.Show("No se puede modificar el teatro porque hay campos vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModificarTeatro()
        {
            DTeatro teatro = new DTeatro
            {
                TeatroId = int.Parse(TXTID.Text),
                NombreTeatro = TXTNOMBRE.Text,
                NumeroAsiento = int.Parse(TXTASIENTO.Text)
            };

            _teatroNegocio.ActualizarTeatro(teatro);

            MessageBox.Show("Teatro modificado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.dTeatroesTableAdapter.Fill(this.exaIIRADDataSet1.DTeatroes);
            limpiar();
        }
        private void BTNELIMINAR_Click(object sender, EventArgs e)
        {
            if (ValidarCamposVacios())
            {
                if (MessageBox.Show("¿Está seguro de que desea eliminar este teatro?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    EliminarTeatro();
                }
            }
            else
            {
                MessageBox.Show("No se puede eliminar el teatro porque hay campos vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarTeatro()
        {
            int id = int.Parse(TXTID.Text);

            _teatroNegocio.EliminarTeatro(id);

            MessageBox.Show("Teatro eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.dTeatroesTableAdapter.Fill(this.exaIIRADDataSet1.DTeatroes);
            limpiar();
        }
    }
}