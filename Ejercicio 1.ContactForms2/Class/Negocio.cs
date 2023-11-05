

using System.Globalization;

namespace Ejercicio_1.ContactForms2.Class
{
    /// <summary>
    /// Clase para manejar datos de los conatctos.
    /// </summary>
    public class Negocio
    {
        #region "Atributos o campos de nuestra clase"
        private string _codigo;
        private string _nombres;
        private string _apellidos;
        private string _correo;
        private string _telefono;
        private string _direccion;
        private string _posicion;
        private string _deparmento;
        private DaylightTime _fechaContratacion;

        #endregion

        #region"Propiedades de la clase"


        /// <summary>
        /// Esta propiedad es para almacenar el nombre del contacto.
        /// </summary>
        public string Nombres
        {
            get { return _nombres; }
            set { _nombres = value; }
        }

        /// <summary>
        /// Esta propiedad es para almacenar el codigo del contacto.
        /// </summary>
        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        /// <summary>
        /// Esta propiedad es para almacenar el apellido del contacto.
        /// </summary>
        public string Apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }


        /// <summary>
        /// Esta propiedad es para almacenar el correo del contacto.
        /// </summary>
        public string Correo
        {
            get { return _correo; }
            set { _correo = value; }
        }

        /// <summary>
        /// Esta propiedad es para almacenar el telefono del contacto.
        /// </summary>
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        /// <summary>
        /// Esta propiedad es para almacenar la direccion del contacto.
        /// </summary>
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }


        /// <summary>
        /// Esta propiedad es para almacenar la posicion del contacto.
        /// </summary>
        public string Posicion
        {
            get { return _posicion; }
            set { _posicion = value; }
        }

        /// <summary>
        /// Esta propiedad es para almacenar la departamento del contacto.
        /// </summary>

        public string Departamento
        {
            get { return _deparmento; }
            set { _deparmento = value; }
        }

        /// <summary>
        /// Esta propiedad es para almacenar la fecha de contratacion del contacto.
        /// </summary>

        public DaylightTime FechaContratacion
        {
            get { return _fechaContratacion; }
            set { _fechaContratacion = value; }
        }
        #endregion


    }
}