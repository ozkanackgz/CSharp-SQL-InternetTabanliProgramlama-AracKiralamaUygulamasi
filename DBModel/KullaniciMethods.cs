using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBModel
{
    public class KullaniciMethods
    {
        public bool KimlikDogrula(string ad, string sifre)
        {
            if (ad == "bilgehan" && sifre == "1")
                return true;
            else
                return false;
        }
    }
}
