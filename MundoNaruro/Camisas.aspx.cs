using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MundoNaruro.control;
using System.Collections;
using MundoNaruro.bean;

namespace MundoNaruro
{
    public partial class compraCamisa : System.Web.UI.Page
    {
        ProdutoBean compra = new ProdutoBean();
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }
        
        public void comprarImageButton_Click(object sender, ImageClickEventArgs e)
        {
          Response.Redirect(comprarImageButton.ImageUrl);

        }

 

  

    }
}