namespace REGISTROS_ACADEMIA_LIDER
{
    partial class evento
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combo_estado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_fecha_final = new System.Windows.Forms.TextBox();
            this.txt_fecha_inicio = new System.Windows.Forms.TextBox();
            this.txt_combo_modalidad = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_docente = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ciudad = new System.Windows.Forms.TextBox();
            this.txt_carfa_horaria = new System.Windows.Forms.TextBox();
            this.txt_evento = new System.Windows.Forms.TextBox();
            this.txt_codigo_env = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bot_limpiar = new System.Windows.Forms.Button();
            this.bot_actualizar = new System.Windows.Forms.Button();
            this.bot_editar = new System.Windows.Forms.Button();
            this.bot_eliminar = new System.Windows.Forms.Button();
            this.bot_nuevo = new System.Windows.Forms.Button();
            this.bot_buscar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bot_guardar = new System.Windows.Forms.Button();
            this.bot_generar_qr = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bot_atras = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.combo_estado);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_fecha_final);
            this.groupBox1.Controls.Add(this.txt_fecha_inicio);
            this.groupBox1.Controls.Add(this.txt_combo_modalidad);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txt_docente);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_ciudad);
            this.groupBox1.Controls.Add(this.txt_carfa_horaria);
            this.groupBox1.Controls.Add(this.txt_evento);
            this.groupBox1.Controls.Add(this.txt_codigo_env);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 304);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DE EVENTO";
            // 
            // combo_estado
            // 
            this.combo_estado.FormattingEnabled = true;
            this.combo_estado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.combo_estado.Location = new System.Drawing.Point(196, 249);
            this.combo_estado.Name = "combo_estado";
            this.combo_estado.Size = new System.Drawing.Size(187, 31);
            this.combo_estado.TabIndex = 39;
            this.combo_estado.Text = "--SELECCIONE--";
            this.combo_estado.SelectedIndexChanged += new System.EventHandler(this.combo_estado_SelectedIndexChanged);
            this.combo_estado.TabIndexChanged += new System.EventHandler(this.combo_estado_TabIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label8.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(7, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 22);
            this.label8.TabIndex = 38;
            this.label8.Text = "ESTADO";
            // 
            // txt_fecha_final
            // 
            this.txt_fecha_final.Location = new System.Drawing.Point(196, 183);
            this.txt_fecha_final.Name = "txt_fecha_final";
            this.txt_fecha_final.Size = new System.Drawing.Size(187, 28);
            this.txt_fecha_final.TabIndex = 37;
            // 
            // txt_fecha_inicio
            // 
            this.txt_fecha_inicio.Location = new System.Drawing.Point(196, 148);
            this.txt_fecha_inicio.Name = "txt_fecha_inicio";
            this.txt_fecha_inicio.Size = new System.Drawing.Size(187, 28);
            this.txt_fecha_inicio.TabIndex = 36;
            // 
            // txt_combo_modalidad
            // 
            this.txt_combo_modalidad.FormattingEnabled = true;
            this.txt_combo_modalidad.Items.AddRange(new object[] {
            "Presencial",
            "Virtual"});
            this.txt_combo_modalidad.Location = new System.Drawing.Point(196, 84);
            this.txt_combo_modalidad.Name = "txt_combo_modalidad";
            this.txt_combo_modalidad.Size = new System.Drawing.Size(187, 31);
            this.txt_combo_modalidad.TabIndex = 35;
            this.txt_combo_modalidad.Text = "--SELECCIONE--";
            this.txt_combo_modalidad.SelectedIndexChanged += new System.EventHandler(this.txt_combo_modalidad_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label18.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(391, 28);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(98, 22);
            this.label18.TabIndex = 33;
            this.label18.Text = "DOCENTE";
            // 
            // txt_docente
            // 
            this.txt_docente.Location = new System.Drawing.Point(500, 22);
            this.txt_docente.Name = "txt_docente";
            this.txt_docente.Size = new System.Drawing.Size(158, 28);
            this.txt_docente.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label11.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(6, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 22);
            this.label11.TabIndex = 20;
            this.label11.Text = "CIUDAD";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(426, 92);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label7.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(464, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "CALENDARIO";
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.Location = new System.Drawing.Point(196, 215);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(185, 28);
            this.txt_ciudad.TabIndex = 11;
            // 
            // txt_carfa_horaria
            // 
            this.txt_carfa_horaria.Location = new System.Drawing.Point(196, 116);
            this.txt_carfa_horaria.Name = "txt_carfa_horaria";
            this.txt_carfa_horaria.Size = new System.Drawing.Size(125, 28);
            this.txt_carfa_horaria.TabIndex = 10;
            this.txt_carfa_horaria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_carfa_horaria_KeyPress);
            // 
            // txt_evento
            // 
            this.txt_evento.Location = new System.Drawing.Point(196, 53);
            this.txt_evento.Name = "txt_evento";
            this.txt_evento.Size = new System.Drawing.Size(185, 28);
            this.txt_evento.TabIndex = 8;
            // 
            // txt_codigo_env
            // 
            this.txt_codigo_env.Location = new System.Drawing.Point(196, 23);
            this.txt_codigo_env.Name = "txt_codigo_env";
            this.txt_codigo_env.Size = new System.Drawing.Size(185, 28);
            this.txt_codigo_env.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "EVENTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label6.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(6, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "FECHA FINAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "CODIGO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label5.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(6, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "FECHA INICIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "MODALIDAD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label4.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(6, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "CARGA HORARIA";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bot_limpiar);
            this.groupBox4.Controls.Add(this.bot_actualizar);
            this.groupBox4.Controls.Add(this.bot_editar);
            this.groupBox4.Controls.Add(this.bot_eliminar);
            this.groupBox4.Controls.Add(this.bot_nuevo);
            this.groupBox4.Controls.Add(this.bot_buscar);
            this.groupBox4.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(688, 55);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(189, 290);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "OPERACIONES";
            // 
            // bot_limpiar
            // 
            this.bot_limpiar.BackColor = System.Drawing.Color.DarkCyan;
            this.bot_limpiar.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_limpiar.Location = new System.Drawing.Point(6, 230);
            this.bot_limpiar.Name = "bot_limpiar";
            this.bot_limpiar.Size = new System.Drawing.Size(176, 34);
            this.bot_limpiar.TabIndex = 13;
            this.bot_limpiar.Text = "LIMPIAR";
            this.bot_limpiar.UseVisualStyleBackColor = false;
            this.bot_limpiar.Click += new System.EventHandler(this.bot_limpiar_Click);
            // 
            // bot_actualizar
            // 
            this.bot_actualizar.BackColor = System.Drawing.Color.DarkCyan;
            this.bot_actualizar.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_actualizar.Location = new System.Drawing.Point(6, 190);
            this.bot_actualizar.Name = "bot_actualizar";
            this.bot_actualizar.Size = new System.Drawing.Size(176, 34);
            this.bot_actualizar.TabIndex = 11;
            this.bot_actualizar.Text = "ACTULIZAR";
            this.bot_actualizar.UseVisualStyleBackColor = false;
            this.bot_actualizar.Click += new System.EventHandler(this.bot_actualizar_Click);
            // 
            // bot_editar
            // 
            this.bot_editar.BackColor = System.Drawing.Color.DarkCyan;
            this.bot_editar.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_editar.Location = new System.Drawing.Point(6, 150);
            this.bot_editar.Name = "bot_editar";
            this.bot_editar.Size = new System.Drawing.Size(176, 34);
            this.bot_editar.TabIndex = 10;
            this.bot_editar.Text = "EDITAR";
            this.bot_editar.UseVisualStyleBackColor = false;
            this.bot_editar.Click += new System.EventHandler(this.bot_editar_Click);
            // 
            // bot_eliminar
            // 
            this.bot_eliminar.BackColor = System.Drawing.Color.DarkCyan;
            this.bot_eliminar.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_eliminar.Location = new System.Drawing.Point(6, 111);
            this.bot_eliminar.Name = "bot_eliminar";
            this.bot_eliminar.Size = new System.Drawing.Size(176, 34);
            this.bot_eliminar.TabIndex = 9;
            this.bot_eliminar.Text = "ELIMINAR";
            this.bot_eliminar.UseVisualStyleBackColor = false;
            this.bot_eliminar.Click += new System.EventHandler(this.bot_eliminar_Click);
            // 
            // bot_nuevo
            // 
            this.bot_nuevo.BackColor = System.Drawing.Color.DarkCyan;
            this.bot_nuevo.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_nuevo.Location = new System.Drawing.Point(6, 71);
            this.bot_nuevo.Name = "bot_nuevo";
            this.bot_nuevo.Size = new System.Drawing.Size(176, 34);
            this.bot_nuevo.TabIndex = 8;
            this.bot_nuevo.Text = "NUEVO";
            this.bot_nuevo.UseVisualStyleBackColor = false;
            this.bot_nuevo.Click += new System.EventHandler(this.bot_nuevo_Click);
            // 
            // bot_buscar
            // 
            this.bot_buscar.BackColor = System.Drawing.Color.DarkCyan;
            this.bot_buscar.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_buscar.Location = new System.Drawing.Point(6, 31);
            this.bot_buscar.Name = "bot_buscar";
            this.bot_buscar.Size = new System.Drawing.Size(176, 34);
            this.bot_buscar.TabIndex = 7;
            this.bot_buscar.Text = "BUSCAR";
            this.bot_buscar.UseVisualStyleBackColor = false;
            this.bot_buscar.Click += new System.EventHandler(this.bot_buscar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGV1);
            this.groupBox2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(6, 365);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(676, 251);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LISTA DE EVENTOS";
            // 
            // DGV1
            // 
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Location = new System.Drawing.Point(10, 27);
            this.DGV1.Name = "DGV1";
            this.DGV1.Size = new System.Drawing.Size(654, 218);
            this.DGV1.TabIndex = 0;
            this.DGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV1_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bot_guardar);
            this.groupBox3.Controls.Add(this.bot_generar_qr);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(688, 351);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(189, 225);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "GENERACION DE QR";
            // 
            // bot_guardar
            // 
            this.bot_guardar.BackColor = System.Drawing.Color.DarkCyan;
            this.bot_guardar.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_guardar.Location = new System.Drawing.Point(4, 189);
            this.bot_guardar.Name = "bot_guardar";
            this.bot_guardar.Size = new System.Drawing.Size(174, 34);
            this.bot_guardar.TabIndex = 7;
            this.bot_guardar.Text = "GUARDAR";
            this.bot_guardar.UseVisualStyleBackColor = false;
            this.bot_guardar.Click += new System.EventHandler(this.bot_guardar_Click);
            // 
            // bot_generar_qr
            // 
            this.bot_generar_qr.BackColor = System.Drawing.Color.DarkCyan;
            this.bot_generar_qr.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_generar_qr.Location = new System.Drawing.Point(4, 159);
            this.bot_generar_qr.Name = "bot_generar_qr";
            this.bot_generar_qr.Size = new System.Drawing.Size(174, 34);
            this.bot_generar_qr.TabIndex = 6;
            this.bot_generar_qr.Text = "GENERAR";
            this.bot_generar_qr.UseVisualStyleBackColor = false;
            this.bot_generar_qr.Click += new System.EventHandler(this.bot_generar_qr_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(35, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bot_atras
            // 
            this.bot_atras.BackColor = System.Drawing.Color.DarkCyan;
            this.bot_atras.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_atras.Location = new System.Drawing.Point(692, 582);
            this.bot_atras.Name = "bot_atras";
            this.bot_atras.Size = new System.Drawing.Size(176, 34);
            this.bot_atras.TabIndex = 14;
            this.bot_atras.Text = "ATRAS";
            this.bot_atras.UseVisualStyleBackColor = false;
            this.bot_atras.Click += new System.EventHandler(this.bot_atras_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label15.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(358, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(162, 40);
            this.label15.TabIndex = 26;
            this.label15.Text = "EVENTOS";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label9.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(323, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 22);
            this.label9.TabIndex = 41;
            this.label9.Text = "Hrs.";
            // 
            // evento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(885, 628);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.bot_atras);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "evento";
            this.Text = "EVENTO";
            this.Load += new System.EventHandler(this.evento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ciudad;
        private System.Windows.Forms.TextBox txt_carfa_horaria;
        private System.Windows.Forms.TextBox txt_evento;
        private System.Windows.Forms.TextBox txt_codigo_env;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bot_limpiar;
        private System.Windows.Forms.Button bot_actualizar;
        private System.Windows.Forms.Button bot_editar;
        private System.Windows.Forms.Button bot_eliminar;
        private System.Windows.Forms.Button bot_nuevo;
        private System.Windows.Forms.Button bot_buscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_docente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bot_generar_qr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bot_atras;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox txt_combo_modalidad;
        private System.Windows.Forms.ComboBox combo_estado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_fecha_final;
        private System.Windows.Forms.TextBox txt_fecha_inicio;
        private System.Windows.Forms.Button bot_guardar;
        private System.Windows.Forms.Label label9;
    }
}