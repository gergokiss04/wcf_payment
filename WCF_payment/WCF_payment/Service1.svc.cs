using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF_payment
{

    public class Service1 : IService1
    {
       static List<customers> customers = new List<customers>();

        public void delCustomer(string id)
        {
            int identity = 0;
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].Id == int.Parse(id))
                {
                    identity = i;
                }
            }

            customers.RemoveAt(identity);

        }

        public List<customers> getcustomer()
        {
            
            return customers;
            /*
          customers c=new customers();
            c.Id = 1;
            c.Name = "customer1";
            c.city = "city1";

            customers.Add(c);

            customers c2 = new customers();
            c2.Id = 2;
            c2.Name = "customer2";
            c2.city = "city2";

            customers.Add(c2);

            return customers;
            */
        }

        public void pocustomer(customers customer)
        {
            customers.Add(customer);
        }

        public List<customers> postCustomer(string id, string name, string city)
        {
            customers c3 = new customers();
            c3.Id=int.Parse(id);
            c3.Name = name;
            c3.city=city;

            customers.Add(c3);

            return customers;
        }

        public void putcustomer(string id, string name, string city)
        {
            int identity = 0;
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].Id == int.Parse(id))
                {
                    identity = i;
                }
            }

            customers[identity].Name = name;
            customers[identity].city=city;


        }
    }
}
