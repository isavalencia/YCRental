
namespace Car
{
    partial class ContratoDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContratoDetalle));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgContratos = new System.Windows.Forms.DataGridView();
            this.lblBuscador = new System.Windows.Forms.Label();
            this.btnNuevoContrato = new System.Windows.Forms.Button();
            this.btnEditarContrato = new System.Windows.Forms.Button();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.btnPdfContrato = new System.Windows.Forms.Button();
            this.lblContrato = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminarContrato = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgContratos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMinimizar);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1469, 48);
            this.panel2.TabIndex = 100;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1293, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(85, 48);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1378, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(91, 48);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // dgContratos
            // 
            this.dgContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgContratos.Location = new System.Drawing.Point(12, 210);
            this.dgContratos.Name = "dgContratos";
            this.dgContratos.RowHeadersWidth = 51;
            this.dgContratos.RowTemplate.Height = 24;
            this.dgContratos.Size = new System.Drawing.Size(1261, 484);
            this.dgContratos.TabIndex = 91;
            // 
            // lblBuscador
            // 
            this.lblBuscador.AutoSize = true;
            this.lblBuscador.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscador.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblBuscador.Location = new System.Drawing.Point(722, 168);
            this.lblBuscador.Name = "lblBuscador";
            this.lblBuscador.Size = new System.Drawing.Size(85, 27);
            this.lblBuscador.TabIndex = 99;
            this.lblBuscador.Text = "Buscar:";
            // 
            // btnNuevoContrato
            // 
            this.btnNuevoContrato.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNuevoContrato.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnNuevoContrato.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnNuevoContrato.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoContrato.Image")));
            this.btnNuevoContrato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoContrato.Location = new System.Drawing.Point(12, 131);
            this.btnNuevoContrato.Name = "btnNuevoContrato";
            this.btnNuevoContrato.Size = new System.Drawing.Size(285, 64);
            this.btnNuevoContrato.TabIndex = 93;
            this.btnNuevoContrato.Text = "Nuevo Contrato";
            this.btnNuevoContrato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoContrato.UseVisualStyleBackColor = false;
            // 
            // btnEditarContrato
            // 
            this.btnEditarContrato.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEditarContrato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditarContrato.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnEditarContrato.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnEditarContrato.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarContrato.Image")));
            this.btnEditarContrato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarContrato.Location = new System.Drawing.Point(1280, 210);
            this.btnEditarContrato.Name = "btnEditarContrato";
            this.btnEditarContrato.Size = new System.Drawing.Size(164, 57);
            this.btnEditarContrato.TabIndex = 94;
            this.btnEditarContrato.Text = "Editar";
            this.btnEditarContrato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarContrato.UseVisualStyleBackColor = false;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(813, 173);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(294, 22);
            this.txtbusqueda.TabIndex = 98;
            // 
            // btnPdfContrato
            // 
            this.btnPdfContrato.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPdfContrato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPdfContrato.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnPdfContrato.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnPdfContrato.Image = ((System.Drawing.Image)(resources.GetObject("btnPdfContrato.Image")));
            this.btnPdfContrato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPdfContrato.Location = new System.Drawing.Point(1312, 606);
            this.btnPdfContrato.Name = "btnPdfContrato";
            this.btnPdfContrato.Size = new System.Drawing.Size(116, 68);
            this.btnPdfContrato.TabIndex = 96;
            this.btnPdfContrato.Text = " PDF";
            this.btnPdfContrato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPdfContrato.UseVisualStyleBackColor = false;
            // 
            // lblContrato
            // 
            this.lblContrato.AutoSize = true;
            this.lblContrato.BackColor = System.Drawing.Color.Snow;
            this.lblContrato.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblContrato.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrato.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblContrato.Location = new System.Drawing.Point(467, 87);
            this.lblContrato.Name = "lblContrato";
            this.lblContrato.Size = new System.Drawing.Size(340, 37);
            this.lblContrato.TabIndex = 92;
            this.lblContrato.Text = " Contratos Registrados";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1152, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 97;
            this.pictureBox1.TabStop = false;
            // 
            // btnEliminarContrato
            // 
            this.btnEliminarContrato.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEliminarContrato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEliminarContrato.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnEliminarContrato.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnEliminarContrato.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarContrato.Image")));
            this.btnEliminarContrato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarContrato.Location = new System.Drawing.Point(1280, 273);
            this.btnEliminarContrato.Name = "btnEliminarContrato";
            this.btnEliminarContrato.Size = new System.Drawing.Size(164, 55);
            this.btnEliminarContrato.TabIndex = 95;
            this.btnEliminarContrato.Text = "Eliminar";
            this.btnEliminarContrato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarContrato.UseVisualStyleBackColor = false;
            // 
            // ContratoDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 718);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgContratos);
            this.Controls.Add(this.lblBuscador);
            this.Controls.Add(this.btnNuevoContrato);
            this.Controls.Add(this.btnEditarContrato);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.btnPdfContrato);
            this.Controls.Add(this.lblContrato);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEliminarContrato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContratoDetalle";
            this.Text = "ContratoDetalle";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgContratos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgContratos;
        private System.Windows.Forms.Label lblBuscador;
        private System.Windows.Forms.Button btnNuevoContrato;
        private System.Windows.Forms.Button btnEditarContrato;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Button btnPdfContrato;
        private System.Windows.Forms.Label lblContrato;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEliminarContrato;
    }
}