using Datos.BaseDatos;
using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class PNReserva : Form
    {
        private readonly ExaIIRTeatroConec _context;
        private readonly ReservaDataAccess _reservaDataAccess;


        public PNReserva(ExaIIRTeatroConec context)
        {
            InitializeComponent();
            _context = context;
            _reservaDataAccess = new ReservaDataAccess("Data Source=DESKTOP-Q6JBD0N\\SQLEXPRESS01;Initial Catalog=ExaIIRAD;user id=sa;password=123456789;");



            int proximoId = ObtenerProximoId();
            TXTID.Text = proximoId.ToString();
        }

        private void PNReserva_Load(object sender, EventArgs e)
        {
            CargarReservas();
        }

        private void CargarReservas()
        {
            var reservas = _reservaDataAccess.ObtenerReservas();
            dataGridView1.DataSource = reservas;
        }

        private int ObtenerProximoId()
        {
            using (var context = new ExaIIRTeatroConec())
            {
                return context.reserva.Max(r => r.ReservaId) + 1;
            }
        }


        private void LimpiarCampos()
        {
            CBXCTEATRO.SelectedIndex = 0;
            CBXCCLIENTE.SelectedIndex = 0;
            CBXASIENTO.SelectedIndex = 0;
            DTFRESERVA.Value = DateTime.Now;
        }

        private void BTNMODIFICAR_Click(object sender, EventArgs e)
        {

        }
    }
}
