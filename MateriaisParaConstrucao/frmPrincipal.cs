using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateriaisParaConstrucao
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            //Evento Click do btnFuncionarios em que o formulário frmFuncionarios é instanciado e exibido.
            frmFuncionarios formFuncionarios = new frmFuncionarios();
            formFuncionarios.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            //Evento Click do btnClientes em que o formulário frmClientes é instanciado e exibido.
            frmClientes formClientes = new frmClientes();
            formClientes.ShowDialog();
        }
    }
}
