using Datos.BaseDatos;
using Negocio;
using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class PMENUS : Form
    {
        private ExaIIRTeatroConec context;

        public PMENUS()
        {
            InitializeComponent();
            context = new ExaIIRTeatroConec();

            button1.Click += (sender, e) => ShowForm(new PNClientes());
            button2.Click += (sender, e) => ShowForm(new PNTeatro());
            button3.Click += (sender, e) => ShowForm(new PNReserva(context));
            button4.Click += (sender, e) => ExitApplication();
        }

        private void ShowForm(Form form)
        {
            form.ShowDialog();
        }

        private void ExitApplication()
        {
            Application.Exit();
        }
    }
}
