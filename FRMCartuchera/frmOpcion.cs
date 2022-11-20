using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRMCartuchera
{
    public partial class frmOpcion : Form
    {
        private string opcion;

        public string Opcion { get => opcion;}

        public frmOpcion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.opcion = "goma";
            this.Close();
            
        }

        private void btnOpcionLapiz_Click(object sender, EventArgs e)
        {
            this.opcion = "lapiz";
            this.Close();
        }

        private void btnOpcionSacapuntas_Click(object sender, EventArgs e)
        {
            this.opcion = "sacapuntas";
            this.Close();
        }
    }
}
