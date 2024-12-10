using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
