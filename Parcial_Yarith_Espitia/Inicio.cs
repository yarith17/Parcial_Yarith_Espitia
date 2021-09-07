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
        string UsuarioAdmin = "YarithEspitia";
        string contraseñaAdmin = "yarith17";
        string Usuario_1 = "DannaOrtiz";
        string contraseñaUsuario_1 = "danna04";
        string Usuario_2 = "SaraArias";
        string contraseñaUsuario_2 = "sara09";
        public Inicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            if (TxtUsuario.Text == UsuarioAdmin && TxtContraseña.Text == contraseñaAdmin)
            {
                TxtUsuario.Clear();
                TxtContraseña.Clear();
                Inicio Main = new Inicio();
                Main.ShowDialog();
            }
            else
            {
                if (TxtUsuario.Text == Usuario_1 && TxtContraseña.Text == contraseñaUsuario_1)
                {
                    TxtUsuario.Clear();
                    TxtContraseña.Clear();
                    Usuario Main = new Usuario();
                    Main.ShowDialog();
                }
                else
                {
                    if (TxtUsuario.Text == Usuario_2 && TxtContraseña.Text == contraseñaUsuario_2)
                    {
                        TxtUsuario.Clear();
                        TxtContraseña.Clear();
                        Usuario Main = new Usuario();
                        Main.ShowDialog();
                    }
                
                    }

                }
            }
    }
}
