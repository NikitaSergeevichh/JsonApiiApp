using JSONApiApp.Model;
using JSONApiApp.Model.Entity;

namespace JSONApiApp.Service
{
    public class ServiceKnowHost
    {       
        public List<KnowHost> GetKnowHost()
        {
            using (var db = new JsonApiDbContext())
            {
                return db.KnowHosts.ToList();
            }
        }
        public KnowHost AddKnowHost(KnowHost host)
        {
            using (var db = new JsonApiDbContext())
            {
                db.KnowHosts.Add(host);
                db.SaveChanges();
                return host;
            }
        }     
        public KnowHost UpdateKnowHost(int id, string info)
        {
            using (var db = new JsonApiDbContext())
            {
                KnowHost updateHost = db.KnowHosts.FirstOrDefault(h => h.Id == id);
                updateHost.Info = info;
                db.SaveChanges();
                return updateHost;
            }
        }        
        public KnowHost DeleteKnowHost(int id)
        {
            using (var db = new JsonApiDbContext())
            {
                KnowHost deleteHost = db.KnowHosts.FirstOrDefault(h => h.Id == id);
                db.KnowHosts.Remove(deleteHost);
                db.SaveChanges();
                return deleteHost;
            }
        }
    }
}
