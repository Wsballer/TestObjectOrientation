using System;
using System.Collections.Generic;
using System.Text;

namespace TestObjectOrientation
{
    class Abracadabra
    {
        public int Vavavoom;

        public bool Lala(int floq)
        {
            if (floq < Vavavoom)
            {
                Vavavoom += floq;
                return true;
            }
            return false;
        }
    }
}
