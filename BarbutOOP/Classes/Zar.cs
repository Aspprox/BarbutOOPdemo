using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbutOOP.Classes
{
    class Zar
    {
        byte _sayi; //field
        string[] _yazilar = new string[6]
        {
            "   \n * \n   ", //1
            "  *\n   \n*  ", //2
            " * \n * \n * ", //3
            "* *\n   \n* *", //4
            "* *\n * \n* *", //5
            "* *\n* *\n* *", //6
        };


        Random _rasgele = new Random(); //field
        public byte ZarAt()
        {
            _sayi = (byte)_rasgele.Next(0, 6);  //son değer + 1 o yüzden 6 //casting //index olarak 
            //değiştirdik
            return _sayi;

        }

        public string ZarYazısınıGetir(byte sayi)
        {
            return _yazilar[sayi];  //index için  
        }
    }
}
