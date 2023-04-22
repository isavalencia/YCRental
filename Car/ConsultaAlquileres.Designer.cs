
namespace Car
{
    partial class ConsultaAlquileres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaAlquileres));
            this.panelTituloConsultaAlquileres = new System.Windows.Forms.Panel();
            this.btnMinim = new System.Windows.Forms.Button();
            this.btnMaxi = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnNuevoAlquiler = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvAlquileres = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panelTituloConsultaAlquileres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquileres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTituloConsultaAlquileres
            // 
            this.panelTituloConsultaAlquileres.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panelTituloConsultaAlquileres.Controls.Add(this.btnMinim);
            this.panelTituloConsultaAlquileres.Controls.Add(this.btnMaxi);
            this.panelTituloConsultaAlquileres.Controls.Add(this.btnCerrar);
            this.panelTituloConsultaAlquileres.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloConsultaAlquileres.Location = new System.Drawing.Point(0, 0);
            this.panelTituloConsultaAlquileres.Name = "panelTituloConsultaAlquileres";
            this.panelTituloConsultaAlquileres.Size = new System.Drawing.Size(1073, 28);
            this.panelTituloConsultaAlquileres.TabIndex = 67;
            this.panelTituloConsultaAlquileres.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTituloConsultaAlquileres_MouseMove);
            // 
            // btnMinim
            // 
            this.btnMinim.BackColor = System.Drawing.Color.Transparent;
            this.btnMinim.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinim.FlatAppearance.BorderSize = 0;
            this.btnMinim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinim.Image = ((System.Drawing.Image)(resources.GetObject("btnMinim.Image")));
            this.btnMinim.Location = new System.Drawing.Point(943, 0);
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
            this.btnMaxi.Location = new System.Drawing.Point(990, 0);
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
            this.btnCerrar.Location = new System.Drawing.Point(1034, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(39, 28);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnNuevoAlquiler
            // 
            this.btnNuevoAlquiler.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNuevoAlquiler.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoAlquiler.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNuevoAlquiler.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoAlquiler.Image")));
            this.btnNuevoAlquiler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoAlquiler.Location = new System.Drawing.Point(12, 97);
            this.btnNuevoAlquiler.Name = "btnNuevoAlquiler";
            this.btnNuevoAlquiler.Size = new System.Drawing.Size(195, 46);
            this.btnNuevoAlquiler.TabIndex = 69;
            this.btnNuevoAlquiler.Text = "Nueva Reserva";
            this.btnNuevoAlquiler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoAlquiler.UseVisualStyleBackColor = false;
            this.btnNuevoAlquiler.Click += new System.EventHandler(this.btnNuevoAlquiler_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEliminar.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(915, 232);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(146, 46);
            this.btnEliminar.TabIndex = 72;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEditar.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(915, 165);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(146, 46);
            this.btnEditar.TabIndex = 71;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvAlquileres
            // 
            this.dgvAlquileres.AllowUserToAddRows = false;
            this.dgvAlquileres.AllowUserToDeleteRows = false;
            this.dgvAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlquileres.Location = new System.Drawing.Point(12, 149);
            this.dgvAlquileres.Name = "dgvAlquileres";
            this.dgvAlquileres.ReadOnly = true;
            this.dgvAlquileres.Size = new System.Drawing.Size(896, 361);
            this.dgvAlquileres.TabIndex = 73;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(884, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(675, 127);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(203, 20);
            this.txtBuscar.TabIndex = 76;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // ConsultaAlquileres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 522);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvAlquileres);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevoAlquiler);
            this.Controls.Add(this.panelTituloConsultaAlquileres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaAlquileres";
            this.Text = "ConsultaAlquileres";
            this.Load += new System.EventHandler(this.ConsultaAlquileres_Load);
            this.panelTituloConsultaAlquileres.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquileres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTituloConsultaAlquileres;
        private System.Windows.Forms.Button btnMinim;
        private System.Windows.Forms.Button btnMaxi;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnNuevoAlquiler;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvAlquileres;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txtBuscar;
    }
}