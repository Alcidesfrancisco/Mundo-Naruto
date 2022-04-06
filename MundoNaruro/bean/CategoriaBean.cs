using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MundoNaruro.bean
{
    public class CategoriaBean
    {
        private int idCategoria;

        public int IdCategoria
        {
            get { return idCategoria; }
            set { idCategoria = value; }
        }
        private string nomeCategoria;

        public string NomeCategoria
        {
            get { return nomeCategoria; }
            set { nomeCategoria = value; }
        }


    }
}