﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Almacen
{
    public partial class SiteMaster : MasterPage
    {
        #region Propiedades
        public HyperLink HyperLinkAlmacenes
        {
            get
            {
                return hlkAlmacenes;
            }
            set
            {
                hlkAlmacenes = value;
            }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}