using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using KTPOS_Order.Proccess;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace KTPOS_Order.Management_Control
{
    public class GetList
    {
        private static GetList instance;
        public static GetList Instance
        {
            get { if (instance == null) instance = new GetList(); return instance; }
            private set { instance = value; }
        }

    }
}
  
