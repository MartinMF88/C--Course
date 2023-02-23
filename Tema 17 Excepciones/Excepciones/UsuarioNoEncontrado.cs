using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class UsuarioNoEncontradoException : Exception
    {
        public UsuarioNoEncontradoException()
        {

        }
        public UsuarioNoEncontradoException(string message, Exception ex) : base(message, ex)
        {
            // logica para la excepcion
        }
    }

