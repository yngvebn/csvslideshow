using System.Threading.Tasks;
using System.Web.Http;
using FireSharp.Response;

namespace WebApplication1.Api.Projects
{
    [RoutePrefix("api/projects")]
    public class ProjectsController: ApiController
    {
        public ProjectsController()
        {
            
        }

        [Route(""), HttpGet]
        public IHttpActionResult Get()
        {
            return Ok("Hello");
        }

        [Route(""), HttpPost]
        public async Task<IHttpActionResult> Create(CreateProjectRequest request)
        {
            SetResponse response = await Db.Client.SetAsync("projects/yngvebn", request);
            CreateProjectRequest result = response.ResultAs<CreateProjectRequest>(); //The response will contain the data written
            return Ok(result);
        }
    }

    public class CreateProjectRequest
    {
        public string Name { get; set; }
    }
}