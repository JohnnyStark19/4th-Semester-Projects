using System.ComponentModel.DataAnnotations;

namespace OrderForm.Models
{
    public class orderForm
    {

        const string INVALID = "Invalid Discount Code";
        const string THIRTY  = "30% Discount Applied";
        const string TWENTY  = "20% Discount Applied";
        const string TEN     = "10% Discount Applied";


        const double TAX = 0.08;
        const double PricePerShirt = 15;

        [Required(ErrorMessage = "Please Enter A Quantity")]
        [Range(1,1000, ErrorMessage = "Quantity Must Be Between 1 and 1000")]

        public double? Quantity { get; set; }

        public double? DiscountCode { get; set; }

        public double ReturnQuantity()
        {
            if (Quantity.HasValue)
            {
                return Quantity.Value;
            }
            else
            {
                return 0;
            }
        }

        public double CalculatePricePerShirt()
        {
            if(DiscountCode == 6175)
            {
                double sub = PricePerShirt * 0.3;
                double tot = PricePerShirt - sub;
                return tot;
            }
            else if(DiscountCode == 1390)
            {
                double sub = PricePerShirt * 0.2;
                double tot = PricePerShirt - sub;
                return tot;

            }
            else if (DiscountCode == 0088)
            {
                double sub = PricePerShirt * 0.1;
                double tot = PricePerShirt - sub;
                return tot;

            }
            else
            {
                return PricePerShirt;
            }
        }

        public double CalculateTax()
        {
            if(Quantity.HasValue)
            {
                double tax = CalculateSubtotal() * TAX;
                return tax;
            }
            else
            {
                return 0;
            }
        }

        public double CalculateTotal()
        {
            if(Quantity.HasValue)
            {
                double grandTot = CalculateSubtotal() + CalculateTax();
                return grandTot;
            }
            else
            {
                return 0;
            }
        }

        public double CalculateSubtotal()
        {
            if(Quantity.HasValue)
            {
                return CalculatePricePerShirt() * Quantity.Value;
            }
            else
            {
                return 0;
            }
        }

        public string DiscountMessages()
        {
            if (DiscountCode == 6175)
            {
                return THIRTY;
            }
            else if (DiscountCode == 1390)
            {
                return TWENTY;

            }
            else if (DiscountCode == 0088)
            {
                return TEN;

            }
            else
            {
                return INVALID;
            }
        }

    }
}
