
namespace DTRMNS {
    public class TaxSummary {
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public float TaxPercent { get; set; }
        public float TotalNoTax { get; set; }
        public float NetTaxValue { get; set; }
        public float GrossTotal { get; set; }
        public int Payment { get; set; }

        public TaxSummary() {

        }
    }
}
