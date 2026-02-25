using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace DTRMNS {

    [System.Serializable]
    public class PriceItem
    {
        private string _IID=Guid.NewGuid().ToString();
        public string IID { get { return _IID; } set { _IID = value; } } 
        private float _dsp = 0f;
        private float _hp = 0f;
        private float _tap = 0f;
        private float _dp = 0f;
        public string PEBIID = "";

        //Properties
        public float DirectSalePrice { get { return _dsp; } set { _dsp = value; } }
        public float InHousePrice { get { return _hp; } set { _hp = value; } }
        public float TakeAwayPrice { get { return _tap; } set { _tap = value; } }
        public float DeliveryPrice { get { return _dp; } set { _dp = value; } }

        //Constructors
        public PriceItem()
        {

            DirectSalePrice = 0f;
            InHousePrice = 0f;
            TakeAwayPrice = 0f;
            DeliveryPrice = 0f;
            PEBIID = "";
        }
        public PriceItem(DataRow dr)
        {
            if (dr != null)
            {
                this.IID = dr["IID"].ToString();
                this.DirectSalePrice = float.Parse(dr["DirectSalePrice"].ToString());
                this.InHousePrice = float.Parse(dr["InHousePrice"].ToString());
                this.TakeAwayPrice = float.Parse(dr["TakeAwayPrice"].ToString());
                this.DeliveryPrice = float.Parse(dr["DeliveryPrice"].ToString());
                this.PEBIID = dr["ParentEntityButtonIID"].ToString();
            }
        }
        public PriceItem(float DirectSalePrice, float InHousePrice, float TakeAwayPrice, float DeliveryPrice, string PEBIID)
        {

            this.DirectSalePrice = DirectSalePrice;
            this.InHousePrice = InHousePrice;
            this.TakeAwayPrice = TakeAwayPrice;
            this.DeliveryPrice = DeliveryPrice;
            this.PEBIID = PEBIID;
        }
        public PriceItem Clone()
        {
            PriceItem pi = new PriceItem(this.DirectSalePrice, this.InHousePrice, this.TakeAwayPrice, this.DeliveryPrice, this.PEBIID);
            pi.IID = this.IID;
            return pi;
        }
        public PriceItem Duplicate()
        {
            return new PriceItem(this.DirectSalePrice, this.InHousePrice, this.TakeAwayPrice, this.DeliveryPrice, this.PEBIID);
        }
    }

}
