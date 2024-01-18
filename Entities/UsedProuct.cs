namespace Product_NewImporterOrUsed.Entities
{
    sealed class UsedProuct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProuct() { }

        public UsedProuct(string name, double price, DateTime manufactureDate)
            : base (name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return "-" + Name + " (used), $" + Price.ToString("F2") + " (Manufacture date: " + ManufactureDate.ToString("dd/MM/yyyy") + ")";
        }
    }
}
