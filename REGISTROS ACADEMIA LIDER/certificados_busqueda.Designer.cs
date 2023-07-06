namespace REGISTROS_ACADEMIA_LIDER
{
    partial class certificados_busqueda
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rt_cedula = new System.Windows.Forms.RadioButton();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bot_buscar = new System.Windows.Forms.Button();
            this.rt_codigo_certificado = new System.Windows.Forms.RadioButton();
            this.bot_atras = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ciudad = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.txt_ci = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.txt_grado = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label12.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(164, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(472, 40);
            this.label12.TabIndex = 26;
            this.label12.Text = "REGISTRO DE CERTIFICADOS";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGV1);
            this.groupBox2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(-2, 327);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(797, 267);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "REGISTROS ENCONTRADOS";
            // 
            // DGV1
            // 
            this.DGV1.AllowUserToOrderColumns = true;
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Location = new System.Drawing.Point(12, 27);
            this.DGV1.Name = "DGV1";
            this.DGV1.Size = new System.Drawing.Size(779, 224);
            this.DGV1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rt_cedula);
            this.groupBox1.Controls.Add(this.txt_busqueda);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bot_buscar);
            this.groupBox1.Controls.Add(this.rt_codigo_certificado);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(10, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 205);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DE BUSQUEDA";
            // 
            // rt_cedula
            // 
            this.rt_cedula.AutoSize = true;
            this.rt_cedula.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rt_cedula.Location = new System.Drawing.Point(67, 69);
            this.rt_cedula.Name = "rt_cedula";
            this.rt_cedula.Size = new System.Drawing.Size(188, 28);
            this.rt_cedula.TabIndex = 7;
            this.rt_cedula.TabStop = true;
            this.rt_cedula.Text = "Cedula Identidad";
            this.rt_cedula.UseVisualStyleBackColor = true;
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Location = new System.Drawing.Point(10, 141);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(172, 28);
            this.txt_busqueda.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(39, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "INGRESAR INFORMACION";
            // 
            // bot_buscar
            // 
            this.bot_buscar.BackColor = System.Drawing.Color.Maroon;
            this.bot_buscar.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_buscar.ForeColor = System.Drawing.Color.Gainsboro;
            this.bot_buscar.Location = new System.Drawing.Point(188, 135);
            this.bot_buscar.Name = "bot_buscar";
            this.bot_buscar.Size = new System.Drawing.Size(123, 38);
            this.bot_buscar.TabIndex = 6;
            this.bot_buscar.Text = "BUSCAR";
            this.bot_buscar.UseVisualStyleBackColor = false;
            this.bot_buscar.Click += new System.EventHandler(this.bot_buscar_Click);
            // 
            // rt_codigo_certificado
            // 
            this.rt_codigo_certificado.AutoSize = true;
            this.rt_codigo_certificado.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rt_codigo_certificado.Location = new System.Drawing.Point(67, 34);
            this.rt_codigo_certificado.Name = "rt_codigo_certificado";
            this.rt_codigo_certificado.Size = new System.Drawing.Size(189, 28);
            this.rt_codigo_certificado.TabIndex = 0;
            this.rt_codigo_certificado.TabStop = true;
            this.rt_codigo_certificado.Text = "Codigo Cetificado";
            this.rt_codigo_certificado.UseVisualStyleBackColor = true;
            // 
            // bot_atras
            // 
            this.bot_atras.BackColor = System.Drawing.Color.Maroon;
            this.bot_atras.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_atras.ForeColor = System.Drawing.Color.Gainsboro;
            this.bot_atras.Location = new System.Drawing.Point(345, 600);
            this.bot_atras.Name = "bot_atras";
            this.bot_atras.Size = new System.Drawing.Size(123, 38);
            this.bot_atras.TabIndex = 7;
            this.bot_atras.Text = "ATRAS";
            this.bot_atras.UseVisualStyleBackColor = false;
            this.bot_atras.Click += new System.EventHandler(this.bot_atras_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.txt_apellidos);
            this.groupBox12.Controls.Add(this.label2);
            this.groupBox12.Controls.Add(this.txt_ciudad);
            this.groupBox12.Controls.Add(this.label31);
            this.groupBox12.Controls.Add(this.txt_codigo);
            this.groupBox12.Controls.Add(this.txt_nombre);
            this.groupBox12.Controls.Add(this.label32);
            this.groupBox12.Controls.Add(this.txt_apellido);
            this.groupBox12.Controls.Add(this.label33);
            this.groupBox12.Controls.Add(this.txt_ci);
            this.groupBox12.Controls.Add(this.label40);
            this.groupBox12.Controls.Add(this.txt_grado);
            this.groupBox12.Controls.Add(this.label41);
            this.groupBox12.Controls.Add(this.label42);
            this.groupBox12.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox12.Location = new System.Drawing.Point(384, 61);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(411, 260);
            this.groupBox12.TabIndex = 29;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "CERTIFICADOS";
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Location = new System.Drawing.Point(216, 87);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(151, 28);
            this.txt_apellidos.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 36;
            this.label2.Text = "APELLIDO";
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.Location = new System.Drawing.Point(216, 210);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(151, 28);
            this.txt_ciudad.TabIndex = 35;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label31.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold);
            this.label31.Location = new System.Drawing.Point(6, 53);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(93, 22);
            this.label31.TabIndex = 2;
            this.label31.Text = "NOMBRE";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(216, 27);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(151, 28);
            this.txt_codigo.TabIndex = 30;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(216, 56);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(151, 28);
            this.txt_nombre.TabIndex = 31;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label32.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold);
            this.label32.Location = new System.Drawing.Point(12, 210);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(74, 22);
            this.label32.TabIndex = 6;
            this.label32.Text = "FECHA";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(216, 119);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(151, 28);
            this.txt_apellido.TabIndex = 32;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label33.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold);
            this.label33.Location = new System.Drawing.Point(6, 22);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(83, 22);
            this.label33.TabIndex = 1;
            this.label33.Text = "CODIGO";
            // 
            // txt_ci
            // 
            this.txt_ci.Location = new System.Drawing.Point(216, 148);
            this.txt_ci.Name = "txt_ci";
            this.txt_ci.Size = new System.Drawing.Size(151, 28);
            this.txt_ci.TabIndex = 33;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label40.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold);
            this.label40.Location = new System.Drawing.Point(12, 181);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(62, 22);
            this.label40.TabIndex = 5;
            this.label40.Text = "NOTA";
            // 
            // txt_grado
            // 
            this.txt_grado.Location = new System.Drawing.Point(216, 179);
            this.txt_grado.Name = "txt_grado";
            this.txt_grado.Size = new System.Drawing.Size(151, 28);
            this.txt_grado.TabIndex = 34;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label41.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold);
            this.label41.Location = new System.Drawing.Point(6, 118);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(199, 22);
            this.label41.TabIndex = 3;
            this.label41.Text = "CEDULA IDENTIDAD";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label42.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold);
            this.label42.Location = new System.Drawing.Point(6, 149);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(165, 22);
            this.label42.TabIndex = 4;
            this.label42.Text = "EVENTO/TALLER";
            // 
            // certificados_busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(828, 642);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.bot_atras);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label12);
            this.Name = "certificados_busqueda";
            this.Text = "BUSCAR DE REGISTRO CERTIFICADO";
            this.Load += new System.EventHandler(this.certificados_busqueda_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rt_codigo_certificado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bot_buscar;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.Button bot_atras;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox txt_ciudad;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_ci;
        private System.Windows.Forms.TextBox txt_grado;
        private System.Windows.Forms.RadioButton rt_cedula;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.Label label2;
    }
}