﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTPOS_Order.Management_Control
{
    public class GetLists
    {
        private static GetLists instance;
        public static GetLists Instance
        {
            get { if (instance == null) instance = new GetLists(); return instance; }
            private set { instance = value; }
        }

    }
}
