namespace FRMCartuchera
{
    partial class frmOpcion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOpcion));
            this.btnOpcionGoma = new System.Windows.Forms.Button();
            this.btnOpcionLapiz = new System.Windows.Forms.Button();
            this.btnOpcionSacapuntas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpcionGoma
            // 
            this.btnOpcionGoma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnOpcionGoma.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(30)))));
            this.btnOpcionGoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpcionGoma.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOpcionGoma.ForeColor = System.Drawing.Color.White;
            this.btnOpcionGoma.Image = ((System.Drawing.Image)(resources.GetObject("btnOpcionGoma.Image")));
            this.btnOpcionGoma.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOpcionGoma.Location = new System.Drawing.Point(12, 12);
            this.btnOpcionGoma.Name = "btnOpcionGoma";
            this.btnOpcionGoma.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.btnOpcionGoma.Size = new System.Drawing.Size(176, 262);
            this.btnOpcionGoma.TabIndex = 0;
            this.btnOpcionGoma.Text = "Agregar Goma";
            this.btnOpcionGoma.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOpcionGoma.UseVisualStyleBackColor = false;
            this.btnOpcionGoma.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOpcionLapiz
            // 
            this.btnOpcionLapiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnOpcionLapiz.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(30)))));
            this.btnOpcionLapiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpcionLapiz.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOpcionLapiz.ForeColor = System.Drawing.Color.White;
            this.btnOpcionLapiz.Image = ((System.Drawing.Image)(resources.GetObject("btnOpcionLapiz.Image")));
            this.btnOpcionLapiz.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOpcionLapiz.Location = new System.Drawing.Point(194, 12);
            this.btnOpcionLapiz.Name = "btnOpcionLapiz";
            this.btnOpcionLapiz.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.btnOpcionLapiz.Size = new System.Drawing.Size(176, 262);
            this.btnOpcionLapiz.TabIndex = 1;
            this.btnOpcionLapiz.Text = "Agregar Lapiz";
            this.btnOpcionLapiz.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOpcionLapiz.UseVisualStyleBackColor = false;
            this.btnOpcionLapiz.Click += new System.EventHandler(this.btnOpcionLapiz_Click);
            // 
            // btnOpcionSacapuntas
            // 
            this.btnOpcionSacapuntas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnOpcionSacapuntas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(30)))));
            this.btnOpcionSacapuntas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpcionSacapuntas.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOpcionSacapuntas.ForeColor = System.Drawing.Color.White;
            this.btnOpcionSacapuntas.Image = ((System.Drawing.Image)(resources.GetObject("btnOpcionSacapuntas.Image")));
            this.btnOpcionSacapuntas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOpcionSacapuntas.Location = new System.Drawing.Point(376, 12);
            this.btnOpcionSacapuntas.Name = "btnOpcionSacapuntas";
            this.btnOpcionSacapuntas.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.btnOpcionSacapuntas.Size = new System.Drawing.Size(176, 262);
            this.btnOpcionSacapuntas.TabIndex = 2;
            this.btnOpcionSacapuntas.Text = "Agregar Sacapuntas";
            this.btnOpcionSacapuntas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOpcionSacapuntas.UseVisualStyleBackColor = false;
            this.btnOpcionSacapuntas.Click += new System.EventHandler(this.btnOpcionSacapuntas_Click);
            // 
            // frmOpcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(563, 283);
            this.Controls.Add(this.btnOpcionSacapuntas);
            this.Controls.Add(this.btnOpcionLapiz);
            this.Controls.Add(this.btnOpcionGoma);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOpcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOpcion";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnOpcionGoma;
        private Button btnOpcionLapiz;
        private Button btnOpcionSacapuntas;
    }
}