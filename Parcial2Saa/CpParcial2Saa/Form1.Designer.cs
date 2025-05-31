namespace CpParcial2Saa
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblParametro = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSeries = new System.Windows.Forms.Label();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.gbxListaSeries = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.nudEpisodios = new System.Windows.Forms.NumericUpDown();
            this.lblFechaEstreno = new System.Windows.Forms.Label();
            this.lblEpisodios = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblSinopsis = new System.Windows.Forms.Label();
            this.lblTitul = new System.Windows.Forms.Label();
            this.dTiFechaEstreno = new System.Windows.Forms.DateTimePicker();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.txtSinopsis = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.erpTitulo = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpSinopsis = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpDirector = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpEpisodios = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpFechaEstreno = new System.Windows.Forms.ErrorProvider(this.components);
            this.cxbIdiomaOriginal = new System.Windows.Forms.ComboBox();
            this.txturlPortada = new System.Windows.Forms.TextBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.lblIdiom = new System.Windows.Forms.Label();
            this.erpUrlPortada = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpIdiomaOriginal = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxListaSeries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEpisodios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpSinopsis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDirector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpEpisodios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpFechaEstreno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpUrlPortada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpIdiomaOriginal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblParametro
            // 
            this.lblParametro.AutoSize = true;
            this.lblParametro.Location = new System.Drawing.Point(0, 46);
            this.lblParametro.Name = "lblParametro";
            this.lblParametro.Size = new System.Drawing.Size(252, 13);
            this.lblParametro.TabIndex = 11;
            this.lblParametro.Text = "Buscar por Codigo Descripcion o Unidad de Medida";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(-120, -67);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(905, 10);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Productos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeries
            // 
            this.lblSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeries.Location = new System.Drawing.Point(-2, 9);
            this.lblSeries.Name = "lblSeries";
            this.lblSeries.Size = new System.Drawing.Size(761, 37);
            this.lblSeries.TabIndex = 12;
            this.lblSeries.Text = "Series";
            this.lblSeries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtParametro
            // 
            this.txtParametro.Location = new System.Drawing.Point(3, 71);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(657, 20);
            this.txtParametro.TabIndex = 13;
            this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);
            // 
            // gbxListaSeries
            // 
            this.gbxListaSeries.Controls.Add(this.btnNuevo);
            this.gbxListaSeries.Controls.Add(this.btnEditar);
            this.gbxListaSeries.Controls.Add(this.btnEliminar);
            this.gbxListaSeries.Controls.Add(this.btnCerrar);
            this.gbxListaSeries.Controls.Add(this.dgvLista);
            this.gbxListaSeries.Location = new System.Drawing.Point(3, 97);
            this.gbxListaSeries.Name = "gbxListaSeries";
            this.gbxListaSeries.Size = new System.Drawing.Size(796, 219);
            this.gbxListaSeries.TabIndex = 14;
            this.gbxListaSeries.TabStop = false;
            this.gbxListaSeries.Text = "Lista de Series";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::CpParcial2Saa.Properties.Resources._new;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.Location = new System.Drawing.Point(186, 175);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(98, 38);
            this.btnNuevo.TabIndex = 17;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::CpParcial2Saa.Properties.Resources.edit;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.Location = new System.Drawing.Point(290, 175);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(98, 38);
            this.btnEditar.TabIndex = 18;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::CpParcial2Saa.Properties.Resources.eliminar;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.Location = new System.Drawing.Point(394, 175);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(98, 38);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::CpParcial2Saa.Properties.Resources.cerrar;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.Location = new System.Drawing.Point(498, 175);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(98, 38);
            this.btnCerrar.TabIndex = 20;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(0, 19);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(790, 150);
            this.dgvLista.TabIndex = 0;
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.lblIdiom);
            this.gbxDatos.Controls.Add(this.lblURL);
            this.gbxDatos.Controls.Add(this.txturlPortada);
            this.gbxDatos.Controls.Add(this.cxbIdiomaOriginal);
            this.gbxDatos.Controls.Add(this.nudEpisodios);
            this.gbxDatos.Controls.Add(this.lblFechaEstreno);
            this.gbxDatos.Controls.Add(this.lblEpisodios);
            this.gbxDatos.Controls.Add(this.lblDirector);
            this.gbxDatos.Controls.Add(this.lblSinopsis);
            this.gbxDatos.Controls.Add(this.lblTitul);
            this.gbxDatos.Controls.Add(this.dTiFechaEstreno);
            this.gbxDatos.Controls.Add(this.txtDirector);
            this.gbxDatos.Controls.Add(this.txtSinopsis);
            this.gbxDatos.Controls.Add(this.txtTitulo);
            this.gbxDatos.Controls.Add(this.btnGuardar);
            this.gbxDatos.Controls.Add(this.btnCancelar);
            this.gbxDatos.Location = new System.Drawing.Point(3, 322);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(796, 155);
            this.gbxDatos.TabIndex = 15;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos";
            // 
            // nudEpisodios
            // 
            this.nudEpisodios.Location = new System.Drawing.Point(394, 29);
            this.nudEpisodios.Name = "nudEpisodios";
            this.nudEpisodios.Size = new System.Drawing.Size(120, 20);
            this.nudEpisodios.TabIndex = 33;
            // 
            // lblFechaEstreno
            // 
            this.lblFechaEstreno.AutoSize = true;
            this.lblFechaEstreno.Location = new System.Drawing.Point(294, 76);
            this.lblFechaEstreno.Name = "lblFechaEstreno";
            this.lblFechaEstreno.Size = new System.Drawing.Size(94, 13);
            this.lblFechaEstreno.TabIndex = 32;
            this.lblFechaEstreno.Text = "Fecha de Estreno:";
            // 
            // lblEpisodios
            // 
            this.lblEpisodios.AutoSize = true;
            this.lblEpisodios.Location = new System.Drawing.Point(333, 31);
            this.lblEpisodios.Name = "lblEpisodios";
            this.lblEpisodios.Size = new System.Drawing.Size(55, 13);
            this.lblEpisodios.TabIndex = 31;
            this.lblEpisodios.Text = "Episodios:";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(40, 129);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(47, 13);
            this.lblDirector.TabIndex = 30;
            this.lblDirector.Text = "Director:";
            // 
            // lblSinopsis
            // 
            this.lblSinopsis.AutoSize = true;
            this.lblSinopsis.Location = new System.Drawing.Point(38, 78);
            this.lblSinopsis.Name = "lblSinopsis";
            this.lblSinopsis.Size = new System.Drawing.Size(49, 13);
            this.lblSinopsis.TabIndex = 29;
            this.lblSinopsis.Text = "Sinopsis:";
            // 
            // lblTitul
            // 
            this.lblTitul.AutoSize = true;
            this.lblTitul.Location = new System.Drawing.Point(51, 35);
            this.lblTitul.Name = "lblTitul";
            this.lblTitul.Size = new System.Drawing.Size(36, 13);
            this.lblTitul.TabIndex = 28;
            this.lblTitul.Text = "Titulo:";
            // 
            // dTiFechaEstreno
            // 
            this.dTiFechaEstreno.Location = new System.Drawing.Point(394, 72);
            this.dTiFechaEstreno.Name = "dTiFechaEstreno";
            this.dTiFechaEstreno.Size = new System.Drawing.Size(200, 20);
            this.dTiFechaEstreno.TabIndex = 27;
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(105, 126);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(179, 20);
            this.txtDirector.TabIndex = 25;
            // 
            // txtSinopsis
            // 
            this.txtSinopsis.Location = new System.Drawing.Point(105, 76);
            this.txtSinopsis.Name = "txtSinopsis";
            this.txtSinopsis.Size = new System.Drawing.Size(179, 20);
            this.txtSinopsis.TabIndex = 24;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(105, 28);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(179, 20);
            this.txtTitulo.TabIndex = 23;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::CpParcial2Saa.Properties.Resources.guardar;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.Location = new System.Drawing.Point(585, 104);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 41);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::CpParcial2Saa.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(689, 104);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 41);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::CpParcial2Saa.Properties.Resources.buscar;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnBuscar.Location = new System.Drawing.Point(679, 61);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(111, 35);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // erpTitulo
            // 
            this.erpTitulo.ContainerControl = this;
            // 
            // erpSinopsis
            // 
            this.erpSinopsis.ContainerControl = this;
            // 
            // erpDirector
            // 
            this.erpDirector.ContainerControl = this;
            // 
            // erpEpisodios
            // 
            this.erpEpisodios.ContainerControl = this;
            // 
            // erpFechaEstreno
            // 
            this.erpFechaEstreno.ContainerControl = this;
            // 
            // cxbIdiomaOriginal
            // 
            this.cxbIdiomaOriginal.FormattingEnabled = true;
            this.cxbIdiomaOriginal.Items.AddRange(new object[] {
            "Koreano",
            "Ingles",
            "Español",
            "Portugues"});
            this.cxbIdiomaOriginal.Location = new System.Drawing.Point(666, 23);
            this.cxbIdiomaOriginal.Name = "cxbIdiomaOriginal";
            this.cxbIdiomaOriginal.Size = new System.Drawing.Size(121, 21);
            this.cxbIdiomaOriginal.TabIndex = 34;
            // 
            // txturlPortada
            // 
            this.txturlPortada.Location = new System.Drawing.Point(394, 122);
            this.txturlPortada.Name = "txturlPortada";
            this.txturlPortada.Size = new System.Drawing.Size(179, 20);
            this.txturlPortada.TabIndex = 35;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(316, 125);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(72, 13);
            this.lblURL.TabIndex = 36;
            this.lblURL.Text = "URL Portada:";
            // 
            // lblIdiom
            // 
            this.lblIdiom.AutoSize = true;
            this.lblIdiom.Location = new System.Drawing.Point(593, 29);
            this.lblIdiom.Name = "lblIdiom";
            this.lblIdiom.Size = new System.Drawing.Size(41, 13);
            this.lblIdiom.TabIndex = 37;
            this.lblIdiom.Text = "Idioma:";
            // 
            // erpUrlPortada
            // 
            this.erpUrlPortada.ContainerControl = this;
            // 
            // erpIdiomaOriginal
            // 
            this.erpIdiomaOriginal.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(802, 479);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gbxDatos);
            this.Controls.Add(this.gbxListaSeries);
            this.Controls.Add(this.txtParametro);
            this.Controls.Add(this.lblSeries);
            this.Controls.Add(this.lblParametro);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Series";
            this.gbxListaSeries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEpisodios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpSinopsis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDirector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpEpisodios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpFechaEstreno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpUrlPortada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpIdiomaOriginal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblParametro;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSeries;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.GroupBox gbxListaSeries;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dTiFechaEstreno;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox txtSinopsis;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblFechaEstreno;
        private System.Windows.Forms.Label lblEpisodios;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblSinopsis;
        private System.Windows.Forms.Label lblTitul;
        private System.Windows.Forms.NumericUpDown nudEpisodios;
        private System.Windows.Forms.ErrorProvider erpTitulo;
        private System.Windows.Forms.ErrorProvider erpSinopsis;
        private System.Windows.Forms.ErrorProvider erpDirector;
        private System.Windows.Forms.ErrorProvider erpEpisodios;
        private System.Windows.Forms.ErrorProvider erpFechaEstreno;
        private System.Windows.Forms.ComboBox cxbIdiomaOriginal;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txturlPortada;
        private System.Windows.Forms.Label lblIdiom;
        private System.Windows.Forms.ErrorProvider erpUrlPortada;
        private System.Windows.Forms.ErrorProvider erpIdiomaOriginal;
    }
}

