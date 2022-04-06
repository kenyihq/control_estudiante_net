namespace Presentation
{
    partial class FormEstudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstudiantes));
            this.closePic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataEst = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pNombre = new System.Windows.Forms.TextBox();
            this.sNombre = new System.Windows.Forms.TextBox();
            this.pApellido = new System.Windows.Forms.TextBox();
            this.sApellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nac = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.obs = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.closePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEst)).BeginInit();
            this.SuspendLayout();
            // 
            // closePic
            // 
            this.closePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePic.Image = ((System.Drawing.Image)(resources.GetObject("closePic.Image")));
            this.closePic.Location = new System.Drawing.Point(12, 12);
            this.closePic.Name = "closePic";
            this.closePic.Size = new System.Drawing.Size(34, 24);
            this.closePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closePic.TabIndex = 0;
            this.closePic.TabStop = false;
            this.closePic.Click += new System.EventHandler(this.closePic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de estudiantes";
            // 
            // dataEst
            // 
            this.dataEst.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataEst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEst.Location = new System.Drawing.Point(12, 42);
            this.dataEst.Name = "dataEst";
            this.dataEst.Size = new System.Drawing.Size(1147, 434);
            this.dataEst.TabIndex = 2;
            this.dataEst.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEst_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1161, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Primer nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1161, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Segundo nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1161, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Primer apellido";
            // 
            // pNombre
            // 
            this.pNombre.Location = new System.Drawing.Point(1165, 63);
            this.pNombre.Name = "pNombre";
            this.pNombre.Size = new System.Drawing.Size(279, 20);
            this.pNombre.TabIndex = 6;
            // 
            // sNombre
            // 
            this.sNombre.Location = new System.Drawing.Point(1165, 109);
            this.sNombre.Name = "sNombre";
            this.sNombre.Size = new System.Drawing.Size(279, 20);
            this.sNombre.TabIndex = 7;
            // 
            // pApellido
            // 
            this.pApellido.Location = new System.Drawing.Point(1165, 155);
            this.pApellido.Name = "pApellido";
            this.pApellido.Size = new System.Drawing.Size(279, 20);
            this.pApellido.TabIndex = 8;
            // 
            // sApellido
            // 
            this.sApellido.Location = new System.Drawing.Point(1165, 201);
            this.sApellido.Name = "sApellido";
            this.sApellido.Size = new System.Drawing.Size(279, 20);
            this.sApellido.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1161, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Segundo apellido";
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(1165, 247);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(279, 20);
            this.tel.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1161, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Teléfono";
            // 
            // cel
            // 
            this.cel.Location = new System.Drawing.Point(1165, 293);
            this.cel.Name = "cel";
            this.cel.Size = new System.Drawing.Size(279, 20);
            this.cel.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1161, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Celular";
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(1165, 339);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(279, 20);
            this.direccion.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1161, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Dirección";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(1165, 385);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(279, 20);
            this.email.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1161, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Email";
            // 
            // nac
            // 
            this.nac.Location = new System.Drawing.Point(1165, 431);
            this.nac.Name = "nac";
            this.nac.Size = new System.Drawing.Size(279, 20);
            this.nac.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1161, 408);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Nacimiento";
            // 
            // obs
            // 
            this.obs.Location = new System.Drawing.Point(1165, 477);
            this.obs.Multiline = true;
            this.obs.Name = "obs";
            this.obs.Size = new System.Drawing.Size(279, 55);
            this.obs.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1161, 454);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Observaciones";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNuevo.Location = new System.Drawing.Point(181, 496);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(116, 36);
            this.btnNuevo.TabIndex = 23;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGuardar.Location = new System.Drawing.Point(422, 498);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(116, 36);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditar.Location = new System.Drawing.Point(682, 496);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(116, 36);
            this.btnEditar.TabIndex = 25;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminar.Location = new System.Drawing.Point(935, 496);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(116, 36);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FormEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1453, 546);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.obs);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.nac);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sApellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pApellido);
            this.Controls.Add(this.sNombre);
            this.Controls.Add(this.pNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataEst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closePic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEstudiantes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormEstudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox closePic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataEst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pNombre;
        private System.Windows.Forms.TextBox sNombre;
        private System.Windows.Forms.TextBox pApellido;
        private System.Windows.Forms.TextBox sApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nac;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox obs;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnNuevo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
    }
}

