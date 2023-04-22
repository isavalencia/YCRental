
namespace Car
{
    partial class ConsultaReservas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaReservas));
            this.panelTituloConsultaReservas = new System.Windows.Forms.Panel();
            this.btnMinim = new System.Windows.Forms.Button();
            this.btnMaxi = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.btnNuevaReserva = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReporteReserva = new System.Windows.Forms.Button();
            this.panelTituloConsultaReservas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTituloConsultaReservas
            // 
            this.panelTituloConsultaReservas.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panelTituloConsultaReservas.Controls.Add(this.btnMinim);
            this.panelTituloConsultaReservas.Controls.Add(this.btnMaxi);
            this.panelTituloConsultaReservas.Controls.Add(this.btnCerrar);
            this.panelTituloConsultaReservas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloConsultaReservas.Location = new System.Drawing.Point(0, 0);
            this.panelTituloConsultaReservas.Name = "panelTituloConsultaReservas";
            this.panelTituloConsultaReservas.Size = new System.Drawing.Size(1075, 28);
            this.panelTituloConsultaReservas.TabIndex = 66;
            this.panelTituloConsultaReservas.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTituloRegistroAlquiler_Paint);
            this.panelTituloConsultaReservas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTituloConsultaReservas_MouseMove);
            // 
            // btnMinim
            // 
            this.btnMinim.BackColor = System.Drawing.Color.Transparent;
            this.btnMinim.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinim.FlatAppearance.BorderSize = 0;
            this.btnMinim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinim.Image = ((System.Drawing.Image)(resources.GetObject("btnMinim.Image")));
            this.btnMinim.Location = new System.Drawing.Point(945, 0);
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
            this.btnMaxi.Location = new System.Drawing.Point(992, 0);
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
            this.btnCerrar.Location = new System.Drawing.Point(1036, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(39, 28);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvReservas
            // 
            this.dgvReservas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(12, 147);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.Size = new System.Drawing.Size(886, 383);
            this.dgvReservas.TabIndex = 67;
            this.dgvReservas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservas_CellContentClick);
            // 
            // btnNuevaReserva
            // 
            this.btnNuevaReserva.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNuevaReserva.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaReserva.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNuevaReserva.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevaReserva.Image")));
            this.btnNuevaReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaReserva.Location = new System.Drawing.Point(12, 95);
            this.btnNuevaReserva.Name = "btnNuevaReserva";
            this.btnNuevaReserva.Size = new System.Drawing.Size(195, 46);
            this.btnNuevaReserva.TabIndex = 68;
            this.btnNuevaReserva.Text = "Nueva Reserva";
            this.btnNuevaReserva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevaReserva.UseVisualStyleBackColor = false;
            this.btnNuevaReserva.Click += new System.EventHandler(this.btnNuevaReserva_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEditar.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(904, 147);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(146, 46);
            this.btnEditar.TabIndex = 69;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEliminar.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(904, 214);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(146, 46);
            this.btnEliminar.TabIndex = 70;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(658, 121);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(203, 20);
            this.txtBuscar.TabIndex = 71;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(867, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // btnReporteReserva
            // 
            this.btnReporteReserva.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnReporteReserva.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteReserva.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReporteReserva.Image = ((System.Drawing.Image)(resources.GetObject("btnReporteReserva.Image")));
            this.btnReporteReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteReserva.Location = new System.Drawing.Point(917, 484);
            this.btnReporteReserva.Name = "btnReporteReserva";
            this.btnReporteReserva.Size = new System.Drawing.Size(146, 46);
            this.btnReporteReserva.TabIndex = 77;
            this.btnReporteReserva.Text = "Reporte";
            this.btnReporteReserva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReporteReserva.UseVisualStyleBackColor = false;
            this.btnReporteReserva.Click += new System.EventHandler(this.btnReporteReserva_Click);
            // 
            // ConsultaReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 542);
            this.Controls.Add(this.btnReporteReserva);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevaReserva);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.panelTituloConsultaReservas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaReservas";
            this.Text = "ConsultaAlquileres";
            this.Load += new System.EventHandler(this.ConsultaReservas_Load);
            this.panelTituloConsultaReservas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTituloConsultaReservas;
        private System.Windows.Forms.Button btnMinim;
        private System.Windows.Forms.Button btnMaxi;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Button btnNuevaReserva;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReporteReserva;
    }
}