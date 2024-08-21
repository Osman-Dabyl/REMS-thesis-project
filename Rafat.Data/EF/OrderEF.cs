using Rafat.Core;

namespace Rafat.Data.EF
{
    public class OrderEF : IDataHelper<Order>
    {
        public DBContext db = new();
        public Order order = new();

        public List<Order> GetAllData()
        {

            try
            {
                db = new DBContext();
                return db.Orders.OrderByDescending(x => x.OrderId).ToList();

            }
            catch
            {
                return new List<Order>();

            }


        }

        public List<Order> GetDataByUser(string userId)
        {
            try
            {
                db = new DBContext();
                return db.Orders.Where(x => x.UserId.ToString() == userId).OrderByDescending(x => x.OrderId)
                    .ToList();
            }
            catch
            {
                return new List<Order>();
            }
        }

        public List<Order> SearchAll(string searchIteam)
        {
            try
            {
                return db.Orders.Where(x => x.OrderId.ToString() == searchIteam ||
                x.UserId.ToString() == searchIteam ||
                x.OrderDate.ToString().Contains(searchIteam) ||
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                x.SalePrice.ToString().Contains(searchIteam) ||
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                x.Ordertype.ToString() == searchIteam ||
                x.Status.ToString() == searchIteam ||
                x.Status.ToString() == searchIteam
                )
                    .OrderByDescending(x => x.OrderId).ToList();

            }
            catch
            {
                return new List<Order>();
            }
        }

        public List<Order> SearchByUser(string userId, string searchIteam)
        {
            try
            {
                return db.Orders.Where(x => x.UserId.ToString() == userId).Where(x => x.OrderId.ToString() == searchIteam ||
                    x.UserId.ToString() == searchIteam ||
                    // ReSharper disable once SpecifyACultureInStringConversionExplicitly
                    x.OrderDate.ToString().Contains(searchIteam) ||
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    x.SalePrice.ToString().Contains(searchIteam) ||
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                    x.Ordertype.ToString() == searchIteam ||
                    x.Status.ToString() == searchIteam ||
                    x.Status.ToString() == searchIteam
                    )
                    .OrderByDescending(x => x.OrderId).ToList();

            }
            catch
            {
                return new List<Order>();
            }
        }

        public Order Find(int id)
        {
            try
            {
                return db.Orders.Find(id) ?? new Order();

            }
            catch
            {
                return new Order();
            }
        }

        public string Add(Order table)
        {
            try
            {
                db.Orders.Add(table);
                db.SaveChanges();
                return "1";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string Edit(Order table)
        {
            try
            {
                db = new DBContext();
                db.Orders.Update(table);
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
                order = Find(id);
                db.Orders.Remove(order);
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
