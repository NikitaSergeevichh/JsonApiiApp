using JSONApiApp.Service;

namespace JSONApiApp.Controlles
{
    public class ControllerConvertDistance
    {
        private ServiceConvertDistance convertDistance;

        public ControllerConvertDistance(ServiceConvertDistance convertDistance)
        {
            this.convertDistance = convertDistance;
        }        
        public async Task ConvertNumber(HttpContext context)
        {          
            

        }
    }
}
