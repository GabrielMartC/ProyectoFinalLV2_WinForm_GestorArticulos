namespace presentacion
{
    partial class frmPrincipal
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
            this.stastrEstado = new System.Windows.Forms.StatusStrip();
            this.pbImagenArticulo = new System.Windows.Forms.PictureBox();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.rbFiltroAvanzado = new System.Windows.Forms.RadioButton();
            this.rbFiltroRapido = new System.Windows.Forms.RadioButton();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            this.lblCampo = new System.Windows.Forms.Label();
            this.cbCampo = new System.Windows.Forms.ComboBox();
            this.cbCriterio = new System.Windows.Forms.ComboBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.tbFiltro = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.tbFiltroBR = new System.Windows.Forms.TextBox();
            this.lblFiltroBR = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.gbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // stastrEstado
            // 
            this.stastrEstado.Location = new System.Drawing.Point(0, 509);
            this.stastrEstado.Name = "stastrEstado";
            this.stastrEstado.Size = new System.Drawing.Size(873, 22);
            this.stastrEstado.TabIndex = 0;
            this.stastrEstado.Text = "statusStrip1";
            // 
            // pbImagenArticulo
            // 
            this.pbImagenArticulo.Location = new System.Drawing.Point(648, 100);
            this.pbImagenArticulo.Name = "pbImagenArticulo";
            this.pbImagenArticulo.Size = new System.Drawing.Size(221, 305);
            this.pbImagenArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagenArticulo.TabIndex = 5;
            this.pbImagenArticulo.TabStop = false;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(161, 100);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersVisible = false;
            this.dgvArticulos.Size = new System.Drawing.Size(481, 406);
            this.dgvArticulos.TabIndex = 6;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescripcion.Location = new System.Drawing.Point(649, 411);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.ReadOnly = true;
            this.tbDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescripcion.Size = new System.Drawing.Size(232, 95);
            this.tbDescripcion.TabIndex = 7;
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.rbFiltroAvanzado);
            this.gbFiltros.Controls.Add(this.rbFiltroRapido);
            this.gbFiltros.Location = new System.Drawing.Point(164, 55);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(216, 39);
            this.gbFiltros.TabIndex = 8;
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
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(682, 45);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(94, 23);
            this.btnLimpiarFiltro.TabIndex = 9;
            this.btnLimpiarFiltro.Text = "Limpiar Todo";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltro.Click += new System.EventHandler(this.btnLimpiarFiltro_Click);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(161, 41);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(40, 13);
            this.lblCampo.TabIndex = 10;
            this.lblCampo.Text = "Campo";
            // 
            // cbCampo
            // 
            this.cbCampo.FormattingEnabled = true;
            this.cbCampo.Location = new System.Drawing.Point(203, 36);
            this.cbCampo.Name = "cbCampo";
            this.cbCampo.Size = new System.Drawing.Size(121, 21);
            this.cbCampo.TabIndex = 11;
            this.cbCampo.SelectedIndexChanged += new System.EventHandler(this.cbCampo_SelectedIndexChanged);
            // 
            // cbCriterio
            // 
            this.cbCriterio.FormattingEnabled = true;
            this.cbCriterio.Location = new System.Drawing.Point(386, 36);
            this.cbCriterio.Name = "cbCriterio";
            this.cbCriterio.Size = new System.Drawing.Size(121, 21);
            this.cbCriterio.TabIndex = 13;
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(344, 41);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(39, 13);
            this.lblCriterio.TabIndex = 12;
            this.lblCriterio.Text = "Criterio";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(524, 39);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(29, 13);
            this.lblFiltro.TabIndex = 14;
            this.lblFiltro.Text = "Filtro";
            // 
            // tbFiltro
            // 
            this.tbFiltro.Location = new System.Drawing.Point(555, 34);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(121, 20);
            this.tbFiltro.TabIndex = 15;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(682, 73);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(94, 23);
            this.btnFiltrar.TabIndex = 16;
            this.btnFiltrar.Text = "Buscar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // tbFiltroBR
            // 
            this.tbFiltroBR.Location = new System.Drawing.Point(386, 10);
            this.tbFiltroBR.Name = "tbFiltroBR";
            this.tbFiltroBR.Size = new System.Drawing.Size(121, 20);
            this.tbFiltroBR.TabIndex = 20;
            this.tbFiltroBR.TextChanged += new System.EventHandler(this.tbFiltroBR_TextChanged);
            // 
            // lblFiltroBR
            // 
            this.lblFiltroBR.AutoSize = true;
            this.lblFiltroBR.Location = new System.Drawing.Point(355, 15);
            this.lblFiltroBR.Name = "lblFiltroBR";
            this.lblFiltroBR.Size = new System.Drawing.Size(29, 13);
            this.lblFiltroBR.TabIndex = 19;
            this.lblFiltroBR.Text = "Filtro";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(3, 121);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(155, 50);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar Articulo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(3, 187);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(155, 50);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(3, 297);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(155, 50);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 531);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.tbFiltroBR);
            this.Controls.Add(this.btnAgregar);
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
            this.Controls.Add(this.pbImagenArticulo);
            this.Controls.Add(this.stastrEstado);
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stastrEstado;
        private System.Windows.Forms.PictureBox pbImagenArticulo;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.RadioButton rbFiltroAvanzado;
        private System.Windows.Forms.RadioButton rbFiltroRapido;
        private System.Windows.Forms.Button btnLimpiarFiltro;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.ComboBox cbCampo;
        private System.Windows.Forms.ComboBox cbCriterio;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox tbFiltro;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox tbFiltroBR;
        private System.Windows.Forms.Label lblFiltroBR;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}

