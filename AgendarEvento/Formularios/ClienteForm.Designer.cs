namespace AgendarEvento
{
    partial class ClienteForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtOtroContacto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.Label();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Otro Contacto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cedula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Correo Electronico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dirrecion";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(190, 103);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(120, 26);
            this.txtNombre.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(190, 175);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(120, 26);
            this.txtEmail.TabIndex = 7;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(189, 248);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(121, 26);
            this.txtCedula.TabIndex = 8;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(189, 320);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(121, 26);
            this.txtTelefono.TabIndex = 9;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(189, 392);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(121, 55);
            this.txtDireccion.TabIndex = 10;
            // 
            // txtOtroContacto
            // 
            this.txtOtroContacto.Location = new System.Drawing.Point(190, 491);
            this.txtOtroContacto.Name = "txtOtroContacto";
            this.txtOtroContacto.Size = new System.Drawing.Size(120, 26);
            this.txtOtroContacto.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 651);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 42);
            this.button1.TabIndex = 12;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(890, 651);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 42);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(342, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(597, 542);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Location = new System.Drawing.Point(70, 38);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(71, 20);
            this.txtId.TabIndex = 15;
            this.txtId.Text = "# Cliente";
            // 
            // txtClienteId
            // 
            this.txtClienteId.Location = new System.Drawing.Point(162, 34);
            this.txtClienteId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.Size = new System.Drawing.Size(148, 26);
            this.txtClienteId.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(100, 651);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 42);
            this.button3.TabIndex = 17;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(360, 651);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 35);
            this.button4.TabIndex = 18;
            this.button4.Text = "ELiminar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 709);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtClienteId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtOtroContacto);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ClienteForm";
            this.Text = "ClienteForm";
            this.Load += new System.EventHandler(this.ClienteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtOtroContacto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label txtId;
        private System.Windows.Forms.TextBox txtClienteId;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}