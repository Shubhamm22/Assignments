using System;
using System.Collections.Generic;
using System.Text;

namespace RiskCalculator
{
    class TDSDataModel
    {
        private string tradeid;
        private string date;
        private string currenttradevalue;
        private string counterpartyid;
        public string gettradeid() { return this.tradeid; }
        public string getdate() { return this.date; }
        public string getcurrenttradevalue() { return this.currenttradevalue; }
        public string getcounterpartyid() { return this.counterpartyid; }
        public void settradeid(string value) { this.tradeid = value; }
        public void setdate(string value) { this.date = value; }
        public void setcurrenttradevalue(string value) { this.currenttradevalue = value; }
        public void setcounterpartyid(string value) { this.counterpartyid = value; }


    }
}
