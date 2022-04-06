using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MundoNaruro.Conexao
{
    public class Conectar
    {
        public static string strconexao = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Alcides\Desktop\MundoNaruro\MundoNaruro\App_Data\NarutoBanco.mdf;Integrated Security=True;User Instance=True";

        public string Strconexao
        {
            get { return strconexao; }
            set { strconexao = value; }
        }
    }
}