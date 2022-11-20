namespace FRMCartuchera
{
    partial class frmCartuchera
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCartuchera));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnHamburguesa = new System.Windows.Forms.Button();
            this.btnTickets = new System.Windows.Forms.Button();
            this.btnDeserializar = new System.Windows.Forms.Button();
            this.btnSerializar = new System.Windows.Forms.Button();
            this.btnMenuSerializar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.tckPrecio = new System.Windows.Forms.TrackBar();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblId_data = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATERIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblMeneda = new System.Windows.Forms.Label();
            this.lblPrecio_Data = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tckPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(141)))), ((int)(((byte)(179)))));
            this.pnlTitulo.Controls.Add(this.btnMinimizar);
            this.pnlTitulo.Controls.Add(this.btnMaximizar);
            this.pnlTitulo.Controls.Add(this.btnCerrar);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(972, 30);
            this.pnlTitulo.TabIndex = 2;
            this.pnlTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitulo_Paint);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(141)))), ((int)(((byte)(179)))));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(881, 0);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(31, 30);
            this.btnMinimizar.TabIndex = 13;
            this.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMaximizar.ForeColor = System.Drawing.Color.White;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(912, 0);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(30, 30);
            this.btnMaximizar.TabIndex = 12;
            this.btnMaximizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMaximizar.UseVisualStyleBackColor = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(942, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "X";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnlMenu.Controls.Add(this.btnHamburguesa);
            this.pnlMenu.Controls.Add(this.btnTickets);
            this.pnlMenu.Controls.Add(this.btnDeserializar);
            this.pnlMenu.Controls.Add(this.btnSerializar);
            this.pnlMenu.Controls.Add(this.btnMenuSerializar);
            this.pnlMenu.Controls.Add(this.btnEliminar);
            this.pnlMenu.Controls.Add(this.btnModificar);
            this.pnlMenu.Controls.Add(this.btnAgregar);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlMenu.Location = new System.Drawing.Point(0, 30);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(240, 523);
            this.pnlMenu.TabIndex = 3;
            // 
            // btnHamburguesa
            // 
            this.btnHamburguesa.FlatAppearance.BorderSize = 0;
            this.btnHamburguesa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnHamburguesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHamburguesa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHamburguesa.ForeColor = System.Drawing.Color.White;
            this.btnHamburguesa.Image = ((System.Drawing.Image)(resources.GetObject("btnHamburguesa.Image")));
            this.btnHamburguesa.Location = new System.Drawing.Point(192, 0);
            this.btnHamburguesa.Name = "btnHamburguesa";
            this.btnHamburguesa.Size = new System.Drawing.Size(48, 44);
            this.btnHamburguesa.TabIndex = 5;
            this.btnHamburguesa.Text = " ";
            this.btnHamburguesa.UseVisualStyleBackColor = true;
            this.btnHamburguesa.Click += new System.EventHandler(this.btnHamburguesa_Click);
            // 
            // btnTickets
            // 
            this.btnTickets.FlatAppearance.BorderSize = 0;
            this.btnTickets.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTickets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTickets.ForeColor = System.Drawing.Color.White;
            this.btnTickets.Image = ((System.Drawing.Image)(resources.GetObject("btnTickets.Image")));
            this.btnTickets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTickets.Location = new System.Drawing.Point(3, 250);
            this.btnTickets.Name = "btnTickets";
            this.btnTickets.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.btnTickets.Size = new System.Drawing.Size(240, 44);
            this.btnTickets.TabIndex = 10;
            this.btnTickets.Text = "LEER TIKETS";
            this.btnTickets.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTickets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTickets.UseVisualStyleBackColor = true;
            // 
            // btnDeserializar
            // 
            this.btnDeserializar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnDeserializar.FlatAppearance.BorderSize = 0;
            this.btnDeserializar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnDeserializar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeserializar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeserializar.ForeColor = System.Drawing.Color.White;
            this.btnDeserializar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeserializar.Image")));
            this.btnDeserializar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeserializar.Location = new System.Drawing.Point(3, 392);
            this.btnDeserializar.Name = "btnDeserializar";
            this.btnDeserializar.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.btnDeserializar.Size = new System.Drawing.Size(240, 44);
            this.btnDeserializar.TabIndex = 9;
            this.btnDeserializar.Text = "Deserializar Lapices";
            this.btnDeserializar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeserializar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeserializar.UseVisualStyleBackColor = false;
            // 
            // btnSerializar
            // 
            this.btnSerializar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnSerializar.FlatAppearance.BorderSize = 0;
            this.btnSerializar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnSerializar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerializar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSerializar.ForeColor = System.Drawing.Color.White;
            this.btnSerializar.Image = ((System.Drawing.Image)(resources.GetObject("btnSerializar.Image")));
            this.btnSerializar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSerializar.Location = new System.Drawing.Point(3, 346);
            this.btnSerializar.Name = "btnSerializar";
            this.btnSerializar.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.btnSerializar.Size = new System.Drawing.Size(240, 44);
            this.btnSerializar.TabIndex = 8;
            this.btnSerializar.Text = "Serializar Lapices";
            this.btnSerializar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSerializar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSerializar.UseVisualStyleBackColor = false;
            // 
            // btnMenuSerializar
            // 
            this.btnMenuSerializar.FlatAppearance.BorderSize = 0;
            this.btnMenuSerializar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnMenuSerializar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSerializar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenuSerializar.ForeColor = System.Drawing.Color.White;
            this.btnMenuSerializar.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuSerializar.Image")));
            this.btnMenuSerializar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuSerializar.Location = new System.Drawing.Point(3, 300);
            this.btnMenuSerializar.Name = "btnMenuSerializar";
            this.btnMenuSerializar.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.btnMenuSerializar.Size = new System.Drawing.Size(240, 44);
            this.btnMenuSerializar.TabIndex = 7;
            this.btnMenuSerializar.Text = "SERIALIZAR";
            this.btnMenuSerializar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenuSerializar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMenuSerializar.UseVisualStyleBackColor = true;
            this.btnMenuSerializar.Click += new System.EventHandler(this.btnMenuSerializar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(3, 200);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.btnEliminar.Size = new System.Drawing.Size(240, 44);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(3, 150);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.btnModificar.Size = new System.Drawing.Size(240, 44);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "MODIFICAR ";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(3, 100);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.btnAgregar.Size = new System.Drawing.Size(240, 44);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "      NUEVO UTIL";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.pnlBody.Controls.Add(this.grpDatos);
            this.pnlBody.Controls.Add(this.dgvTabla);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(240, 30);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(732, 523);
            this.pnlBody.TabIndex = 4;
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.lblPrecio_Data);
            this.grpDatos.Controls.Add(this.lblMeneda);
            this.grpDatos.Controls.Add(this.cmbTipo);
            this.grpDatos.Controls.Add(this.cmbMaterial);
            this.grpDatos.Controls.Add(this.cmbColor);
            this.grpDatos.Controls.Add(this.tckPrecio);
            this.grpDatos.Controls.Add(this.txtMarca);
            this.grpDatos.Controls.Add(this.lblId_data);
            this.grpDatos.Controls.Add(this.label6);
            this.grpDatos.Controls.Add(this.label5);
            this.grpDatos.Controls.Add(this.label4);
            this.grpDatos.Controls.Add(this.lblMarca);
            this.grpDatos.Controls.Add(this.lblPrecio);
            this.grpDatos.Controls.Add(this.lblId);
            this.grpDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDatos.ForeColor = System.Drawing.Color.White;
            this.grpDatos.Location = new System.Drawing.Point(0, 0);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(732, 150);
            this.grpDatos.TabIndex = 1;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Detalle Datos";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(392, 105);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(144, 23);
            this.cmbTipo.TabIndex = 11;
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(392, 66);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(144, 23);
            this.cmbMaterial.TabIndex = 10;
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(392, 26);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(144, 23);
            this.cmbColor.TabIndex = 9;
            // 
            // tckPrecio
            // 
            this.tckPrecio.Location = new System.Drawing.Point(106, 62);
            this.tckPrecio.Maximum = 500;
            this.tckPrecio.Name = "tckPrecio";
            this.tckPrecio.Size = new System.Drawing.Size(142, 45);
            this.tckPrecio.TabIndex = 8;
            this.tckPrecio.Scroll += new System.EventHandler(this.tckPrecio_Scroll);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(106, 113);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(172, 23);
            this.txtMarca.TabIndex = 7;
            // 
            // lblId_data
            // 
            this.lblId_data.AutoSize = true;
            this.lblId_data.Location = new System.Drawing.Point(106, 29);
            this.lblId_data.Name = "lblId_data";
            this.lblId_data.Size = new System.Drawing.Size(10, 15);
            this.lblId_data.TabIndex = 6;
            this.lblId_data.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tipo :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Material";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Color : ";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(42, 113);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 15);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(42, 74);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 15);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.Text = "Precio";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(42, 29);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 15);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID : ";
            // 
            // dgvTabla
            // 
            this.dgvTabla.AllowUserToAddRows = false;
            this.dgvTabla.AllowUserToDeleteRows = false;
            this.dgvTabla.AllowUserToResizeColumns = false;
            this.dgvTabla.AllowUserToResizeRows = false;
            this.dgvTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTabla.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PRECIO,
            this.MARCA,
            this.COLOR,
            this.MATERIAL,
            this.TIPO});
            this.dgvTabla.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTabla.Location = new System.Drawing.Point(0, 150);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.RowTemplate.Height = 25;
            this.dgvTabla.Size = new System.Drawing.Size(732, 373);
            this.dgvTabla.TabIndex = 0;
            this.dgvTabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabla_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // PRECIO
            // 
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.ReadOnly = true;
            // 
            // MARCA
            // 
            this.MARCA.HeaderText = "MARCA";
            this.MARCA.Name = "MARCA";
            this.MARCA.ReadOnly = true;
            // 
            // COLOR
            // 
            this.COLOR.HeaderText = "COLOR";
            this.COLOR.Name = "COLOR";
            this.COLOR.ReadOnly = true;
            // 
            // MATERIAL
            // 
            this.MATERIAL.HeaderText = "MATERIAL";
            this.MATERIAL.Name = "MATERIAL";
            this.MATERIAL.ReadOnly = true;
            // 
            // TIPO
            // 
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.Name = "TIPO";
            this.TIPO.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblMeneda
            // 
            this.lblMeneda.AutoSize = true;
            this.lblMeneda.Location = new System.Drawing.Point(243, 69);
            this.lblMeneda.Name = "lblMeneda";
            this.lblMeneda.Size = new System.Drawing.Size(13, 15);
            this.lblMeneda.TabIndex = 12;
            this.lblMeneda.Text = "$";
            // 
            // lblPrecio_Data
            // 
            this.lblPrecio_Data.AutoSize = true;
            this.lblPrecio_Data.Location = new System.Drawing.Point(254, 69);
            this.lblPrecio_Data.Name = "lblPrecio_Data";
            this.lblPrecio_Data.Size = new System.Drawing.Size(25, 15);
            this.lblPrecio_Data.TabIndex = 13;
            this.lblPrecio_Data.Text = "200";
            // 
            // frmCartuchera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(972, 553);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTitulo);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCartuchera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCartuchera_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tckPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel pnlTitulo;
        private Panel pnlMenu;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnMenuSerializar;
        private Button btnTickets;
        private Button btnDeserializar;
        private Button btnSerializar;
        private Button btnHamburguesa;
        private Panel pnlBody;
        private DataGridView dgvTabla;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn PRECIO;
        private DataGridViewTextBoxColumn MARCA;
        private DataGridViewTextBoxColumn COLOR;
        private DataGridViewTextBoxColumn MATERIAL;
        private DataGridViewTextBoxColumn TIPO;
        private Button btnMinimizar;
        private Button btnMaximizar;
        private Button btnCerrar;
        private GroupBox grpDatos;
        private ComboBox cmbTipo;
        private ComboBox cmbMaterial;
        private ComboBox cmbColor;
        private TrackBar tckPrecio;
        private TextBox txtMarca;
        private Label lblId_data;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label lblMarca;
        private Label lblPrecio;
        private Label lblId;
        private ContextMenuStrip contextMenuStrip1;
        private Label lblPrecio_Data;
        private Label lblMeneda;
    }
}