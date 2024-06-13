namespace presentacion
{
    partial class frmListadoArticulo
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbImagenArticulo = new System.Windows.Forms.PictureBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.tbFiltroBR = new System.Windows.Forms.TextBox();
            this.lblFiltroBR = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.tbFiltro = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.cbCriterio = new System.Windows.Forms.ComboBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.cbCampo = new System.Windows.Forms.ComboBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.rbFiltroAvanzado = new System.Windows.Forms.RadioButton();
            this.rbFiltroRapido = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenArticulo)).BeginInit();
            this.panelFiltros.SuspendLayout();
            this.gbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(1, 105);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.Size = new System.Drawing.Size(481, 406);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pbImagenArticulo
            // 
            this.pbImagenArticulo.Location = new System.Drawing.Point(488, 105);
            this.pbImagenArticulo.Name = "pbImagenArticulo";
            this.pbImagenArticulo.Size = new System.Drawing.Size(232, 305);
            this.pbImagenArticulo.TabIndex = 1;
            this.pbImagenArticulo.TabStop = false;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(488, 416);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(232, 95);
            this.tbDescripcion.TabIndex = 2;
            // 
            // panelFiltros
            // 
            this.panelFiltros.BackColor = System.Drawing.Color.RosyBrown;
            this.panelFiltros.Controls.Add(this.tbFiltroBR);
            this.panelFiltros.Controls.Add(this.lblFiltroBR);
            this.panelFiltros.Controls.Add(this.btnFiltrar);
            this.panelFiltros.Controls.Add(this.tbFiltro);
            this.panelFiltros.Controls.Add(this.lblFiltro);
            this.panelFiltros.Controls.Add(this.cbCriterio);
            this.panelFiltros.Controls.Add(this.lblCriterio);
            this.panelFiltros.Controls.Add(this.cbCampo);
            this.panelFiltros.Controls.Add(this.lblCampo);
            this.panelFiltros.Controls.Add(this.btnLimpiarFiltro);
            this.panelFiltros.Controls.Add(this.gbFiltros);
            this.panelFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltros.Location = new System.Drawing.Point(0, 0);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(724, 100);
            this.panelFiltros.TabIndex = 3;
            // 
            // tbFiltroBR
            // 
            this.tbFiltroBR.Location = new System.Drawing.Point(277, 7);
            this.tbFiltroBR.Name = "tbFiltroBR";
            this.tbFiltroBR.Size = new System.Drawing.Size(121, 20);
            this.tbFiltroBR.TabIndex = 31;
            this.tbFiltroBR.TextChanged += new System.EventHandler(this.tbFiltroBR_TextChanged);
            // 
            // lblFiltroBR
            // 
            this.lblFiltroBR.AutoSize = true;
            this.lblFiltroBR.Location = new System.Drawing.Point(246, 12);
            this.lblFiltroBR.Name = "lblFiltroBR";
            this.lblFiltroBR.Size = new System.Drawing.Size(29, 13);
            this.lblFiltroBR.TabIndex = 30;
            this.lblFiltroBR.Text = "Filtro";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(573, 70);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(94, 23);
            this.btnFiltrar.TabIndex = 29;
            this.btnFiltrar.Text = "Buscar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // tbFiltro
            // 
            this.tbFiltro.Location = new System.Drawing.Point(446, 31);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(121, 20);
            this.tbFiltro.TabIndex = 28;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(415, 36);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(29, 13);
            this.lblFiltro.TabIndex = 27;
            this.lblFiltro.Text = "Filtro";
            // 
            // cbCriterio
            // 
            this.cbCriterio.FormattingEnabled = true;
            this.cbCriterio.Location = new System.Drawing.Point(277, 33);
            this.cbCriterio.Name = "cbCriterio";
            this.cbCriterio.Size = new System.Drawing.Size(121, 21);
            this.cbCriterio.TabIndex = 26;
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(235, 38);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(39, 13);
            this.lblCriterio.TabIndex = 25;
            this.lblCriterio.Text = "Criterio";
            // 
            // cbCampo
            // 
            this.cbCampo.FormattingEnabled = true;
            this.cbCampo.Location = new System.Drawing.Point(94, 33);
            this.cbCampo.Name = "cbCampo";
            this.cbCampo.Size = new System.Drawing.Size(121, 21);
            this.cbCampo.TabIndex = 24;
            this.cbCampo.SelectedIndexChanged += new System.EventHandler(this.cbCampo_SelectedIndexChanged);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(52, 38);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(40, 13);
            this.lblCampo.TabIndex = 23;
            this.lblCampo.Text = "Campo";
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(573, 42);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(94, 23);
            this.btnLimpiarFiltro.TabIndex = 22;
            this.btnLimpiarFiltro.Text = "Limpiar Todo";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltro.Click += new System.EventHandler(this.btnLimpiarFiltro_Click);
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.rbFiltroAvanzado);
            this.gbFiltros.Controls.Add(this.rbFiltroRapido);
            this.gbFiltros.Location = new System.Drawing.Point(55, 52);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(216, 39);
            this.gbFiltros.TabIndex = 21;
            this.gbFiltros.TabStop = false;
            // 
            // rbFiltroAvanzado
            // 
            this.rbFiltroAvanzado.AutoSize = true;
            this.rbFiltroAvanzado.Location = new System.Drawing.Point(112, 15);
            this.rbFiltroAvanzado.Name = "rbFiltroAvanzado";
            this.rbFiltroAvanzado.Size = new System.Drawing.Size(98, 17);
            this.rbFiltroAvanzado.TabIndex = 2;
            this.rbFiltroAvanzado.TabStop = true;
            this.rbFiltroAvanzado.Text = "Filtro Avanzado";
            this.rbFiltroAvanzado.UseVisualStyleBackColor = true;
            this.rbFiltroAvanzado.CheckedChanged += new System.EventHandler(this.rbFiltroAvanzado_CheckedChanged);
            // 
            // rbFiltroRapido
            // 
            this.rbFiltroRapido.AutoSize = true;
            this.rbFiltroRapido.Location = new System.Drawing.Point(6, 15);
            this.rbFiltroRapido.Name = "rbFiltroRapido";
            this.rbFiltroRapido.Size = new System.Drawing.Size(84, 17);
            this.rbFiltroRapido.TabIndex = 1;
            this.rbFiltroRapido.TabStop = true;
            this.rbFiltroRapido.Text = "Filtro Rapido";
            this.rbFiltroRapido.UseVisualStyleBackColor = true;
            this.rbFiltroRapido.CheckedChanged += new System.EventHandler(this.rbFiltroRapido_CheckedChanged);
            // 
            // frmListadoArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 513);
            this.Controls.Add(this.panelFiltros);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.pbImagenArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListadoArticulo";
            this.Text = "frmListadoArticulo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListadoArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenArticulo)).EndInit();
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbImagenArticulo;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.TextBox tbFiltroBR;
        private System.Windows.Forms.Label lblFiltroBR;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox tbFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ComboBox cbCriterio;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.ComboBox cbCampo;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Button btnLimpiarFiltro;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.RadioButton rbFiltroAvanzado;
        private System.Windows.Forms.RadioButton rbFiltroRapido;
    }
}