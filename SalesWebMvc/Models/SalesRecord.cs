using System;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SalesStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {

        }

        public SalesRecord(int idSales, DateTime date, double amount, SalesStatus status, Seller seller)
        {
            Id = idSales;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
