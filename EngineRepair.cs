namespace DecoratorPattern
{
    class EngineRepair : CondimentDecorator
    {
        readonly RepairPrice _repairPrice;

        public EngineRepair(RepairPrice repairPrice)
        {
            _repairPrice = repairPrice;
        }

        public override string Description
        {
            get
            {
                if (_repairPrice.Description.StartsWith("Engine"))
                {
                    return "Double " + _repairPrice.Description;
                }
                if(_repairPrice.Description.Contains("Tv"))
                    return _repairPrice.Description;
                return "Engine(Replacement) " + _repairPrice.Description;
            }
        }

        public override double Cost()
        {
            if(_repairPrice.Description.Contains("WashingMachine "))
                return 4 + _repairPrice.Cost();
            if(_repairPrice.Description.Contains("Refrigerator"))
                return 3.01 + _repairPrice.Cost();
            return _repairPrice.Cost();
        }
    }
}
