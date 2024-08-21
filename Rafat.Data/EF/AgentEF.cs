using Rafat.Core;

namespace Rafat.Data.EF
{
    public class AgentEF : IDataHelper<Agent>
    {
        public DBContext db = new();
        public Agent agent = new();

        public List<Agent> GetAllData()
        {

            try
            {
                db = new DBContext();
                return db.Agents.OrderByDescending(x => x.AgentId).ToList();

            }
            catch
            {
                return new List<Agent>();

            }


        }

        public List<Agent> GetDataByUser(string userId)
        {
            try
            {
                db = new DBContext();
                return db.Agents.Where(x => x.UserId.ToString() == userId).OrderByDescending(x => x.AgentId)
                    .ToList();
            }
            catch
            {
                return new List<Agent>();
            }
        }

        public List<Agent> SearchAll(string searchIteam)
        {
            try
            {
                return db.Agents.Where(x => x.AgentId.ToString() == searchIteam ||
                x.UserId.ToString() == searchIteam ||
                x.FullName.Contains(searchIteam) ||
                x.Phone.ToString().Contains(searchIteam)
                )
                    .OrderByDescending(x => x.AgentId).ToList();

            }
            catch
            {
                return new List<Agent>();
            }
        }

        public List<Agent> SearchByUser(string userId, string searchIteam)
        {
            try
            {
                return db.Agents.Where(x => x.UserId.ToString() == userId).Where(x => x.AgentId.ToString() == searchIteam ||
                    x.UserId.ToString() == searchIteam ||
                    x.UserId.ToString() == searchIteam ||
                    x.FullName.Contains(searchIteam) ||
                    x.Phone.ToString().Contains(searchIteam)
                        )
                        .OrderByDescending(x => x.AgentId).ToList();

            }
            catch
            {
                return new List<Agent>();
            }
        }

        public Agent Find(int id)
        {
            try
            {
                return db.Agents.Find(id) ?? new Agent();

            }
            catch
            {
                return new Agent();
            }
        }

        public string Add(Agent table)
        {
            try
            {
                db.Agents.Add(table);
                db.SaveChanges();
                return "1";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string Edit(Agent table)
        {
            try
            {
                db = new DBContext();
                db.Agents.Update(table);
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
                agent = Find(id);
                db.Agents.Remove(agent);
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
