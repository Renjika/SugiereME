using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SugiereMe
{
    public partial class fr_Registro : Form
    {
        public fr_Registro()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Crear una instancia de Form2
            fr_Login form1 = new fr_Login();
            // Mostrar el segundo formulario
            form1.Show();
            this.Hide();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
