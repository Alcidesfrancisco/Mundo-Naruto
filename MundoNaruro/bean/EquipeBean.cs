using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MundoNaruro.bean
{
    public class EquipeBean : UsuarioBean
    {

        string perfil; public string Perfil { get; set; }
        string facebook; public string Facebbok { get; set; }
        string frase; public string Frase { get; set; }
        string foto; public string Foto { get; set; }
    }
}