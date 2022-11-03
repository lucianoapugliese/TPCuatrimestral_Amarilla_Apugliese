﻿using Clinica.Dominio.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Profile;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clinica.Views
{
    public partial class Default : System.Web.UI.Page
    {
        public string Seleccion { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Seleccion = "";
            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                Response.Redirect("Error.aspx", false);  
            }
        }

        protected void ddlTipoUsario_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ver si es necesario el metodo
        }

        protected void btnIngreso_Click(object sender, EventArgs e)
        {
            if(tbxContraseña.Text != "")
            {
                lblNombreUsuario.Text = tbxUsuario.Text;
                Seleccion = ddlTipoUsario.SelectedValue;
            }
        }
    }
}