using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoFinalSalesWebMvc.Models.Enums;

namespace ProjetoFinalSalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } 
        public double Amount { get; set; }
        public int MyProperty { get; set; }
        public SalesStaus Staus { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {

        }

        public SalesRecord(int id, DateTime date, double amount, int myProperty, SalesStaus staus, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            MyProperty = myProperty;
            Staus = staus;
            Seller = seller;
        }
    }
}
