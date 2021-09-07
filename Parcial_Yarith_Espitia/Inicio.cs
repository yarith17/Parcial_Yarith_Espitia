using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_Yarith_Espitia
{
    public partial class Inicio : Form
    {
        string UserAdmin = "YarithEspitia";
        string passwordAdmin = "yarith17";
        string User_1 = "DannaOrtiz";
        string passwordUser_1 = "danna04";
        string User_2 = "SaraArias";
        string passwordUser_2 = "sara09";
        public Inicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            if (TxtUsuario.Text == UserAdmin && TxtContraseña.Text == passwordAdmin)
            {
                TxtUsuario.Clear();
                TxtContraseña.Clear();
                Inicio Main = new Inicio();
                Main.ShowDialog();
            }
        }
    }
}
