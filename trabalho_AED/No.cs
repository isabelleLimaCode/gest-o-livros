using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_AED
{
    class No<T>
    {
        private string isbn;
        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }

        }
        private string tipo;
        public string Tipo1
        {
            get { return tipo; }
            set { tipo = value; }
        }
        private string titulo;
        public string Titulo1
        {
            get { return titulo; }
            set { titulo = value; }
        }
        private string autor;
        public string autor1
        {
            get { return autor; }
            set { autor = value; }
        }
        private string editora;
        public string editora1
        {
            get { return editora; }
            set { editora = value; }
        }
        private No<T> _proximo;
        public No<T> proximo
        {
            get { return _proximo; }
            set { _proximo = value; }
        }


    }
}
