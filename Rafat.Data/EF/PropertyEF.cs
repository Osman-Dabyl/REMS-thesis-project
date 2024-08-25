using Rafat.Core;

namespace Rafat.Data.EF
{
    public class PropertyEF : IDataHelper<Property>
    {
        public DBContext db;
        public Property property;

        public PropertyEF()
        {

            db = new DBContext();
            property = new Property();

        }

        public List<Property> GetAllData()
        {

            try
            {
                db = new DBContext();
                return db.Properties.OrderByDescending(x => x.PropertyId).ToList();

            }
            catch 
            {
                return new List<Property>();

            }


        }

        public List<Property> GetDataByUser(string userId)
        {
            try
            {
                db = new DBContext();
                return db.Properties.Where(x => x.UserId.ToString() == userId).OrderByDescending(x => x.PropertyId)
                    .ToList();
            }
            catch 
            {
                return new List<Property>();
            }
        }

        public List<Property> SearchAll(string searchIteam)
        {
            try
            {
                return db.Properties

                    .Where(
                    x => x.Listing.ToString() == searchIteam
                   
                    ).ToList();

            }
            catch 
            {
                return new List<Property>();
            }
        }

        public List<Property> SearchByUser(string userId, string searchIteam)
        {
            try
            {
                return db.Properties.Where(x => x.UserId.ToString() == userId).Where(x => x.PropertyId.ToString() == searchIteam ||
                    x.UserId.ToString() == searchIteam ||
                    x.Agent.FullName.Contains(searchIteam) ||
                    x.Price.ToString().Contains(searchIteam) ||
                    x.PType.ToString() == searchIteam ||
                    x.Status.ToString() == searchIteam ||
                    x.Listing.ToString() == searchIteam
                    )
                    .OrderByDescending(x => x.PropertyId).ToList();

            }
            catch
            {
                return new List<Property>();
            }
        }

        public Property Find(int id)
        {
            try
            {
                return db.Properties.Find(id) ?? new Property();

            }
            catch 
            {
                return new Property();
            }
        }

        public string Add(Property table)
        {
            try
            {
                 db.Properties.Add(table);
                 db.SaveChanges();
                 return "1";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string Edit(Property table)
        {
            try
            {
       
                db.Properties.Update(table);
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
                property = Find(id);
                db.Properties.Remove(property);
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
