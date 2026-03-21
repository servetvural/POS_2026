using System;

using POSLayer.Models;

namespace DTRMNS {

    public enum BonusTypes {NoTip, Half_Tip, Full_Tip }
    public class StaffIncome {
        public string IID { get { return employee?.IID??Guid.NewGuid().ToString(); } }
        public int hours { get; set; }  //entered by manager
        public Employee employee { get; set; }
        public string name { get { return employee?.EmployeeName??"??"; } }    //based on employee
        public double rate { get { return (double)(employee?.Rate??0); } }    //based on employee
        public double rateIncome { get { return rate * hours; } }  //calculated [hours * rate]
        public double xAmount { get; set; }
        public Bonus bonus { get; set; }

        public BonusTypes bonusType { get; set; } = BonusTypes.Full_Tip;   //entered by manager
        public double bonusIncome {

            get {
                try {
                    switch (bonusType) {
                        case BonusTypes.NoTip:
                            return 0;
                        case BonusTypes.Half_Tip:
                            return (double)(bonus.GetBonusStatus((float)xAmount).PreviousBarrierNumber * bonus.HalfStepValue);
                        case BonusTypes.Full_Tip:
                            return (double)(bonus.GetBonusStatus((float)xAmount).PreviousBarrierNumber * bonus.StepValue);
                        default:
                            return 0;
                    }
                } catch { return 0; }

            }
            
        } 

        public double tipIncome { get; set; }  //not calculated  //calculated    [hours * (hourlyTipRate)]
        public double shortAmount { get; set; }
        public bool shortApplicable { get; set; } = true;
        public double IncomeTotal { get { return rateIncome + bonusIncome + tipIncome - shortAmount; } } //calculated    [rateIncome + bonusIncome + tipIncome]

        public StaffIncome() {

        }
        public StaffIncome(double xAmount, Bonus bonus) {
            this.xAmount = xAmount;
            this.bonus = bonus;
        }

        public StaffIncome(int hours, Employee employee, double xAmount, Bonus bonus, BonusTypes bonusType) {
            this.hours = hours;
            this.employee = employee;
            this.xAmount = xAmount;
            this.bonus = bonus;
            this.bonusType = bonusType;        
        }
        public void Update(double xAmount, Bonus bonus) {
            this.xAmount = xAmount;
            this.bonus = bonus;
        }
    }
}
