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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
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
            this.cbCampoBR = new System.Windows.Forms.ComboBox();
            this.lblCampoBR = new System.Windows.Forms.Label();
            this.tbFiltroBR = new System.Windows.Forms.TextBox();
            this.lblFiltroBR = new System.Windows.Forms.Label();
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
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(3, 271);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(154, 50);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(3, 188);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(154, 50);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(3, 128);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(155, 50);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar Nuevo";
            this.btnAgregar.UseVisualStyleBackColor = true;
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
            this.gbFiltros.Location = new System.Drawing.Point(161, -3);
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
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(688, 67);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(94, 23);
            this.btnLimpiarFiltro.TabIndex = 9;
            this.btnLimpiarFiltro.Text = "Limpiar Todo";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = true;
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(164, 49);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(40, 13);
            this.lblCampo.TabIndex = 10;
            this.lblCampo.Text = "Campo";
            // 
            // cbCampo
            // 
            this.cbCampo.FormattingEnabled = true;
            this.cbCampo.Location = new System.Drawing.Point(206, 44);
            this.cbCampo.Name = "cbCampo";
            this.cbCampo.Size = new System.Drawing.Size(121, 21);
            this.cbCampo.TabIndex = 11;
            this.cbCampo.SelectedIndexChanged += new System.EventHandler(this.cbCampo_SelectedIndexChanged);
            // 
            // cbCriterio
            // 
            this.cbCriterio.FormattingEnabled = true;
            this.cbCriterio.Location = new System.Drawing.Point(387, 44);
            this.cbCriterio.Name = "cbCriterio";
            this.cbCriterio.Size = new System.Drawing.Size(121, 21);
            this.cbCriterio.TabIndex = 13;
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(345, 49);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(39, 13);
            this.lblCriterio.TabIndex = 12;
            this.lblCriterio.Text = "Criterio";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(525, 49);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(29, 13);
            this.lblFiltro.TabIndex = 14;
            this.lblFiltro.Text = "Filtro";
            // 
            // tbFiltro
            // 
            this.tbFiltro.Location = new System.Drawing.Point(556, 44);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(121, 20);
            this.tbFiltro.TabIndex = 15;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(688, 42);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(94, 23);
            this.btnFiltrar.TabIndex = 16;
            this.btnFiltrar.Text = "Buscar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cbCampoBR
            // 
            this.cbCampoBR.FormattingEnabled = true;
            this.cbCampoBR.Location = new System.Drawing.Point(206, 73);
            this.cbCampoBR.Name = "cbCampoBR";
            this.cbCampoBR.Size = new System.Drawing.Size(121, 21);
            this.cbCampoBR.TabIndex = 18;
            // 
            // lblCampoBR
            // 
            this.lblCampoBR.AutoSize = true;
            this.lblCampoBR.Location = new System.Drawing.Point(164, 78);
            this.lblCampoBR.Name = "lblCampoBR";
            this.lblCampoBR.Size = new System.Drawing.Size(40, 13);
            this.lblCampoBR.TabIndex = 17;
            this.lblCampoBR.Text = "Campo";
            // 
            // tbFiltroBR
            // 
            this.tbFiltroBR.Location = new System.Drawing.Point(387, 74);
            this.tbFiltroBR.Name = "tbFiltroBR";
            this.tbFiltroBR.Size = new System.Drawing.Size(121, 20);
            this.tbFiltroBR.TabIndex = 20;
            // 
            // lblFiltroBR
            // 
            this.lblFiltroBR.AutoSize = true;
            this.lblFiltroBR.Location = new System.Drawing.Point(356, 79);
            this.lblFiltroBR.Name = "lblFiltroBR";
            this.lblFiltroBR.Size = new System.Drawing.Size(29, 13);
            this.lblFiltroBR.TabIndex = 19;
            this.lblFiltroBR.Text = "Filtro";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 531);
            this.Controls.Add(this.tbFiltroBR);
            this.Controls.Add(this.lblFiltroBR);
            this.Controls.Add(this.cbCampoBR);
            this.Controls.Add(this.lblCampoBR);
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
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.stastrEstado);
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
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox pbImagenArticulo;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.GroupBox gbFiltros;
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
        private System.Windows.Forms.ComboBox cbCampoBR;
        private System.Windows.Forms.Label lblCampoBR;
        private System.Windows.Forms.TextBox tbFiltroBR;
        private System.Windows.Forms.Label lblFiltroBR;
    }
}

