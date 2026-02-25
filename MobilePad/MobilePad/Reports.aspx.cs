using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Configuration;
using System.Data;
using DTRMNS;


namespace MobilePad
{
    public partial class Reports : System.Web.UI.Page
    {
        protected DTRMSimpleBusiness dtrm;

        protected void Page_Load(object sender, EventArgs e)
        {
            dtrm = (DTRMSimpleBusiness)Session["DTRM"];
            LoadReport();
        }

        private void LoadReport()
        {

            //DataTable dtUserSales = dtrm.db.GetDataTable("Select Total from Usersales Where SessionIID ='" + dtrm.GetCurrentSessionIID() + "' and UserName ='" + dtrm.LoggedUser.UserName +"'");

            DataTable dtUserSales = dtrm.db.GetDataTable("Select count(IID) as NumberOfOrders, Sum(CalculatedValue) as Total from OrdersView where UserName='" + dtrm.LoggedUser.UserName + "' and SessionIID = '" + dtrm.GetCurrentSessionIID() + "'");
            int NumberOfOrders = int.Parse(dtUserSales.Rows[0]["NumberOfOrders"].ToString());
            float UserTotal = float.Parse(dtUserSales.Rows[0]["Total"].ToString());

            SessionData currSession = dtrm.GetCurrentSession();


            lblUserName.Text = dtrm.LoggedUser.UserName;
            lblNumberOfOrders.Text = NumberOfOrders.ToString();
            lblOrderTotal.Text = UserTotal.ToString("c2");
            lblSessionTotal.Text = currSession.GrossSessionTotal.ToString("c2");
            lblPercentage.Text = (UserTotal * 100 / currSession.GrossSessionTotal).ToString("n0") + " %";


            //float Solva_Productivity_Ratio = float.Parse(ConfigurationManager.AppSettings["Solva_Productivity_Ratio"].ToString());

            ////PeopleCountInformation pci = new PeopleCountInformation(dtrm.db, currSession.SessionStartDateTime, DateTime.Now, 0, 0);
            ////if (pci.InCount == 0)
            ////    lblTeamProductivity.Text = (currSession.GrossSessionTotal * Solva_Productivity_Ratio).ToString("n2");
            ////else
            ////    lblTeamProductivity.Text = (currSession.GrossSessionTotal / pci.InCount * Solva_Productivity_Ratio).ToString("n2");

            ////if (pci.InCount == 0)
            ////    lblPersonalProductivity.Text = (UserTotal * Solva_Productivity_Ratio).ToString("n2");
            ////else
            ////    lblPersonalProductivity.Text = (UserTotal / pci.InCount * Solva_Productivity_Ratio).ToString("n2");

            ////lblPeopleCameIn.Text = pci.InCount.ToString();


        }
    }
}