namespace Product_NewImporterOrUsed.Entities
{
    sealed class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct(){}

        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice(double price, double custFee)
        {
            return price + custFee;
        }

        public override string PriceTag()
        {
            return "-" + Name + ", $" + TotalPrice(Price, CustomsFee).ToString("F2") + " (Customs fee: $" + CustomsFee.ToString("F2") + ")";
        }
    }
}
