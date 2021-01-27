using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Urun
    {
        //Property = public int/string/double/...
        public int Id { get; set; } //Id = eşsiz değer olarak , aynı isimli birçok kişi olabilir
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }

    }
}
