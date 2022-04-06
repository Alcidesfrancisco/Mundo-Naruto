using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MundoNaruro.bean;
using MundoNaruro.util;

namespace MundoNaruro.util
{
    public class NewsLetter
    {
        Email email = new Email();
        public void EnviarnewsLetter(string texto)
        {
            if (DateTime.Now.Day % 7 == 0 && DateTime.Now.Hour == 12) ;
            string newsLetter = email.enviarEmail(texto, " NewsLetter Mundo Naruto", "Apartir de agora vc receberá semanlmente nossa NewsLetter com as principais Novidades do Mundo Naruto!!");

        }
    }
}