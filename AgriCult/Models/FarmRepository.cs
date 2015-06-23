using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgriCult.Models
{
    public class FarmRepository
    {
        public void Update(int id, string name, string Comment)
        {
            Customer customer = null;

            using (FarmsDataContext db =
                        new FarmsDataContext())
            {
                var query = from c in db.Customers
                            where c.CustomerID == id
                            select c;

                customer = query.SingleOrDefault<Customer>();

                customer.Name = name;
                customer.Comment = Comment;

                db.SubmitChanges();
            }
        }

        public int Add(string name, string Comment)
        {
            Customer customer = null;

            using (FarmsDataContext db =
                        new FarmsDataContext())
            {
                customer = new Customer();
                customer.Name = name;
                customer.Comment = Comment;
                db.Customers.InsertOnSubmit(customer);
                db.SubmitChanges();
            }

            int id = customer.CustomerID;

            return id;
        }
    }
}