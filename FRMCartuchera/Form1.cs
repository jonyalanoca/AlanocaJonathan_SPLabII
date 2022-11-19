using Entidades;

namespace FRMCartuchera
{
    public partial class frmCartuchera : Form
    {
        private bool menuDesplegado = false;
        public frmCartuchera()
        {
            InitializeComponent();
        }

        private void frmCartuchera_Load(object sender, EventArgs e)
        {
            Cartuchera<Utiles> cartuchera = new Cartuchera<Utiles>();
            cartuchera.EventoPrecio +=Notificar;
        }
        public void Notificar(string mensaje)
        {
            MessageBox.Show(mensaje, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHamburguesa_Click(object sender, EventArgs e)
        {
            if (this.menuDesplegado == false)
            {
                this.pnlMenu.Size = new Size(63, 1);
                this.btnHamburguesa.Location = new Point(3,3);
            }
            else
            {
                this.pnlMenu.Size = new Size(240, 1);
                this.btnHamburguesa.Location = new Point(192, 3);
            }
            this.menuDesplegado = !this.menuDesplegado;
        }
    }
}