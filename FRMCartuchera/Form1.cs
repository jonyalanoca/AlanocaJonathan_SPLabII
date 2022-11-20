using Entidades;
using System.Drawing;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms.VisualStyles;
using System.Data;

namespace FRMCartuchera
{
    public partial class frmCartuchera : Form
    {
        private bool menuDesplegado = false;
        private Cartuchera<Utiles> cartuchera;
        public frmCartuchera()
        {
            InitializeComponent();
            this.cartuchera = new Cartuchera<Utiles>();
        }

        private void frmCartuchera_Load(object sender, EventArgs e)
        {
            Cartuchera<Utiles> cartuchera = new Cartuchera<Utiles>();
            cartuchera.EventoPrecio +=Notificar;
            if(
            LapizDAO.LeerLapiz(ref this.cartuchera)==false ||
            GomaDAO.LeerGoma(ref this.cartuchera)==false ||
            SacapuntasDAO.LeerSPuntas(ref this.cartuchera) == false)
            {
                MessageBox.Show("Error en la carga de la base de datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            CompletarTabla();

            cmbColor.DataSource = Enum.GetValues(typeof(ConsoleColor));
            cmbMaterial.DataSource= Enum.GetValues(typeof(Materiales));
            cmbTipo.DataSource= Enum.GetValues(typeof(Tipos));
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

        private void pnlTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CompletarTabla()
        {
            
            int fila = 0;
            foreach(var i in cartuchera.ListaUtiles)
            {
                dgvTabla.Rows.Add(i.Id, i.Precio, i.Marca);
                if (i.GetType() == typeof(Lapiz))
                {
                    dgvTabla.Rows[fila].Cells[3].Value = ((Lapiz)i).Color;
                }
                else if(i.GetType() == typeof(Goma))
                {
                    dgvTabla.Rows[fila].Cells[5].Value = ((Goma)i).Tipo;
                }
                else if (i.GetType() == typeof(Sacapuntas))
                {
                    dgvTabla.Rows[fila].Cells[4].Value = ((Sacapuntas)i).Material;
                }
                fila++;
            }
        }

        private void dgvTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvTabla.Rows.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmOpcion opciones = new frmOpcion();
            this.Hide();
            opciones.ShowDialog();
            this.Show();
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Utiles aux = this.cartuchera.BuscarUtilPorId(ObtenerIdDeTabla());
                DialogResult respuesta= MessageBox.Show($"¿Seguro que desea borrar el siguiente registro?\n{aux.Detalles()} ","Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (respuesta == DialogResult.OK)
                {
                    if (aux.Id >= 1000 &&  aux.Id<2000)
                    {
                        GomaDAO.EliminarGoma((Goma)aux);
                    }
                    else if (aux.Id >= 2000 && aux.Id < 3000)
                    {
                        LapizDAO.EliminarLapiz((Lapiz)aux);
                    }
                    else if (aux.Id >= 3000)
                    {
                        SacapuntasDAO.EliminarSPunta((Sacapuntas)aux);
                    }
                    MessageBox.Show(this.cartuchera - aux,"Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvTabla.Rows.Clear();
                    CompletarTabla();
                }
                else{
                    MessageBox.Show("No se realizacion cambios","Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }            
        }
        private int ObtenerIdDeTabla()
        {
            int nroFila = dgvTabla.CurrentRow.Index;
            return (int)dgvTabla.Rows[nroFila].Cells[0].Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMenuSerializar_Click(object sender, EventArgs e)
        {
            this.btnSerializar.Visible = !this.btnSerializar.Visible;
            this.btnDeserializar.Visible = !this.btnDeserializar.Visible;
        }

        private void tckPrecio_Scroll(object sender, EventArgs e)
        {
            lblPrecio_Data.Text = tckPrecio.Value.ToString();
        }
    }
}