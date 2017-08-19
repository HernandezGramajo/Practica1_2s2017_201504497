using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDD_practica_1_interfaz
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

          Dashboard frm = new Dashboard();
            frm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Administrador_de_Mensajes adm = new Administrador_de_Mensajes();
            adm.Show();

        }
    }
}
