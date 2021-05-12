namespace DecoratorPattern
{
    class BoardReplacement : CondimentDecorator
    {
        readonly RepairPrice _repairPrice;

        public BoardReplacement(RepairPrice repairPrice)
        {
            _repairPrice = repairPrice;
        }

        public override string Description
        {
            get
            {
                if (_repairPrice.Description.StartsWith("Board"))
                {
                    return "Double " + _repairPrice.Description;
                }
                else
                    return "Board(Replacement) " + _repairPrice.Description;
            }
        }

        public override double Cost()
        {
            if(_repairPrice.Description.Contains("WashingMachine"))
                return 2.7 + _repairPrice.Cost();
            if(_repairPrice.Description.Contains("Refrigerator "))
                return 3.01 + _repairPrice.Cost();
            if(_repairPrice.Description.Contains("Tv"))
                return 5.43 + _repairPrice.Cost();
            return _repairPrice.Cost();
        }
    }
}
