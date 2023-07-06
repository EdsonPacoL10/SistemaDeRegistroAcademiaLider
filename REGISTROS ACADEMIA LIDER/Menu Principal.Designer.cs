namespace REGISTROS_ACADEMIA_LIDER
{
    partial class Menu_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Principal));
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bot_usuario = new System.Windows.Forms.Button();
            this.bot_cetificado = new System.Windows.Forms.Button();
            this.bot_evento = new System.Windows.Forms.Button();
            this.bot_participante = new System.Windows.Forms.Button();
            this.bot_docente = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bot_buscar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.bot_atras = new System.Windows.Forms.Button();
            this.bot_salir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(198, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(637, 74);
            this.label2.TabIndex = 1;
            this.label2.Text = "MENU PRINCIPAL";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.bot_usuario);
            this.groupBox1.Controls.Add(this.bot_cetificado);
            this.groupBox1.Controls.Add(this.bot_evento);
            this.groupBox1.Controls.Add(this.bot_participante);
            this.groupBox1.Controls.Add(this.bot_docente);
            this.groupBox1.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Aqua;
            this.groupBox1.Location = new System.Drawing.Point(61, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(950, 124);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ACCIONES DEL SISTEMA";
            // 
            // bot_usuario
            // 
            this.bot_usuario.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bot_usuario.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_usuario.ForeColor = System.Drawing.Color.Cyan;
            this.bot_usuario.Location = new System.Drawing.Point(762, 52);
            this.bot_usuario.Name = "bot_usuario";
            this.bot_usuario.Size = new System.Drawing.Size(142, 39);
            this.bot_usuario.TabIndex = 4;
            this.bot_usuario.Text = "USUARIO";
            this.bot_usuario.UseVisualStyleBackColor = false;
            this.bot_usuario.Click += new System.EventHandler(this.bot_usuario_Click);
            // 
            // bot_cetificado
            // 
            this.bot_cetificado.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bot_cetificado.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_cetificado.ForeColor = System.Drawing.Color.Cyan;
            this.bot_cetificado.Location = new System.Drawing.Point(541, 52);
            this.bot_cetificado.Name = "bot_cetificado";
            this.bot_cetificado.Size = new System.Drawing.Size(188, 39);
            this.bot_cetificado.TabIndex = 3;
            this.bot_cetificado.Text = "CERTIFICADOS";
            this.bot_cetificado.UseVisualStyleBackColor = false;
            this.bot_cetificado.Click += new System.EventHandler(this.bot_cetificado_Click);
            // 
            // bot_evento
            // 
            this.bot_evento.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bot_evento.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_evento.ForeColor = System.Drawing.Color.Cyan;
            this.bot_evento.Location = new System.Drawing.Point(196, 52);
            this.bot_evento.Name = "bot_evento";
            this.bot_evento.Size = new System.Drawing.Size(118, 39);
            this.bot_evento.TabIndex = 2;
            this.bot_evento.Text = "EVENTOS";
            this.bot_evento.UseVisualStyleBackColor = false;
            this.bot_evento.Click += new System.EventHandler(this.bot_evento_Click);
            // 
            // bot_participante
            // 
            this.bot_participante.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bot_participante.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_participante.ForeColor = System.Drawing.Color.Cyan;
            this.bot_participante.Location = new System.Drawing.Point(331, 52);
            this.bot_participante.Name = "bot_participante";
            this.bot_participante.Size = new System.Drawing.Size(174, 39);
            this.bot_participante.TabIndex = 1;
            this.bot_participante.Text = "PARTICIPANTE";
            this.bot_participante.UseVisualStyleBackColor = false;
            this.bot_participante.Click += new System.EventHandler(this.bot_participante_Click);
            // 
            // bot_docente
            // 
            this.bot_docente.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bot_docente.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_docente.ForeColor = System.Drawing.Color.Cyan;
            this.bot_docente.Location = new System.Drawing.Point(40, 52);
            this.bot_docente.Name = "bot_docente";
            this.bot_docente.Size = new System.Drawing.Size(139, 39);
            this.bot_docente.TabIndex = 0;
            this.bot_docente.Text = "DOCENTE";
            this.bot_docente.UseVisualStyleBackColor = false;
            this.bot_docente.Click += new System.EventHandler(this.bot_docente_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.bot_buscar);
            this.groupBox2.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.Aqua;
            this.groupBox2.Location = new System.Drawing.Point(61, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(950, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BUSQUEDA DE EVENTOS";
            // 
            // bot_buscar
            // 
            this.bot_buscar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bot_buscar.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_buscar.ForeColor = System.Drawing.Color.Cyan;
            this.bot_buscar.Location = new System.Drawing.Point(214, 38);
            this.bot_buscar.Name = "bot_buscar";
            this.bot_buscar.Size = new System.Drawing.Size(540, 39);
            this.bot_buscar.TabIndex = 5;
            this.bot_buscar.Text = "BUSQUEDA DE REGISTROS  DETERMINADOS";
            this.bot_buscar.UseVisualStyleBackColor = false;
            this.bot_buscar.Click += new System.EventHandler(this.bot_buscar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.DGV1);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Aqua;
            this.groupBox3.Location = new System.Drawing.Point(61, 347);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(950, 223);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DATOS DE EVENTOS CREADOS Y SU ESTRADO";
            // 
            // DGV1
            // 
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Location = new System.Drawing.Point(6, 42);
            this.DGV1.Name = "DGV1";
            this.DGV1.Size = new System.Drawing.Size(933, 162);
            this.DGV1.TabIndex = 0;
            this.DGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV1_CellContentClick);
            // 
            // bot_atras
            // 
            this.bot_atras.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bot_atras.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_atras.ForeColor = System.Drawing.Color.Cyan;
            this.bot_atras.Location = new System.Drawing.Point(61, 590);
            this.bot_atras.Name = "bot_atras";
            this.bot_atras.Size = new System.Drawing.Size(162, 39);
            this.bot_atras.TabIndex = 6;
            this.bot_atras.Text = "ATRAS";
            this.bot_atras.UseVisualStyleBackColor = false;
            this.bot_atras.Click += new System.EventHandler(this.bot_atras_Click);
            // 
            // bot_salir
            // 
            this.bot_salir.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bot_salir.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_salir.ForeColor = System.Drawing.Color.Cyan;
            this.bot_salir.Location = new System.Drawing.Point(849, 590);
            this.bot_salir.Name = "bot_salir";
            this.bot_salir.Size = new System.Drawing.Size(162, 39);
            this.bot_salir.TabIndex = 7;
            this.bot_salir.Text = "SALIR";
            this.bot_salir.UseVisualStyleBackColor = false;
            this.bot_salir.Click += new System.EventHandler(this.bot_salir_Click);
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1047, 665);
            this.Controls.Add(this.bot_salir);
            this.Controls.Add(this.bot_atras);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "Menu_Principal";
            this.Text = "Menu_Principal";
            this.Load += new System.EventHandler(this.Menu_Principal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bot_docente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.Button bot_usuario;
        private System.Windows.Forms.Button bot_cetificado;
        private System.Windows.Forms.Button bot_evento;
        private System.Windows.Forms.Button bot_participante;
        private System.Windows.Forms.Button bot_buscar;
        private System.Windows.Forms.Button bot_atras;
        private System.Windows.Forms.Button bot_salir;
    }
}