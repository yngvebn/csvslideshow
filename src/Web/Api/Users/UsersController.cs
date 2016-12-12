using System.Threading.Tasks;
using System.Web.Http;
using FireSharp.Response;

namespace WebApplication1.Api.Users
{
    [RoutePrefix("api/users")]
    public class UsersController: ApiController
    {
        [HttpPost, Route("")]
        public IHttpActionResult Create(CreateUserRequest request)
        {
            FirebaseResponse result =  Db.Client.CreateUser(request.Email, request.Password);
            return Ok(result);
        }
    }

    public class CreateUserRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}