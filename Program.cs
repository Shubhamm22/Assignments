using System;

namespace RiskCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            TDSDataModel reference = new TDSDataModel();
            reference.settradeid("01");
            reference.setdate("01-01-2021");
            reference.setcurrenttradevalue("2000");
            reference.setcounterpartyid("101");
            string tradeid = reference.gettradeid();
            System.Console.WriteLine("Trade ID:" + tradeid);
            string date = reference.getdate();
            System.Console.WriteLine("Date:" + date);
            string currenttradevalue = reference.getcurrenttradevalue();
            System.Console.WriteLine("Current Trade Value:" + currenttradevalue);
            string counterpartyid = reference.getcounterpartyid();
            System.Console.WriteLine("Counter Party ID:" + counterpartyid);

            RDSDataModel reference1 = new RDSDataModel();
            reference1.setcounterpartyid1("51");
            reference1.setname("SBI");
            string counterpartyid1 = reference1.getcounterpartyid1();
            System.Console.WriteLine("couterpartyid :" + counterpartyid1);
            string name = reference1.getname();
            System.Console.WriteLine("Name:" + name);


            //RiskInputdatamerger merging = new RiskInputdatamerger();
            //merging.merge();
            
        }
    }
}
