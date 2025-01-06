using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_25_exercicio
{
    public class Order
    {
        public Date Moment {get; set;}
        public OrderStatus Status {get; set;}

        public Order(Date moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }

        public void addItem(Orderitem item)
        {
            
        }

        public void removeItem(Orderitem ite)
        {

        }

        public double Total()
        {

        }
    }
}