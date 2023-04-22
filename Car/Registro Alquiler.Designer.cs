
namespace Car
{
    partial class Registro_Alquiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_Alquiler));
            this.panelTituloRegistroAlquiler = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMinim = new System.Windows.Forms.Button();
            this.btnMaxi = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpFechaIniAlquiler = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinaliAlquiler = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.cbxCVehiculo = new System.Windows.Forms.ComboBox();
            this.cbxEstadoAl = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardarAlquiler = new System.Windows.Forms.Button();
            this.txtCostoAlqui = new System.Windows.Forms.TextBox();
            this.panelTituloRegistroAlquiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTituloRegistroAlquiler
            // 
            this.panelTituloRegistroAlquiler.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panelTituloRegistroAlquiler.Controls.Add(this.label4);
            this.panelTituloRegistroAlquiler.Controls.Add(this.btnMinim);
            this.panelTituloRegistroAlquiler.Controls.Add(this.btnMaxi);
            this.panelTituloRegistroAlquiler.Controls.Add(this.btnCerrar);
            this.panelTituloRegistroAlquiler.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloRegistroAlquiler.Location = new System.Drawing.Point(0, 0);
            this.panelTituloRegistroAlquiler.Name = "panelTituloRegistroAlquiler";
            this.panelTituloRegistroAlquiler.Size = new System.Drawing.Size(809, 28);
            this.panelTituloRegistroAlquiler.TabIndex = 65;
            this.panelTituloRegistroAlquiler.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTituloRegistroAlquiler_Paint);
            this.panelTituloRegistroAlquiler.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTituloRegistroAlquiler_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 18);
            this.label4.TabIndex = 76;
            this.label4.Text = "Registro Alquiler";
            // 
            // btnMinim
            // 
            this.btnMinim.BackColor = System.Drawing.Color.Transparent;
            this.btnMinim.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinim.FlatAppearance.BorderSize = 0;
            this.btnMinim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinim.Image = ((System.Drawing.Image)(resources.GetObject("btnMinim.Image")));
            this.btnMinim.Location = new System.Drawing.Point(679, 0);
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
            this.btnMaxi.Location = new System.Drawing.Point(726, 0);
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
            this.btnCerrar.Location = new System.Drawing.Point(770, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(39, 28);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(129, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(466, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // dtpFechaIniAlquiler
            // 
            this.dtpFechaIniAlquiler.CalendarFont = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaIniAlquiler.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaIniAlquiler.Location = new System.Drawing.Point(256, 321);
            this.dtpFechaIniAlquiler.Name = "dtpFechaIniAlquiler";
            this.dtpFechaIniAlquiler.Size = new System.Drawing.Size(231, 23);
            this.dtpFechaIniAlquiler.TabIndex = 68;
            // 
            // dtpFechaFinaliAlquiler
            // 
            this.dtpFechaFinaliAlquiler.CalendarFont = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFinaliAlquiler.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFinaliAlquiler.Location = new System.Drawing.Point(530, 321);
            this.dtpFechaFinaliAlquiler.Name = "dtpFechaFinaliAlquiler";
            this.dtpFechaFinaliAlquiler.Size = new System.Drawing.Size(230, 23);
            this.dtpFechaFinaliAlquiler.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(514, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 70;
            this.label1.Text = "Condición Vehiculo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 71;
            this.label2.Text = "Inicio Alquiler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(571, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 18);
            this.label3.TabIndex = 72;
            this.label3.Text = "Finalización Alquiler";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(108, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 76;
            this.label5.Text = "Cliente:";
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(82, 321);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(121, 21);
            this.cbxCliente.TabIndex = 77;
            // 
            // cbxCVehiculo
            // 
            this.cbxCVehiculo.FormattingEnabled = true;
            this.cbxCVehiculo.Location = new System.Drawing.Point(527, 427);
            this.cbxCVehiculo.Name = "cbxCVehiculo";
            this.cbxCVehiculo.Size = new System.Drawing.Size(121, 21);
            this.cbxCVehiculo.TabIndex = 78;
            // 
            // cbxEstadoAl
            // 
            this.cbxEstadoAl.FormattingEnabled = true;
            this.cbxEstadoAl.Location = new System.Drawing.Point(335, 427);
            this.cbxEstadoAl.Name = "cbxEstadoAl";
            this.cbxEstadoAl.Size = new System.Drawing.Size(121, 21);
            this.cbxEstadoAl.TabIndex = 80;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(335, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 18);
            this.label6.TabIndex = 79;
            this.label6.Text = "Estado Alquiler";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(178, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 18);
            this.label7.TabIndex = 82;
            this.label7.Text = "Costo Alquiler";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Salmon;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.Location = new System.Drawing.Point(629, 484);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(111, 38);
            this.btnLimpiar.TabIndex = 86;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardarAlquiler
            // 
            this.btnGuardarAlquiler.BackColor = System.Drawing.Color.Salmon;
            this.btnGuardarAlquiler.FlatAppearance.BorderSize = 0;
            this.btnGuardarAlquiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarAlquiler.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarAlquiler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarAlquiler.Location = new System.Drawing.Point(512, 484);
            this.btnGuardarAlquiler.Name = "btnGuardarAlquiler";
            this.btnGuardarAlquiler.Size = new System.Drawing.Size(111, 38);
            this.btnGuardarAlquiler.TabIndex = 85;
            this.btnGuardarAlquiler.Text = "Guardar";
            this.btnGuardarAlquiler.UseVisualStyleBackColor = false;
            this.btnGuardarAlquiler.Click += new System.EventHandler(this.btnGuardarAlquiler_Click);
            // 
            // txtCostoAlqui
            // 
            this.txtCostoAlqui.Location = new System.Drawing.Point(181, 427);
            this.txtCostoAlqui.Name = "txtCostoAlqui";
            this.txtCostoAlqui.Size = new System.Drawing.Size(100, 20);
            this.txtCostoAlqui.TabIndex = 87;
            // 
            // Registro_Alquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(809, 544);
            this.Controls.Add(this.txtCostoAlqui);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardarAlquiler);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxEstadoAl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxCVehiculo);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaFinaliAlquiler);
            this.Controls.Add(this.dtpFechaIniAlquiler);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelTituloRegistroAlquiler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro_Alquiler";
            this.Text = "Registro_Alquiler";
            this.Load += new System.EventHandler(this.Registro_Alquiler_Load);
            this.panelTituloRegistroAlquiler.ResumeLayout(false);
            this.panelTituloRegistroAlquiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTituloRegistroAlquiler;
        private System.Windows.Forms.Button btnMinim;
        private System.Windows.Forms.Button btnMaxi;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cbxCliente;
        public System.Windows.Forms.DateTimePicker dtpFechaIniAlquiler;
        public System.Windows.Forms.DateTimePicker dtpFechaFinaliAlquiler;
        public System.Windows.Forms.ComboBox cbxCVehiculo;
        public System.Windows.Forms.ComboBox cbxEstadoAl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardarAlquiler;
        public System.Windows.Forms.TextBox txtCostoAlqui;
    }
}