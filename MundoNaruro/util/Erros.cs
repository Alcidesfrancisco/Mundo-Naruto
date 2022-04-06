using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MundoNaruro.control;
using System.Collections;
using MundoNaruro.bean;
namespace MundoNaruro.util
{
    public class Erros
    {
        public static void erroNull()
        {
           compraCamisa erro = new compraCamisa();
            erro.comprarImageButton_Click(null,null);
        }


    }
}