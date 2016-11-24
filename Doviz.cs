using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DovizKurlari
{
    public class Doviz
    {
        public string KurAdi { get; set; }


        public string KurKodu { get; set; }
        public decimal AlisKuru { get; set; }
        public decimal SatisKuru { get; set; }
        public int Adet { get; set; }
        private List<Doviz> _kurlar;
        public List<Doviz> Kurlar
        {
            get
            {
                _kurlar = new List<Doviz>();
                var kurlar = XElement.Load("http://www.tcmb.gov.tr/kurlar/today.xml");
                var kurlar2 = XElement.Load("http://realtime.paragaranti.com/asp/xml/icpiyasa.asp");
                var dovizler = (from k in kurlar.Elements()
                                where k.Element("CurrencyName") != null
                                select k).ToList();
                var dovizler2 = kurlar.Elements().Where(k => k.Element("CurrencyName") != null).ToList();
                try
                {
                    _kurlar.Add(new Doviz()
                    {
                        KurAdi = "Türk Lirası",
                        Adet = 1,
                        AlisKuru = 1,
                        SatisKuru = 1,
                        KurKodu = "TRY"
                    });
                    foreach (var item in dovizler)
                    {
                        _kurlar.Add(new Doviz()
                        {
                            KurAdi = item.Element("Isim").Value,
                            AlisKuru = Convert.ToDecimal(item.Element("ForexBuying").Value.Replace(".", ",")),
                            SatisKuru = Convert.ToDecimal(item.Element("ForexSelling").Value.Replace(".", ",")),
                            KurKodu = item.Attribute("Kod").Value,
                            Adet = int.Parse(item.Element("Unit").Value)
                        });
                    }
                }
                catch { }
                return _kurlar;
            }
        }
    }
}
