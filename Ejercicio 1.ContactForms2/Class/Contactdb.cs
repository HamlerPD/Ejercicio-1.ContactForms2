
namespace Ejercicio_1.ContactForms2.Class
{

    /// <summary>
    /// Objeto creado para el acceso a los datos del formulario de contactos.
    /// </summary>
    public class ContactDao
    {
        private List<Negocio> negocio;

        public ContactDao()
        {
            this.negocio = new List<Negocio>();
        }

        /// <summary>
        /// Metodo para guardar un contacto.
        /// </summary>
        /// <param name="negocio">Contactto que desea guardar</param>
        public void Guardar( Negocio negocio)
        {
            if (negocio == null)
            {
                throw new ArgumentNullException(" El contacto es requerido para ejecutar este metodo");
            }

            this.negocio.Add(negocio);
        }

        /// <summary>
        /// Metodo para obtener todos los contactos
        /// </summary>
        /// <returns>Retorna una lista de los contactos</returns>

        public List<Negocio> ObtenerContactos()
        {
            return this.negocio;
        }

        /// <summary>
        /// Metodo para obtener el contacto a partir del codigo. 
        /// </summary>
        /// <param name="codigo">codigo del contacto que desea ver el detalle</param>
        /// <returns>Contacto encontrado a partir del codigo</returns>
        public Negocio ObtenerContacto(string codigo)
        {
            return this.negocio.FirstOrDefault(co => co.Codigo == codigo);
        }
    }
}
 