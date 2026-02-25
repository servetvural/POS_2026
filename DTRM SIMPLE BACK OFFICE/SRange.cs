using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTRMSimpleBackOffice
{
    public class SRange
    {
        public int ItemGap { get; set; } = 2;
        public float Secilen { get; set; } = 0.0f;

        public float NakitSonuc { get; set; } = 0.0f;
        public float TotalSonuc { get; set; }    = 0.0f;
        public int Adet { get; set; }

        public string DisplayValue { get
            {


                return $"{ItemGap,2:N0} {Secilen,10:N2} {NakitSonuc,10:N2} {TotalSonuc,10:N2} {Adet,3:N0}";
            }
        }
    }
}
