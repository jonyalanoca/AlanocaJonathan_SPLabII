using Entidades;
using System.Drawing;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms.VisualStyles;
using System.Data;
using System.Runtime.Intrinsics.X86;
using Microsoft.VisualBasic.Devices;

namespace FRMCartuchera
{
    public partial class frmCartuchera : Form
    {
        private bool menuDesplegado = false;
        private Cartuchera<Utiles> cartuchera;
        private bool modificacionEnCurso;
        public frmCartuchera()
        {
            InitializeComponent();
            this.cartuchera = new Cartuchera<Utiles>();
            this.modificacionEnCurso = false;
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
            if (modificacionEnCurso==false)
            {
                int auxId = ObtenerIdDeTabla();
                CompletarDatosPorId(auxId);
                modificacionEnCurso = true;
            }
            else
            {
                MessageBox.Show("Hat una modificación en curso.\nTermine con la modificacion antes de continuar.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                this.dgvTabla.Location = new Point(1, 374);
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.dgvTabla.Location = new Point(1, 600);
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
            
        }
        private void abilitarDesabilitarTodo()
        {
            tckPrecio.Enabled = !tckPrecio.Enabled;
            txtMarca.Enabled = !txtMarca.Enabled;
            cmbColor.Enabled = !cmbColor.Enabled;
            cmbMaterial.Enabled = !cmbMaterial.Enabled;
            cmbTipo.Enabled = !cmbTipo.Enabled;
            btnGuardar.Enabled = !btnGuardar.Enabled;
            btnDescartar.Enabled = !btnDescartar.Enabled;
            
        }
        private void VisibleComboBox(string opcion)
        {
            this.cmbTipo.Visible = false;
            this.cmbMaterial.Visible = false;
            this.cmbColor.Visible = false;
            switch (opcion)
            {
                case "tipo":
                    this.cmbTipo.Visible = true;
                    break;
                case "material":
                    this.cmbMaterial.Visible = true;
                    break;
                case "color":
                    this.cmbColor.Visible = true;
                    break;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            abilitarDesabilitarTodo();
            modificacionEnCurso = false;
            int auxId = int.Parse(lblId_data.Text);
            Utiles auxUtil=cartuchera.BuscarUtilPorId(auxId);
            RealizarCambio(auxUtil);
            if (auxId >= 1000 && auxId < 2000)
            {
                GomaDAO.ModificarGoma((Goma)auxUtil);
            }
            else if (auxId >= 2000 && auxId < 3000)
            {
                LapizDAO.ModificarLapiz((Lapiz)auxUtil);
            }
            else if (auxId >= 3000)
            {
                SacapuntasDAO.ModificarSPunta((Sacapuntas)auxUtil);
            }
            dgvTabla.Rows.Clear();
            CompletarTabla();




            //if (auxId >= 1000 && auxId < 2000)
            //{

            //}
            //else if (auxId >= 2000 && auxId < 3000)
            //{

            //}
            //else if (auxId >= 3000)
            //{

            //}


        }
        private void CompletarDatosPorId(int auxId)
        {
            Utiles auxUtil = cartuchera.BuscarUtilPorId(auxId);
            this.lblId_data.Text = auxUtil.Id.ToString();
            this.lblPrecio_Data.Text = auxUtil.Precio.ToString();
            this.tckPrecio.Value = (int)auxUtil.Precio;
            this.txtMarca.Text = auxUtil.Marca;
            if (auxId >= 1000 && auxId < 2000)
            {
                this.cmbTipo.Text = ((Goma)auxUtil).Tipo.ToString();
                VisibleComboBox("tipo");
            }
            else if (auxId >= 2000 && auxId < 3000)
            {
                this.cmbColor.Text = ((Lapiz)auxUtil).Color.ToString();
                VisibleComboBox("color");
            }
            else if (auxId >= 3000)
            {
                this.cmbMaterial.Text = ((Sacapuntas)auxUtil).Material.ToString();
                VisibleComboBox("material");
            }
            abilitarDesabilitarTodo();
        }
        private void ResetearCampos()
        {
            this.lblId_data.Text = "";
            this.lblPrecio_Data.Text = "0";
            this.tckPrecio.Value = 0;
            this.txtMarca.Text = "";
            this.cmbColor.Text = "Black";
            this.cmbMaterial.Text = "SinDefinir";
            this.cmbTipo.Text = "SinDefinir";

        }
        private void RealizarCambio(Utiles util)
        {
            int auxId = util.Id;
            util.Precio = this.tckPrecio.Value;
            util.Marca = this.txtMarca.Text;
            if (auxId >= 1000 && auxId < 2000)
            {
                Tipos aux;
                Enum.TryParse<Tipos>(this.cmbTipo.Text, out aux);
                ((Goma)util).Tipo = aux;
            }
            else if (auxId >= 2000 && auxId < 3000)
            {
                ConsoleColor aux;
                Enum.TryParse<ConsoleColor>(this.cmbColor.Text, out aux);
                ((Lapiz)util).Color = aux;
            }
            else if (auxId >= 3000)
            {
                Materiales aux;
                Enum.TryParse<Materiales>(this.cmbMaterial.Text, out aux);
                ((Sacapuntas)util).Material = aux;
            }
        }

        private void btnDescartar_Click(object sender, EventArgs e)
        {
            this.modificacionEnCurso = false;
            ResetearCampos();
            abilitarDesabilitarTodo();
        }

        private void tckPrecio_Scroll_1(object sender, EventArgs e)
        {
            lblPrecio_Data.Text = tckPrecio.Value.ToString();
        }
    }
}