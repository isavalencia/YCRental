
namespace Car
{
    partial class RegistroReservas
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
            System.Windows.Forms.Panel panelTituloRegistroReserva;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroReservas));
            this.label2 = new System.Windows.Forms.Label();
            this.btnMinim = new System.Windows.Forms.Button();
            this.btnMaxi = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.btnGuardarReserva = new System.Windows.Forms.Button();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.cbxVehiculo = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cbxEmpleado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            panelTituloRegistroReserva = new System.Windows.Forms.Panel();
            panelTituloRegistroReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTituloRegistroReserva
            // 
            panelTituloRegistroReserva.BackColor = System.Drawing.SystemColors.HighlightText;
            panelTituloRegistroReserva.Controls.Add(this.label2);
            panelTituloRegistroReserva.Controls.Add(this.btnMinim);
            panelTituloRegistroReserva.Controls.Add(this.btnMaxi);
            panelTituloRegistroReserva.Controls.Add(this.btnCerrar);
            panelTituloRegistroReserva.Dock = System.Windows.Forms.DockStyle.Top;
            panelTituloRegistroReserva.Location = new System.Drawing.Point(0, 0);
            panelTituloRegistroReserva.Name = "panelTituloRegistroReserva";
            panelTituloRegistroReserva.Size = new System.Drawing.Size(632, 28);
            panelTituloRegistroReserva.TabIndex = 66;
            panelTituloRegistroReserva.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTituloRegistroReserva_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Registro Reserva";
            // 
            // btnMinim
            // 
            this.btnMinim.BackColor = System.Drawing.Color.Transparent;
            this.btnMinim.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinim.FlatAppearance.BorderSize = 0;
            this.btnMinim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinim.Image = ((System.Drawing.Image)(resources.GetObject("btnMinim.Image")));
            this.btnMinim.Location = new System.Drawing.Point(502, 0);
            this.btnMinim.Name = "btnMinim";
            this.btnMinim.Size = new System.Drawing.Size(47, 28);
            this.btnMinim.TabIndex = 7;
            this.btnMinim.UseVisualStyleBackColor = false;
            this.btnMinim.Click += new System.EventHandler(this.btnMinim_Click);
            // 
            // btnMaxi
            // 
            this.btnMaxi.BackColor = System.Drawing.Color.Transparent;
            this.btnMaxi.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaxi.FlatAppearance.BorderSize = 0;
            this.btnMaxi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxi.Image = ((System.Drawing.Image)(resources.GetObject("btnMaxi.Image")));
            this.btnMaxi.Location = new System.Drawing.Point(549, 0);
            this.btnMaxi.Name = "btnMaxi";
            this.btnMaxi.Size = new System.Drawing.Size(44, 28);
            this.btnMaxi.TabIndex = 9;
            this.btnMaxi.UseVisualStyleBackColor = false;
            this.btnMaxi.Click += new System.EventHandler(this.btnMaxi_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(593, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(39, 28);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(466, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(43, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 68;
            this.label1.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(43, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 69;
            this.label3.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(43, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 70;
            this.label4.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(385, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 71;
            this.label5.Text = "Vehiculo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(385, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 72;
            this.label6.Text = "Hora:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(124, 384);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 74;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(124, 446);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(91, 20);
            this.txtPrecio.TabIndex = 75;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(445, 362);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(100, 20);
            this.txtHora.TabIndex = 77;
            // 
            // btnGuardarReserva
            // 
            this.btnGuardarReserva.BackColor = System.Drawing.Color.Salmon;
            this.btnGuardarReserva.FlatAppearance.BorderSize = 0;
            this.btnGuardarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarReserva.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarReserva.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarReserva.Location = new System.Drawing.Point(340, 476);
            this.btnGuardarReserva.Name = "btnGuardarReserva";
            this.btnGuardarReserva.Size = new System.Drawing.Size(111, 38);
            this.btnGuardarReserva.TabIndex = 78;
            this.btnGuardarReserva.Text = "Guardar";
            this.btnGuardarReserva.UseVisualStyleBackColor = false;
            this.btnGuardarReserva.Click += new System.EventHandler(this.btnGuardarReserva_Click);
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Items.AddRange(new object[] {
            ""});
            this.cbxCliente.Location = new System.Drawing.Point(124, 309);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(121, 21);
            this.cbxCliente.TabIndex = 79;
            this.cbxCliente.SelectedIndexChanged += new System.EventHandler(this.cbxCliente_SelectedIndexChanged);
            // 
            // cbxVehiculo
            // 
            this.cbxVehiculo.FormattingEnabled = true;
            this.cbxVehiculo.Location = new System.Drawing.Point(472, 303);
            this.cbxVehiculo.Name = "cbxVehiculo";
            this.cbxVehiculo.Size = new System.Drawing.Size(121, 21);
            this.cbxVehiculo.TabIndex = 80;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Salmon;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.Location = new System.Drawing.Point(457, 476);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(111, 38);
            this.btnLimpiar.TabIndex = 81;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cbxEmpleado
            // 
            this.cbxEmpleado.FormattingEnabled = true;
            this.cbxEmpleado.Location = new System.Drawing.Point(472, 426);
            this.cbxEmpleado.Name = "cbxEmpleado";
            this.cbxEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cbxEmpleado.TabIndex = 83;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(374, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 18);
            this.label7.TabIndex = 82;
            this.label7.Text = "Empleado:";
            // 
            // RegistroReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(632, 546);
            this.Controls.Add(this.cbxEmpleado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cbxVehiculo);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.btnGuardarReserva);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(panelTituloRegistroReserva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroReservas";
            this.Text = "RegistroReservas";
            this.Load += new System.EventHandler(this.RegistroReservas_Load);
            panelTituloRegistroReserva.ResumeLayout(false);
            panelTituloRegistroReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMinim;
        private System.Windows.Forms.Button btnMaxi;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuardarReserva;
        public System.Windows.Forms.TextBox txtHora;
        public System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DateTimePicker dtpFecha;
        public System.Windows.Forms.ComboBox cbxCliente;
        public System.Windows.Forms.ComboBox cbxVehiculo;
        public System.Windows.Forms.ComboBox cbxEmpleado;
    }
}