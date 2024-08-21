using Rafat.Core;

namespace Rafat.Data.EF
{
    public class CustomerEF : IDataHelper<Customer>
    {
        public DBContext db = new();
        public Customer customer = new();

        public List<Customer> GetAllData()
        {

            try
            {
                db = new DBContext();
                return db.Customers.OrderByDescending(x => x.CustomerId).ToList();

            }
            catch
            {
                return new List<Customer>();

            }


        }

        public List<Customer> GetDataByUser(string userId)
        {
            try
            {
                db = new DBContext();
                return db.Customers.Where(x => x.UserId.ToString() == userId).OrderByDescending(x => x.CustomerId)
                    .ToList();
            }
            catch
            {
                return new List<Customer>();
            }
        }

        public List<Customer> SearchAll(string searchIteam)
        {
            try
            {
                return db.Customers.Where(x => x.CustomerId.ToString() == searchIteam ||
                x.UserId.ToString() == searchIteam ||
                x.FullName.Contains(searchIteam) ||
                x.Phone.ToString().Contains(searchIteam)
                )
                    .OrderByDescending(x => x.CustomerId).ToList();

            }
            catch
            {
                return new List<Customer>();
            }
        }

        public List<Customer> SearchByUser(string userId, string searchIteam)
        {
            try
            {
                return db.Customers.Where(x => x.UserId.ToString() == userId).Where(x => x.CustomerId.ToString() == searchIteam ||
                    x.UserId.ToString() == searchIteam ||
                    x.UserId.ToString() == searchIteam ||
                    x.FullName.Contains(searchIteam) ||
                    x.Phone.ToString().Contains(searchIteam)
                        )
                        .OrderByDescending(x => x.CustomerId).ToList();

            }
            catch
            {
                return new List<Customer>();
            }
        }

        public Customer Find(int id)
        {
            try
            {
                return db.Customers.Find(id) ?? new Customer();

            }
            catch
            {
                return new Customer();
            }
        }

        public string Add(Customer table)
        {
            try
            {
                db.Customers.Add(table);
                db.SaveChanges();
                return "1";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string Edit(Customer table)
        {
            try
            {
                db = new DBContext();
                db.Customers.Update(table);
                db.SaveChanges();
                return "1";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string Delete(int id)
        {
            try
            {
                db = new DBContext();
                customer = Find(id);
                db.Customers.Remove(customer);
                db.SaveChanges();
                return "1";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public bool IsCanConnect()
        {
            db = new DBContext(); return db.Database.CanConnect();
        }
    }
}
