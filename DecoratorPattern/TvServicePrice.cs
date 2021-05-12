namespace DecoratorPattern
{
    class TvServicePrice : RepairPrice
    {
        public TvServicePrice()
        {
            _description = "Tv(Transportation)";
        }

        public override string Description => _description;

        public override double Cost()
        {
            return 1.99;
        }
    }
}
