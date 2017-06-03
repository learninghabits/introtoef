using System.Web.Http;

namespace intro_to_ef.Controllers
{
    public class RootController : ApiController
    {
        // GET api/values
        public string Get()
        {
            return "API is ready to receive requests";
        }        
    }
}