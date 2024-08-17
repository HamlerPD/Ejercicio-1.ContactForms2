using Ejercicio_1.ContactForms2.Class;

namespace Ejercicio_1.ContactForms2
{
    public partial class frmContact : Form
    {

        ContactDao contactDao;

        Negocio negocio = new Negocio();
        public frmContact()
        {
            this.contactDao = new ContactDao();
            InitializeComponent();
        }

        private void frmContact_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dtpFechaContra_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Negocio newNegocio = new Negocio()
            {

                
                Apellidos = tbxApellido.Text,
                Codigo = tbxCodigo.Text,
                Correo = tbxCorreo.Text,
                Departamento = tbxDepartamento.Text,
                Direccion = tbxDireccion.Text,
                Nombres = tbxNombre.Text,
                Posicion = tbxPosicion.Text,
                Telefono = tbxTelefono.Text,
                FechaContratacion = dtpFechaContra.Value,

            };
            this.contactDao.Guardar(newNegocio);

            var negocio = this.contactDao.ObtenerContactos();

            this.dgvContacts.DataSource = negocio.ToArray();
            this.dgvContacts.Refresh();

            limpiarcampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarcampos();
        }

        void limpiarcampos()
        {
            tbxApellido.Text = string.Empty;
            tbxCodigo.Text = string.Empty;
            tbxCorreo.Text = string.Empty;
            tbxDepartamento.Text = string.Empty;
            tbxDireccion.Text = string.Empty;
            tbxNombre.Text = string.Empty;
            tbxPosicion.Text = string.Empty;
            tbxTelefono.Text = string.Empty;
            dtpFechaContra.Text = DateTime.Now.ToString();
            tbxNombre.Focus();
        }

        private void tbxNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}