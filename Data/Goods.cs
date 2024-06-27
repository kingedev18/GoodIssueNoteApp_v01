using System.ComponentModel.DataAnnotations;

namespace GoodIssueNoteApp.Data
{
    public class Goods
    {
        [Key]
        public int GoodId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int QuantityInStock { get; set; }


        //public int Total
        //{
        //    get
        //    {
        //        return Quantity * UnitPrice;
        //    }
        //}

        //// Static field to keep track of total amount across all invoices
        //private static int totalAmount;

        //// Static property to access the total amount
        //public static int TotalAmount
        //{
        //    get { return totalAmount; }
        //}

        //// Constructor to update the total amount upon instantiation
        //public Goods()
        //{
        //    totalAmount += Total;
        //}



    }

    
}
