namespace DecoratorPattern
{
    class WashingMachine : RepairPrice
    {
        public WashingMachine()
        {
            _description = "WashingMachine(Transportation)";
        }

        public override string Description => _description;

        public override double Cost()
        {
            return 4.49;
        }
    }
}
