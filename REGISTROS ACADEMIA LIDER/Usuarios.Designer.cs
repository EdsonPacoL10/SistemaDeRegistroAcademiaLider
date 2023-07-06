namespace REGISTROS_ACADEMIA_LIDER
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_combo_acceso = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cargo_usuario = new System.Windows.Forms.TextBox();
            this.txt_apellido_usuario = new System.Windows.Forms.TextBox();
            this.txt_nombre_usuario = new System.Windows.Forms.TextBox();
            this.txt_codigo_usuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bot_actualizar = new System.Windows.Forms.Button();
            this.bot_limpiar = new System.Windows.Forms.Button();
            this.bot_eliminar = new System.Windows.Forms.Button();
            this.bot_editar = new System.Windows.Forms.Button();
            this.bot_nuevo = new System.Windows.Forms.Button();
            this.bot_buscar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bot_guardar = new System.Windows.Forms.Button();
            this.bot_generar_qr_usuario = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bot_atras = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rt_cargo = new System.Windows.Forms.RadioButton();
            this.rt_codigo = new System.Windows.Forms.RadioButton();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_combo_acceso);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_cargo_usuario);
            this.groupBox1.Controls.Add(this.txt_apellido_usuario);
            this.groupBox1.Controls.Add(this.txt_nombre_usuario);
            this.groupBox1.Controls.Add(this.txt_codigo_usuario);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(24, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 230);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRO DE USUARIOS";
            // 
            // txt_combo_acceso
            // 
            this.txt_combo_acceso.FormattingEnabled = true;
            this.txt_combo_acceso.Items.AddRange(new object[] {
            "Administrador",
            "usuario"});
            this.txt_combo_acceso.Location = new System.Drawing.Point(235, 188);
            this.txt_combo_acceso.Name = "txt_combo_acceso";
            this.txt_combo_acceso.Size = new System.Drawing.Size(195, 31);
            this.txt_combo_acceso.TabIndex = 16;
            this.txt_combo_acceso.Text = "--SELECCIONE--";
            this.txt_combo_acceso.SelectedIndexChanged += new System.EventHandler(this.txt_combo_acceso_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(7, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "ROL DE ACCESO";
            // 
            // txt_cargo_usuario
            // 
            this.txt_cargo_usuario.Location = new System.Drawing.Point(235, 140);
            this.txt_cargo_usuario.Name = "txt_cargo_usuario";
            this.txt_cargo_usuario.Size = new System.Drawing.Size(195, 28);
            this.txt_cargo_usuario.TabIndex = 13;
            // 
            // txt_apellido_usuario
            // 
            this.txt_apellido_usuario.Location = new System.Drawing.Point(235, 106);
            this.txt_apellido_usuario.Name = "txt_apellido_usuario";
            this.txt_apellido_usuario.Size = new System.Drawing.Size(195, 28);
            this.txt_apellido_usuario.TabIndex = 12;
            // 
            // txt_nombre_usuario
            // 
            this.txt_nombre_usuario.Location = new System.Drawing.Point(235, 72);
            this.txt_nombre_usuario.Name = "txt_nombre_usuario";
            this.txt_nombre_usuario.Size = new System.Drawing.Size(195, 28);
            this.txt_nombre_usuario.TabIndex = 11;
            // 
            // txt_codigo_usuario
            // 
            this.txt_codigo_usuario.Location = new System.Drawing.Point(235, 37);
            this.txt_codigo_usuario.Name = "txt_codigo_usuario";
            this.txt_codigo_usuario.Size = new System.Drawing.Size(195, 28);
            this.txt_codigo_usuario.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label5.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(7, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "CARGO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label4.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(7, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "APELLIDO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(7, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "NOMBRE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(7, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "CODIGO";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGV1);
            this.groupBox2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(24, 393);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(654, 218);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "REGISTRO DE USUARIOS";
            // 
            // DGV1
            // 
            this.DGV1.AllowUserToOrderColumns = true;
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Location = new System.Drawing.Point(6, 27);
            this.DGV1.Name = "DGV1";
            this.DGV1.Size = new System.Drawing.Size(642, 175);
            this.DGV1.TabIndex = 0;
            this.DGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV1_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bot_actualizar);
            this.groupBox3.Controls.Add(this.bot_limpiar);
            this.groupBox3.Controls.Add(this.bot_eliminar);
            this.groupBox3.Controls.Add(this.bot_editar);
            this.groupBox3.Controls.Add(this.bot_nuevo);
            this.groupBox3.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(684, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(192, 219);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "OPERACIONES";
            // 
            // bot_actualizar
            // 
            this.bot_actualizar.BackColor = System.Drawing.Color.DarkCyan;
            this.bot_actualizar.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_actualizar.Location = new System.Drawing.Point(27, 185);
            this.bot_actualizar.Name = "bot_actualizar";
            this.bot_actualizar.Size = new System.Drawing.Size(146, 34);
            this.bot_actualizar.TabIndex = 4;
            this.bot_actualizar.Text = "ACTUALIZAR";
            this.bot_actualizar.UseVisualStyleBackColor = false;
            this.bot_actualizar.Click += new System.EventHandler(this.bot_actualizar_Click);
            // 
            // bot_limpiar
            // 
            this.bot_limpiar.BackColor = System.Drawing.Color.DarkCyan;
            this.bot_limpiar.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_limpiar.Location = new System.Drawing.Point(27, 145);
            this.bot_limpiar.Name = "bot_limpiar";
            this.bot_limpiar.Size = new System.Drawing.Size(146, 34);
            this.bot_limpiar.TabIndex = 3;
            this.bot_limpiar.Text = "LIMPIAR";
            this.bot_limpiar.UseVisualStyleBackColor = false;
            this.bot_limpiar.Click += new System.EventHandler(this.bot_limpiar_Click);
            // 
            // bot_eliminar
            // 
            this.bot_eliminar.BackColor = System.Drawing.Color.DarkCyan;
            this.bot_eliminar.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_eliminar.Location = new System.Drawing.Point(27, 105);
            this.bot_eliminar.Name = "bot_eliminar";
            this.bot_eliminar.Size = new System.Drawing.Size(146, 34);
            this.bot_eliminar.TabIndex = 2;
            this.bot_eliminar.Text = "ELIMINAR";
            this.bot_eliminar.UseVisualStyleBackColor = false;
            this.bot_eliminar.Click += new System.EventHandler(this.bot_eliminar_Click);
            // 
            // bot_editar
            // 
            this.bot_editar.BackColor = System.Drawing.Color.DarkCyan;
            this.bot_editar.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_editar.Location = new System.Drawing.Point(27, 65);
            this.bot_editar.Name = "bot_editar";
            this.bot_editar.Size = new System.Drawing.Size(146, 34);
            this.bot_editar.TabIndex = 1;
            this.bot_editar.Text = "EDITAR";
            this.bot_editar.UseVisualStyleBackColor = false;
            this.bot_editar.Click += new System.EventHandler(this.bot_editar_Click);
            // 
            // bot_nuevo
            // 
            this.bot_nuevo.BackColor = System.Drawing.Color.DarkCyan;
            this.bot_nuevo.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_nuevo.Location = new System.Drawing.Point(27, 25);
            this.bot_nuevo.Name = "bot_nuevo";
            this.bot_nuevo.Size = new System.Drawing.Size(146, 34);
            this.bot_nuevo.TabIndex = 0;
            this.bot_nuevo.Text = "NUEVO";
            this.bot_nuevo.UseVisualStyleBackColor = false;
            this.bot_nuevo.Click += new System.EventHandler(this.bot_nuevo_Click);
            // 
            // bot_buscar
            // 
            this.bot_buscar.BackColor = System.Drawing.Color.DarkCyan;
            this.bot_buscar.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_buscar.Location = new System.Drawing.Point(675, 27);
            this.bot_buscar.Name = "bot_buscar";
            this.bot_buscar.Size = new System.Drawing.Size(146, 34);
            this.bot_buscar.TabIndex = 5;
            this.bot_buscar.Text = "BUSCAR";
            this.bot_buscar.UseVisualStyleBackColor = false;
            this.bot_buscar.Click += new System.EventHandler(this.bot_buscar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bot_guardar);
            this.groupBox4.Controls.Add(this.bot_generar_qr_usuario);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(478, 79);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 231);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "QR DE USUARIO";
            // 
            // bot_guardar
            // 
            this.bot_guardar.BackColor = System.Drawing.Color.DarkCyan;
            this.bot_guardar.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_guardar.Location = new System.Drawing.Point(12, 155);
            this.bot_guardar.Name = "bot_guardar";
            this.bot_guardar.Size = new System.Drawing.Size(182, 34);
            this.bot_guardar.TabIndex = 7;
            this.bot_guardar.Text = "GUARDAR";
            this.bot_guardar.UseVisualStyleBackColor = false;
            this.bot_guardar.Click += new System.EventHandler(this.bot_guardar_Click);
            // 
            // bot_generar_qr_usuario
            // 
            this.bot_generar_qr_usuario.BackColor = System.Drawing.Color.DarkCyan;
            this.bot_generar_qr_usuario.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_generar_qr_usuario.Location = new System.Drawing.Point(12, 195);
            this.bot_generar_qr_usuario.Name = "bot_generar_qr_usuario";
            this.bot_generar_qr_usuario.Size = new System.Drawing.Size(182, 34);
            this.bot_generar_qr_usuario.TabIndex = 6;
            this.bot_generar_qr_usuario.Text = "GENERAR";
            this.bot_generar_qr_usuario.UseVisualStyleBackColor = false;
            this.bot_generar_qr_usuario.Click += new System.EventHandler(this.bot_generar_qr_usuario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bot_atras
            // 
            this.bot_atras.BackColor = System.Drawing.Color.DarkCyan;
            this.bot_atras.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_atras.Location = new System.Drawing.Point(711, 561);
            this.bot_atras.Name = "bot_atras";
            this.bot_atras.Size = new System.Drawing.Size(146, 34);
            this.bot_atras.TabIndex = 6;
            this.bot_atras.Text = "ATRAS";
            this.bot_atras.UseVisualStyleBackColor = false;
            this.bot_atras.Click += new System.EventHandler(this.bot_atras_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label12.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(261, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(401, 40);
            this.label12.TabIndex = 26;
            this.label12.Text = "REGISTRO DE USUARIOS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(699, 420);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 134);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.rt_cargo);
            this.groupBox5.Controls.Add(this.rt_codigo);
            this.groupBox5.Controls.Add(this.txt_busqueda);
            this.groupBox5.Controls.Add(this.bot_buscar);
            this.groupBox5.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox5.Location = new System.Drawing.Point(24, 316);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(852, 79);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Busqueda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label6.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(271, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ingresar Datos";
            // 
            // rt_cargo
            // 
            this.rt_cargo.AutoSize = true;
            this.rt_cargo.Location = new System.Drawing.Point(192, 31);
            this.rt_cargo.Name = "rt_cargo";
            this.rt_cargo.Size = new System.Drawing.Size(71, 27);
            this.rt_cargo.TabIndex = 19;
            this.rt_cargo.TabStop = true;
            this.rt_cargo.Text = "cargo";
            this.rt_cargo.UseVisualStyleBackColor = true;
            // 
            // rt_codigo
            // 
            this.rt_codigo.AutoSize = true;
            this.rt_codigo.Location = new System.Drawing.Point(54, 34);
            this.rt_codigo.Name = "rt_codigo";
            this.rt_codigo.Size = new System.Drawing.Size(81, 27);
            this.rt_codigo.TabIndex = 18;
            this.rt_codigo.TabStop = true;
            this.rt_codigo.Text = "Codigo";
            this.rt_codigo.UseVisualStyleBackColor = true;
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Location = new System.Drawing.Point(453, 30);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(195, 28);
            this.txt_busqueda.TabIndex = 17;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(896, 623);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.bot_atras);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Usuarios";
            this.Text = "USUARIOS";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_cargo_usuario;
        private System.Windows.Forms.TextBox txt_apellido_usuario;
        private System.Windows.Forms.TextBox txt_nombre_usuario;
        private System.Windows.Forms.TextBox txt_codigo_usuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bot_buscar;
        private System.Windows.Forms.Button bot_actualizar;
        private System.Windows.Forms.Button bot_limpiar;
        private System.Windows.Forms.Button bot_eliminar;
        private System.Windows.Forms.Button bot_editar;
        private System.Windows.Forms.Button bot_nuevo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bot_generar_qr_usuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button bot_atras;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox txt_combo_acceso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bot_guardar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rt_cargo;
        private System.Windows.Forms.RadioButton rt_codigo;
        private System.Windows.Forms.TextBox txt_busqueda;
    }
}