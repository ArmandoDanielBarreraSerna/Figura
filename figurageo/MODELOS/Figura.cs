using System;
using System.Collections.Generic;
using System.Text;

namespace figurageo
{
    public class Figura
    {
        public int _atributo1 { set; get; }
        private int _atributo2 { set; get; }
        protected int _atributo3 { set; get; }
        protected int _atributo4 { set; get; }

        public Figura()
        {
            _atributo1 = 1;
            _atributo2 = 1;
            _atributo3 = 1;
        }

    }



}