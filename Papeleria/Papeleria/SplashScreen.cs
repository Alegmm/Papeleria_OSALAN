using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Papeleria
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            iniciar();
        }

        private void iniciar()
        {
            do
            {
                progressBar.Value += 3;
            } while (progressBar.Value < 99);

            Hide();
            Log_In logIn = new Log_In();
            logIn.ShowDialog(this);
            Application.Exit();
        }
    }
}
