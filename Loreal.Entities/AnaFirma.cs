using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loreal.Entities
{
    public class AnaFirma:BaseEntity,IEntity
    {
        public string FirmaKodu { get; set; }
        public string FirmaAdi { get; set; }
        public IList<Firma> Firmalar { get; set; }







    }
}