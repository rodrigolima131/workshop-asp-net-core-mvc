using SalesWebMvc.Models.Enums;
using System;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double amount { get; set; }
        public double BaseSalary { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, double baseSalary, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            this.amount = amount;
            BaseSalary = baseSalary;
            Status = status;
            Seller = seller;
        }
    }

   

}
