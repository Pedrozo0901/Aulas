using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_25_exercicio
{
    public class Orderitem
    {
        public int Quantity { get; set; }
        public double Price  { get; set; }
    }

    public Orderitem(int quantity, double price)
    {
        Quality = quantity;
        Price = price;
    }

    public double subTotal()
    {
        
    }
}