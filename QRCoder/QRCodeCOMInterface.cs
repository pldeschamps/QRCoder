using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QRCoder
{
    class QRCodeCOMInterface
    {
        private string copyright = "Pierre-Louis Deschamps 2019";
        private string test;
        public string Copyright { get { return copyright; } }
        public string Test
        {
            get { return test; }
            set { test = value; }
        }
    }
}
