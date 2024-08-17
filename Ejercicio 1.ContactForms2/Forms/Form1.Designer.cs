namespace Ejercicio_1.ContactForms2
{
    partial class frmContact
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label12 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            dgvContacts = new DataGridView();
            groupBox1 = new GroupBox();
            dtpFechaContra = new DateTimePicker();
            label11 = new Label();
            tbxDepartamento = new TextBox();
            label9 = new Label();
            tbxPosicion = new TextBox();
            label10 = new Label();
            tbxDireccion = new TextBox();
            label5 = new Label();
            tbxTelefono = new TextBox();
            label7 = new Label();
            tbxCodigo = new TextBox();
            label8 = new Label();
            tbxCorreo = new TextBox();
            label3 = new Label();
            tbxApellido = new TextBox();
            label2 = new Label();
            tbxNombre = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvContacts).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.World);
            label12.Location = new Point(240, 30);
            label12.Name = "label12";
            label12.Size = new Size(177, 25);
            label12.TabIndex = 21;
            label12.Text = "Datos de Contactos";
            label12.Click += label12_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(581, 332);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 23);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(361, 332);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(159, 23);
            btnGuardar.TabIndex = 24;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvContacts
            // 
            dgvContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContacts.Location = new Point(12, 397);
            dgvContacts.Name = "dgvContacts";
            dgvContacts.RowTemplate.Height = 25;
            dgvContacts.Size = new Size(719, 150);
            dgvContacts.TabIndex = 25;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpFechaContra);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(tbxDepartamento);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(tbxPosicion);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(tbxDireccion);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbxTelefono);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(tbxCodigo);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(tbxCorreo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbxApellido);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbxNombre);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(10, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.No;
            groupBox1.Size = new Size(722, 239);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Contactos";
            groupBox1.UseWaitCursor = true;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dtpFechaContra
            // 
            dtpFechaContra.Location = new Point(480, 62);
            dtpFechaContra.Name = "dtpFechaContra";
            dtpFechaContra.Size = new Size(200, 23);
            dtpFechaContra.TabIndex = 40;
            dtpFechaContra.UseWaitCursor = true;
            dtpFechaContra.ValueChanged += dtpFechaContra_ValueChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(348, 68);
            label11.Name = "label11";
            label11.Size = new Size(130, 15);
            label11.TabIndex = 39;
            label11.Text = "Fecha de Contratacion";
            label11.UseWaitCursor = true;
            // 
            // tbxDepartamento
            // 
            tbxDepartamento.Location = new Point(480, 26);
            tbxDepartamento.Name = "tbxDepartamento";
            tbxDepartamento.Size = new Size(161, 23);
            tbxDepartamento.TabIndex = 38;
            tbxDepartamento.UseWaitCursor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(391, 34);
            label9.Name = "label9";
            label9.Size = new Size(89, 15);
            label9.TabIndex = 37;
            label9.Text = "Departamento";
            label9.UseWaitCursor = true;
            // 
            // tbxPosicion
            // 
            tbxPosicion.Location = new Point(99, 195);
            tbxPosicion.Name = "tbxPosicion";
            tbxPosicion.Size = new Size(106, 23);
            tbxPosicion.TabIndex = 36;
            tbxPosicion.UseWaitCursor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(43, 203);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 35;
            label10.Text = "Posicion";
            label10.UseWaitCursor = true;
            // 
            // tbxDireccion
            // 
            tbxDireccion.Location = new Point(99, 166);
            tbxDireccion.Name = "tbxDireccion";
            tbxDireccion.Size = new Size(106, 23);
            tbxDireccion.TabIndex = 34;
            tbxDireccion.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 174);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 33;
            label5.Text = "Direccion";
            label5.UseWaitCursor = true;
            // 
            // tbxTelefono
            // 
            tbxTelefono.Location = new Point(100, 137);
            tbxTelefono.Name = "tbxTelefono";
            tbxTelefono.Size = new Size(106, 23);
            tbxTelefono.TabIndex = 32;
            tbxTelefono.UseWaitCursor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 145);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 31;
            label7.Text = "Telefono";
            label7.UseWaitCursor = true;
            // 
            // tbxCodigo
            // 
            tbxCodigo.Location = new Point(100, 108);
            tbxCodigo.Name = "tbxCodigo";
            tbxCodigo.Size = new Size(106, 23);
            tbxCodigo.TabIndex = 30;
            tbxCodigo.UseWaitCursor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(43, 116);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 29;
            label8.Text = "Codigo";
            label8.UseWaitCursor = true;
            // 
            // tbxCorreo
            // 
            tbxCorreo.Location = new Point(99, 79);
            tbxCorreo.Name = "tbxCorreo";
            tbxCorreo.Size = new Size(151, 23);
            tbxCorreo.TabIndex = 28;
            tbxCorreo.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 86);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 27;
            label3.Text = "Correo";
            label3.UseWaitCursor = true;
            // 
            // tbxApellido
            // 
            tbxApellido.Location = new Point(100, 50);
            tbxApellido.Name = "tbxApellido";
            tbxApellido.Size = new Size(106, 23);
            tbxApellido.TabIndex = 26;
            tbxApellido.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 57);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 25;
            label2.Text = "Apellidos";
            label2.UseWaitCursor = true;
            // 
            // tbxNombre
            // 
            tbxNombre.Location = new Point(100, 21);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(106, 23);
            tbxNombre.TabIndex = 24;
            tbxNombre.UseWaitCursor = true;
            tbxNombre.TextChanged += tbxNombre_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 29);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 23;
            label1.Text = "Nombres";
            label1.UseWaitCursor = true;
            // 
            // frmContact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 575);
            Controls.Add(groupBox1);
            Controls.Add(dgvContacts);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(label12);
            Name = "frmContact";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contact Form";
            Load += frmContact_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContacts).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label12;
        private Button btnCancelar;
        private Button btnGuardar;
        private DataGridView dgvContacts;
        private GroupBox groupBox1;
        private DateTimePicker dtpFechaContra;
        private Label label11;
        private TextBox tbxDepartamento;
        private Label label9;
        private TextBox tbxPosicion;
        private Label label10;
        private TextBox tbxDireccion;
        private Label label5;
        private TextBox tbxTelefono;
        private Label label7;
        private TextBox tbxCodigo;
        private Label label8;
        private TextBox tbxCorreo;
        private Label label3;
        private TextBox tbxApellido;
        private Label label2;
        private TextBox tbxNombre;
        private Label label1;
    }
}