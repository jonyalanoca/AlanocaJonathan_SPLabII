using Entidades;

namespace FRMCartuchera
{
    public partial class frmCartuchera : Form
    {
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
    }
}