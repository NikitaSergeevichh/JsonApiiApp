using JSONApiApp.Model.Entity;
using JSONApiApp.Model;

namespace JSONApiApp.Service
{
    public class ServiceMyRequest
    {        
        public List<MyRequest> GetMyRequest()
        {
            using (var db = new JsonApiDbContext())
            {
                return db.MyRequests.ToList();
            }
        }       
        public MyRequest AddKnowHost(MyRequest request)
        {
            using (var db = new JsonApiDbContext())
            {
                db.MyRequests.Add(request);
                db.SaveChanges();
                return request;
            }
        }        
        public MyRequest UpdateMyRequest(int id, string info)
        {
            using (var db = new JsonApiDbContext())
            {
                MyRequest updateRequest = db.MyRequests.FirstOrDefault(h => h.Id == id);
                updateRequest.info = info;
                db.SaveChanges();
                return updateRequest;
            }
        }        
        public MyRequest DeleteMyRequest(int id)
        {
            using (var db = new JsonApiDbContext())
            {
                MyRequest deleteRequest = db.MyRequests.FirstOrDefault(h => h.Id == id);
                db.MyRequests.Remove(deleteRequest);
                db.SaveChanges();
                return deleteRequest;
            }
        }
    }
}