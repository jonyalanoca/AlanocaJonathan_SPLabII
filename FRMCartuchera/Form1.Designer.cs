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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCartuchera));
            this.pnlTitulo = new System.Windows.Forms.Panel();
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
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATERIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTitulo.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(141)))), ((int)(((byte)(179)))));
            this.pnlTitulo.Controls.Add(this.btnCerrar);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(972, 30);
            this.pnlTitulo.TabIndex = 2;
            this.pnlTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitulo_Paint);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(942, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "X";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.button4_Click);
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
            this.pnlBody.BackColor = System.Drawing.Color.Lime;
            this.pnlBody.Controls.Add(this.dgvTabla);
            this.pnlBody.Location = new System.Drawing.Point(334, 130);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(602, 336);
            this.pnlBody.TabIndex = 4;
            // 
            // dgvTabla
            // 
            this.dgvTabla.AllowUserToAddRows = false;
            this.dgvTabla.AllowUserToDeleteRows = false;
            this.dgvTabla.AllowUserToResizeColumns = false;
            this.dgvTabla.AllowUserToResizeRows = false;
            this.dgvTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PRECIO,
            this.MARCA,
            this.COLOR,
            this.MATERIAL,
            this.TIPO});
            this.dgvTabla.Location = new System.Drawing.Point(49, 50);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.RowTemplate.Height = 25;
            this.dgvTabla.Size = new System.Drawing.Size(526, 269);
            this.dgvTabla.TabIndex = 0;
            this.dgvTabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabla_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // PRECIO
            // 
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.Name = "PRECIO";
            // 
            // MARCA
            // 
            this.MARCA.HeaderText = "MARCA";
            this.MARCA.Name = "MARCA";
            // 
            // COLOR
            // 
            this.COLOR.HeaderText = "COLOR";
            this.COLOR.Name = "COLOR";
            // 
            // MATERIAL
            // 
            this.MATERIAL.HeaderText = "MATERIAL";
            this.MATERIAL.Name = "MATERIAL";
            // 
            // TIPO
            // 
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.Name = "TIPO";
            // 
            // frmCartuchera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(972, 553);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTitulo);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCartuchera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCartuchera_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel pnlTitulo;
        private Panel pnlMenu;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnCerrar;
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
    }
}