

using System.Web.Http;

namespace MedicalAppointment.Api.Controllers.Pacientes
{
    [Route("api/[controller]")]
    public class PacientesController : ApiController
    {
        [HttpGet]
        public async Task<IHttpActionResult> GetProfesional()
        {
            return Ok();
        }
    }
}
