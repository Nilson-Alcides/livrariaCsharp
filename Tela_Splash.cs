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

namespace Livraria
{
    public partial class Tela_Splash : Form
    {
        public Tela_Splash()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Barra_Progresso.Value < 100)
            {
                Barra_Progresso.Value = Barra_Progresso.Value +2;
                lbl_porcentagem.Text = Barra_Progresso.Value.ToString()+"%";
            }
            else
            {
                timer1.Enabled = false;
                this.Visible = false;
                Login login = new Login();
                login.ShowDialog();




            }
        }
    }
}
