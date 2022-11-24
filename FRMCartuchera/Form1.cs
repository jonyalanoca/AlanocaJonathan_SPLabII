using Entidades;
using System.Drawing;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms.VisualStyles;
using System.Data;
using System.Runtime.Intrinsics.X86;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.ApplicationServices;

namespace FRMCartuchera
{
    public partial class frmCartuchera : Form
    {
        private bool menuDesplegado;
        private Cartuchera<Utiles> cartuchera;
        private bool modificacionEnCurso;
        private bool agregarEnCurso;
        private Task hilo;
        public frmCartuchera()
        {
            InitializeComponent();
            this.cartuchera = new Cartuchera<Utiles>();
            cartuchera.EventoPrecio += CapturarCartuchera;
            this.modificacionEnCurso = false;
            this.agregarEnCurso = false;
            this.menuDesplegado = false;
            this.hilo = Task.Run(Temporizador);
        }

        private void frmCartuchera_Load(object sender, EventArgs e)
        {

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

            this.pnlMenu.Size = new Size(63, 1);
            this.btnHamburguesa.Location = new Point(3, 3);
            ActualizarTPrecioYTRegistros();
        }
        public void Notificar(string mensaje)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHamburguesa_Click(object sender, EventArgs e)
        {
            if (this.menuDesplegado == false)
            {
                this.pnlMenu.Size = new Size(240, 1);
                this.btnHamburguesa.Location = new Point(192, 3);   
            }
            else
            {
                this.pnlMenu.Size = new Size(63, 1);
                this.btnHamburguesa.Location = new Point(3, 3);
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
            if (agregarEnCurso == false)
            {
                frmOpcion frmOp = new frmOpcion();
                this.Hide();
                frmOp.ShowDialog();
                this.Show();

                abilitarDesabilitarTodo();
                VisibleComboBox(frmOp.Opcion);
                this.agregarEnCurso = true;
            }
            else
            {
                MessageBox.Show("Hay una operacion en curso.\nTermine con operacion actual antes de continuar.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (modificacionEnCurso==false)
            {
                int auxId = ObtenerIdDeTabla();
                CompletarDatosPorId(auxId);
                modificacionEnCurso = true;
                abilitarDesabilitarTodo();
            }
            else
            {
                MessageBox.Show("Hay una modificación en curso.\nTermine con la modificacion antes de continuar.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    ActualizarTPrecioYTRegistros();
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
                case "goma":
                    this.cmbTipo.Visible = true;
                    break;
                case "sacapuntas":
                    this.cmbMaterial.Visible = true;
                    break;
                case "lapiz":
                    this.cmbColor.Visible = true;
                    break;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (modificacionEnCurso==true)
            {
                modificacionEnCurso = false;
                int auxId = int.Parse(lblId_data.Text);
                Utiles auxUtil = cartuchera.BuscarUtilPorId(auxId);
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
            }
            else if (agregarEnCurso == true)// modificar aca con el limite maximo
            {
                Utiles nuevo=null;
                if(cartuchera.ListaUtiles.Count < cartuchera.Capacidad)
                {
                    if (cmbColor.Visible == true)
                    {
                        ConsoleColor colorAux;
                        Enum.TryParse<ConsoleColor>(cmbColor.SelectedValue.ToString(), out colorAux);
                        nuevo = new Lapiz(1, tckPrecio.Value, txtMarca.Text, colorAux);

                        LapizDAO.AgregarLapiz((Lapiz)nuevo);
                        nuevo.Id=LapizDAO.UltimoId();
                    }
                    else if (cmbMaterial.Visible == true)
                    {
                        
                        Materiales materialAux;
                        Enum.TryParse<Materiales>(cmbMaterial.SelectedValue.ToString(), out materialAux);
                        nuevo = new Sacapuntas(1, tckPrecio.Value, txtMarca.Text, materialAux);

                        SacapuntasDAO.AgregarSPunta((Sacapuntas)nuevo);
                        nuevo.Id=SacapuntasDAO.UltimoId();
                    }
                    else if (cmbTipo.Visible == true)
                    {                        
                        Tipos tipoAux;
                        Enum.TryParse<Tipos>(cmbTipo.SelectedValue.ToString(), out tipoAux);
                        nuevo = new Goma(1, tckPrecio.Value, txtMarca.Text, tipoAux);

                        GomaDAO.AgregarGoma((Goma)nuevo);
                        nuevo.Id = GomaDAO.UltimoId();
                    }
                }
                agregarEnCurso = false;
                
                MessageBox.Show(cartuchera + nuevo, "Cambios importantes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dgvTabla.Rows.Clear();
            CompletarTabla();
            abilitarDesabilitarTodo();
            ResetearCampos();
            ActualizarTPrecioYTRegistros();
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
                VisibleComboBox("goma");
            }
            else if (auxId >= 2000 && auxId < 3000)
            {
                this.cmbColor.Text = ((Lapiz)auxUtil).Color.ToString();
                VisibleComboBox("lapiz");
            }
            else if (auxId >= 3000)
            {
                this.cmbMaterial.Text = ((Sacapuntas)auxUtil).Material.ToString();
                VisibleComboBox("sacapuntas");
            }
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
            this.agregarEnCurso = false;
            ResetearCampos();
            abilitarDesabilitarTodo();
        }

        private void tckPrecio_Scroll_1(object sender, EventArgs e)
        {
            lblPrecio_Data.Text = tckPrecio.Value.ToString();
        }
        private void CapturarCartuchera(string mensaje)
        {
            MessageBox.Show("Se exedio el limite de $500.\nSe guardo el Ticket en un archivo ticket.txt en Mis Documentos","Infomación de tickets",MessageBoxButtons.OK, MessageBoxIcon.Information);
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter sw = new StreamWriter($"{ruta}\\tickets.txt",true)){
                sw.WriteLine(mensaje);
            };
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            try
            {
                using (StreamReader sr = new StreamReader($"{ruta}\\tickets.txt"))
                {

                    string auxString=sr.ReadToEnd();
                    frmTicket frmTick = new frmTicket(auxString);
                    this.Hide();
                    frmTick.ShowDialog();
                    this.Show();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron leer los tickets \n-Verifique que el archivos ticket.txt se encuntra en Mis Documentos.\n-Aun no se alcanzo el limite de $500", "Infomación de tickets", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnSerializar_Click(object sender, EventArgs e)
        {
            this.btnSerializar.Visible = false;
            this.btnDeserializar.Visible = false;
            int auxId=ObtenerIdDeTabla();
            if(auxId>=2000 && auxId<3000){
                Lapiz auxLapiz=(Lapiz)cartuchera.BuscarUtilPorId(auxId);
                ((ISerializa)auxLapiz).SerializarJson($"Lapiz_{auxId}");
                ((ISerializa)auxLapiz).SerializarXml($"Lapiz_{auxId}");
                MessageBox.Show($"Se Serializó en Json y una copia en XML del lapiz en Mis Documentos.\nAchivos Json: Lapiz_{auxId}.txt\nAchivos XML: Lapiz_{auxId}.xml", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un lapiz de la tabla.\nRecomendacion: son del 2000 al 2999", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDeserializar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta= MessageBox.Show("Esta Funcion Reemplaza los valores del Lapiz seleccionado por los del archivo serializado.\n¿Desea Continuar?", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (respuesta == DialogResult.OK)
            {
                string ruta;
                int auxId = ObtenerIdDeTabla();
                if (auxId >= 2000 && auxId < 3000)
                {
                    Lapiz auxLapiz = (Lapiz)cartuchera.BuscarUtilPorId(auxId);
                    string viejaInfo = auxLapiz.Detalles();
                    if (ofdAbrirArchivo.ShowDialog() == DialogResult.OK)
                    {
                        ruta = ofdAbrirArchivo.FileName;
                        if (ruta.Contains(".txt"))
                        {
                            ((IDeserializa)auxLapiz).SerializarJson(ruta);
                        }
                        else if (ruta.Contains(".xml"))
                        {
                            ((IDeserializa)auxLapiz).SerializarXml(ruta);
                        }
                        else
                        {
                            MessageBox.Show("El archivo no corresponde a un json o xml", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        dgvTabla.Rows.Clear();
                        CompletarTabla();
                        MessageBox.Show(auxLapiz.CambioPorDeserializacion(viejaInfo), "Cambios Importantes",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un lapiz de la tabla.\nRecomendacion: son del 2000 al 2999", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            
            this.btnSerializar.Visible = false;
            this.btnDeserializar.Visible = false;
        }
        private void Temporizador()
        {
            int tiempo = 0;
            while (true)
            {
                Thread.Sleep(1000);
                if (lblTemporizador.InvokeRequired)
                {
                    Action actAux = new Action(() => this.lblTemporizador.Text = TransformadorTiempo.Transformar(tiempo));
                    lblTemporizador.BeginInvoke(actAux);
                }
                else
                {
                    this.lblTemporizador.Text = TransformadorTiempo.Transformar(tiempo);
                }
                tiempo++;
            }
        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ActualizarTPrecioYTRegistros()
        {
            string auxRegistros = $"{this.cartuchera.ListaUtiles.Count}/{this.cartuchera.Capacidad}";
            this.lblRegistros_data.Text = auxRegistros;
            this.lblTotalPrecio_data.Text = $"${this.cartuchera.PrecioTotatCartuchera}";
        }
    }
}