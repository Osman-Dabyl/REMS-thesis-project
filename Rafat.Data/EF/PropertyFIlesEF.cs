using Rafat.Core;

namespace Rafat.Data.EF
{
    public class PropertyFilesEF : IDataHelper<PropertyFile>
    {
        public DBContext db = new();
        public PropertyFile propertyFile = new();

        public List<PropertyFile> GetAllData()
        {

            try
            {
                db = new DBContext();
                return db.PropertyFiles.ToList();

            }
            catch
            {
                return new List<PropertyFile>();

            }


        }

        public List<PropertyFile> GetDataByUser(string userId)
        {
                return new List<PropertyFile>();
            
        }

        public List<PropertyFile> SearchAll(string searchIteam)
        {
         
            
            
                return new List<PropertyFile>();
            
        }

        public List<PropertyFile> SearchByUser(string userId, string searchIteam)
        {
            return new List<PropertyFile>();

        }

        public PropertyFile Find(int id)
        {
            try
            {
                return db.PropertyFiles.Find(id) ?? new PropertyFile();

            }
            catch
            {
                return new PropertyFile();
            }
        }

        public string Add(PropertyFile table)
        {
            try
            {
                db.PropertyFiles.Add(table);
                db.SaveChanges();
                return "1";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string Edit(PropertyFile table)
        {
            try
            {
                db = new DBContext();
                db.PropertyFiles.Update(table);
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
                propertyFile = Find(id);
                db.PropertyFiles.Remove(propertyFile);
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
