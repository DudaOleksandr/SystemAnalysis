using System;

namespace DecoratorPattern
{
    static class Program
    {
        static void Main()
        {
            RepairPrice repairPrice = new TvServicePrice();
            repairPrice = new EngineRepair(repairPrice);
            Console.WriteLine(repairPrice.Description.Replace(" " , " + ") + " $" + repairPrice.Cost());

            RepairPrice repairPrice2 = new Refrigerator();
            repairPrice2 = new EngineRepair(repairPrice2);
            repairPrice2 = new BoardReplacement(repairPrice2);
            Console.WriteLine(repairPrice2.Description.Replace(" " , " + ") + " $" + repairPrice2.Cost());

            RepairPrice repairPrice3 = new WashingMachine();
            repairPrice3 = new EngineRepair(repairPrice3);
            repairPrice3 = new BoardReplacement(repairPrice3);
            Console.WriteLine(repairPrice3.Description.Replace(" " , " + ") + " $" + repairPrice3.Cost());
        }
    }
}
