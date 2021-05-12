namespace DecoratorPattern
{
    internal class Refrigerator : RepairPrice
    {
        public Refrigerator()
        {
            _description = "Refrigerator(Transportation)";
        }

        public override string Description => _description;

        public override double Cost()
        {
            return 3.49;
        }
    }
}