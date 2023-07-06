namespace REGISTROS_ACADEMIA_LIDER
{
    partial class evento_busqueda
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
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bot_buscar = new System.Windows.Forms.Button();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rt_evento = new System.Windows.Forms.RadioButton();
            this.rt_codigo_evento = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.bot_atras = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txt_ciudad = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_celular = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.txt_ci = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.txt_grado = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label12.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(303, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(365, 40);
            this.label12.TabIndex = 27;
            this.label12.Text = "REGISTRO DE EVENTO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.bot_buscar);
            this.groupBox1.Controls.Add(this.txt_busqueda);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rt_evento);
            this.groupBox1.Controls.Add(this.rt_codigo_evento);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(22, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 187);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DE BUSQUEDA";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(149, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "LIMPIAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bot_buscar
            // 
            this.bot_buscar.BackColor = System.Drawing.Color.Maroon;
            this.bot_buscar.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_buscar.ForeColor = System.Drawing.Color.Gainsboro;
            this.bot_buscar.Location = new System.Drawing.Point(20, 129);
            this.bot_buscar.Name = "bot_buscar";
            this.bot_buscar.Size = new System.Drawing.Size(123, 38);
            this.bot_buscar.TabIndex = 6;
            this.bot_buscar.Text = "BUSCAR";
            this.bot_buscar.UseVisualStyleBackColor = false;
            this.bot_buscar.Click += new System.EventHandler(this.bot_buscar_Click);
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Location = new System.Drawing.Point(33, 95);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(204, 28);
            this.txt_busqueda.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(2, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "INGRESAR INFORMACION";
            // 
            // rt_evento
            // 
            this.rt_evento.AutoSize = true;
            this.rt_evento.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rt_evento.Location = new System.Drawing.Point(184, 27);
            this.rt_evento.Name = "rt_evento";
            this.rt_evento.Size = new System.Drawing.Size(92, 28);
            this.rt_evento.TabIndex = 1;
            this.rt_evento.TabStop = true;
            this.rt_evento.Text = "Evento";
            this.rt_evento.UseVisualStyleBackColor = true;
            // 
            // rt_codigo_evento
            // 
            this.rt_codigo_evento.AutoSize = true;
            this.rt_codigo_evento.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rt_codigo_evento.Location = new System.Drawing.Point(10, 26);
            this.rt_codigo_evento.Name = "rt_codigo_evento";
            this.rt_codigo_evento.Size = new System.Drawing.Size(160, 28);
            this.rt_codigo_evento.TabIndex = 0;
            this.rt_codigo_evento.TabStop = true;
            this.rt_codigo_evento.Text = "Codigo Evento";
            this.rt_codigo_evento.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGV1);
            this.groupBox2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(22, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(925, 246);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "REGISTROS ENCONTRADOS";
            // 
            // DGV1
            // 
            this.DGV1.AllowUserToOrderColumns = true;
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Location = new System.Drawing.Point(10, 27);
            this.DGV1.Name = "DGV1";
            this.DGV1.Size = new System.Drawing.Size(909, 213);
            this.DGV1.TabIndex = 0;
            this.DGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV1_CellContentClick);
            // 
            // bot_atras
            // 
            this.bot_atras.BackColor = System.Drawing.Color.Maroon;
            this.bot_atras.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_atras.ForeColor = System.Drawing.Color.Gainsboro;
            this.bot_atras.Location = new System.Drawing.Point(441, 504);
            this.bot_atras.Name = "bot_atras";
            this.bot_atras.Size = new System.Drawing.Size(123, 38);
            this.bot_atras.TabIndex = 33;
            this.bot_atras.Text = "ATRAS";
            this.bot_atras.UseVisualStyleBackColor = false;
            this.bot_atras.Click += new System.EventHandler(this.bot_atras_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.txt_estado);
            this.groupBox11.Controls.Add(this.label2);
            this.groupBox11.Controls.Add(this.label25);
            this.groupBox11.Controls.Add(this.txt_ciudad);
            this.groupBox11.Controls.Add(this.label29);
            this.groupBox11.Controls.Add(this.txt_codigo);
            this.groupBox11.Controls.Add(this.txt_celular);
            this.groupBox11.Controls.Add(this.label34);
            this.groupBox11.Controls.Add(this.txt_nombre);
            this.groupBox11.Controls.Add(this.label35);
            this.groupBox11.Controls.Add(this.txt_email);
            this.groupBox11.Controls.Add(this.label36);
            this.groupBox11.Controls.Add(this.txt_apellido);
            this.groupBox11.Controls.Add(this.label37);
            this.groupBox11.Controls.Add(this.txt_ci);
            this.groupBox11.Controls.Add(this.label38);
            this.groupBox11.Controls.Add(this.txt_grado);
            this.groupBox11.Controls.Add(this.label39);
            this.groupBox11.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.Location = new System.Drawing.Point(310, 64);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(637, 188);
            this.groupBox11.TabIndex = 34;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "DATOS DE EVENTO";
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(480, 84);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(151, 24);
            this.txt_estado.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(335, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 43;
            this.label2.Text = "ESTADO";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label25.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold);
            this.label25.Location = new System.Drawing.Point(337, 115);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(98, 22);
            this.label25.TabIndex = 33;
            this.label25.Text = "DOCENTE";
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.Location = new System.Drawing.Point(480, 26);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(151, 24);
            this.txt_ciudad.TabIndex = 40;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label29.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold);
            this.label29.Location = new System.Drawing.Point(337, 55);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(84, 22);
            this.label29.TabIndex = 20;
            this.label29.Text = "CIUDAD";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(183, 28);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(151, 24);
            this.txt_codigo.TabIndex = 35;
            // 
            // txt_celular
            // 
            this.txt_celular.Location = new System.Drawing.Point(480, 115);
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.Size = new System.Drawing.Size(151, 24);
            this.txt_celular.TabIndex = 42;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label34.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold);
            this.label34.Location = new System.Drawing.Point(14, 57);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(85, 22);
            this.label34.TabIndex = 2;
            this.label34.Text = "EVENTO";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(183, 57);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(151, 24);
            this.txt_nombre.TabIndex = 36;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label35.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold);
            this.label35.Location = new System.Drawing.Point(335, 26);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(139, 22);
            this.label35.TabIndex = 6;
            this.label35.Text = "FECHA FINAL";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(480, 55);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(151, 24);
            this.txt_email.TabIndex = 41;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label36.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold);
            this.label36.Location = new System.Drawing.Point(14, 28);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(83, 22);
            this.label36.TabIndex = 1;
            this.label36.Text = "CODIGO";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(183, 86);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(151, 24);
            this.txt_apellido.TabIndex = 37;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label37.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold);
            this.label37.Location = new System.Drawing.Point(7, 147);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(146, 22);
            this.label37.TabIndex = 5;
            this.label37.Text = "FECHA INICIO";
            // 
            // txt_ci
            // 
            this.txt_ci.Location = new System.Drawing.Point(183, 115);
            this.txt_ci.Name = "txt_ci";
            this.txt_ci.Size = new System.Drawing.Size(151, 24);
            this.txt_ci.TabIndex = 38;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label38.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold);
            this.label38.Location = new System.Drawing.Point(7, 86);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(124, 22);
            this.label38.TabIndex = 3;
            this.label38.Text = "MODALIDAD";
            // 
            // txt_grado
            // 
            this.txt_grado.Location = new System.Drawing.Point(183, 147);
            this.txt_grado.Name = "txt_grado";
            this.txt_grado.Size = new System.Drawing.Size(151, 24);
            this.txt_grado.TabIndex = 39;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label39.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold);
            this.label39.Location = new System.Drawing.Point(7, 113);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(172, 22);
            this.label39.TabIndex = 4;
            this.label39.Text = "CARGA HORARIA";
            // 
            // evento_busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(961, 557);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.bot_atras);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Name = "evento_busqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUSCAR DE REGISTRO EVENTO";
            this.Load += new System.EventHandler(this.evento_busqueda_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bot_buscar;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rt_evento;
        private System.Windows.Forms.RadioButton rt_codigo_evento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.Button bot_atras;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox txt_ciudad;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_celular;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_ci;
        private System.Windows.Forms.TextBox txt_grado;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}