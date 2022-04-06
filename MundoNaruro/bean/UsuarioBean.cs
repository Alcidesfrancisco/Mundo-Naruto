using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MundoNaruro
{
    public class UsuarioBean
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private String email;

        public String Email
        {
            get { return email; }
            set { email = value; }
        }
        private DateTime dataNascimento;

        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }
        private string dataCadastro;

        public string DataCadastro
        {
            get { return dataCadastro; }
            set { dataCadastro = value; }
        }

        private string login;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        private string senha;

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        private byte newsLetter; public byte NewsLetter { get; set; }

    }
}