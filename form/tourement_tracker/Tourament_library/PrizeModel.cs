namespace tourement_tracker
{
    public class PrizeModel
    {
        public PrizeModel(String placeNumber, String placeName, String prizePercentage, String prizeAmount)
        {
            this.placeName = placeName;

            int placeNumberValue;
            int.TryParse(placeNumber, out placeNumberValue) ;
            this.placeNumber = placeNumberValue;

            double prizePercentageValue;
            double.TryParse(prizePercentage, out prizePercentageValue);

            this.prizePercentage =prizePercentageValue;

            decimal prizeAmountValue;
            decimal.TryParse(prizePercentage, out prizeAmountValue);
            this.prizeAmount = prizeAmountValue;
        }
        public PrizeModel()
        {

        }

        public int id { get; set; }
        public int placeNumber { get; set; }
        public String  placeName { get; set; }
        public double prizePercentage { get; set; }
        public Decimal prizeAmount { get; set; }
    }
}