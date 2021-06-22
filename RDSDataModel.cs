using System;
using System.Collections.Generic;
using System.Text;

namespace RiskCalculator
{
    class RDSDataModel
    {
        private string counterpartyid1;
        private string name;
        public string getcounterpartyid1() { return this.counterpartyid1; }
        public string getname() { return this.name; }
        public void setcounterpartyid1(string value) { this.counterpartyid1 = value; }
        public void setname(string value) { this.name = value; }

    }
}
