namespace presentacion
{
    partial class frmPrincipal2
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
            this.panelControles = new System.Windows.Forms.Panel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.pbImagenArticulo = new System.Windows.Forms.PictureBox();
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
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.stastrEstado = new System.Windows.Forms.StatusStrip();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenArticulo)).BeginInit();
            this.gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControles
            // 
            this.panelControles.BackColor = System.Drawing.Color.DarkGray;
            this.panelControles.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControles.Location = new System.Drawing.Point(0, 0);
            this.panelControles.Name = "panelControles";
            this.panelControles.Size = new System.Drawing.Size(155, 531);
            this.panelControles.TabIndex = 0;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.pbImagenArticulo);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(155, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(732, 531);
            this.panelPrincipal.TabIndex = 1;
            // 
            // pbImagenArticulo
            // 
            this.pbImagenArticulo.Location = new System.Drawing.Point(490, 97);
            this.pbImagenArticulo.Name = "pbImagenArticulo";
            this.pbImagenArticulo.Size = new System.Drawing.Size(230, 305);
            this.pbImagenArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagenArticulo.TabIndex = 25;
            this.pbImagenArticulo.TabStop = false;
            // 
            // tbFiltroBR
            // 
            this.tbFiltroBR.Location = new System.Drawing.Point(382, 5);
            this.tbFiltroBR.Name = "tbFiltroBR";
            this.tbFiltroBR.Size = new System.Drawing.Size(121, 20);
            this.tbFiltroBR.TabIndex = 38;
            // 
            // lblFiltroBR
            // 
            this.lblFiltroBR.AutoSize = true;
            this.lblFiltroBR.Location = new System.Drawing.Point(351, 10);
            this.lblFiltroBR.Name = "lblFiltroBR";
            this.lblFiltroBR.Size = new System.Drawing.Size(29, 13);
            this.lblFiltroBR.TabIndex = 37;
            this.lblFiltroBR.Text = "Filtro";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(678, 68);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(94, 23);
            this.btnFiltrar.TabIndex = 36;
            this.btnFiltrar.Text = "Buscar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // tbFiltro
            // 
            this.tbFiltro.Location = new System.Drawing.Point(551, 29);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(121, 20);
            this.tbFiltro.TabIndex = 35;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(520, 34);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(29, 13);
            this.lblFiltro.TabIndex = 34;
            this.lblFiltro.Text = "Filtro";
            // 
            // cbCriterio
            // 
            this.cbCriterio.FormattingEnabled = true;
            this.cbCriterio.Location = new System.Drawing.Point(382, 31);
            this.cbCriterio.Name = "cbCriterio";
            this.cbCriterio.Size = new System.Drawing.Size(121, 21);
            this.cbCriterio.TabIndex = 33;
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(340, 36);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(39, 13);
            this.lblCriterio.TabIndex = 32;
            this.lblCriterio.Text = "Criterio";
            // 
            // cbCampo
            // 
            this.cbCampo.FormattingEnabled = true;
            this.cbCampo.Location = new System.Drawing.Point(199, 31);
            this.cbCampo.Name = "cbCampo";
            this.cbCampo.Size = new System.Drawing.Size(121, 21);
            this.cbCampo.TabIndex = 31;
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(157, 36);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(40, 13);
            this.lblCampo.TabIndex = 30;
            this.lblCampo.Text = "Campo";
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(678, 40);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(94, 23);
            this.btnLimpiarFiltro.TabIndex = 29;
            this.btnLimpiarFiltro.Text = "Limpiar Todo";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = true;
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.rbFiltroAvanzado);
            this.gbFiltros.Controls.Add(this.rbFiltroRapido);
            this.gbFiltros.Location = new System.Drawing.Point(160, 50);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(216, 39);
            this.gbFiltros.TabIndex = 28;
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
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescripcion.Location = new System.Drawing.Point(645, 406);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.ReadOnly = true;
            this.tbDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescripcion.Size = new System.Drawing.Size(232, 95);
            this.tbDescripcion.TabIndex = 27;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(157, 95);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersVisible = false;
            this.dgvArticulos.Size = new System.Drawing.Size(481, 406);
            this.dgvArticulos.TabIndex = 26;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(-1, 123);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(155, 50);
            this.btnAgregar.TabIndex = 24;
            this.btnAgregar.Text = "Agregar Nuevo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(-1, 183);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(154, 50);
            this.btnModificar.TabIndex = 23;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(-1, 266);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(154, 50);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // stastrEstado
            // 
            this.stastrEstado.Location = new System.Drawing.Point(155, 509);
            this.stastrEstado.Name = "stastrEstado";
            this.stastrEstado.Size = new System.Drawing.Size(732, 22);
            this.stastrEstado.TabIndex = 21;
            this.stastrEstado.Text = "statusStrip1";
            // 
            // frmPrincipal2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(887, 531);
            this.Controls.Add(this.tbFiltroBR);
            this.Controls.Add(this.lblFiltroBR);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.tbFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.cbCriterio);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.cbCampo);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.btnLimpiarFiltro);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.stastrEstado);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelControles);
            this.Name = "frmPrincipal2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal2";
            this.panelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenArticulo)).EndInit();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelControles;
        private System.Windows.Forms.Panel panelPrincipal;
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
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbImagenArticulo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.StatusStrip stastrEstado;
    }
}