using eProtokollCore.Dtos;
using eProtokollCore.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace swagger.Controllers
{
    public class ApplicationController : ApiController
    {
        private readonly IApplicationService _applicationService;
        public ApplicationController(IApplicationService application)
        {
            _applicationService = application;
        }
        [HttpPost]
        [Route(nameof(PostApp))]
        public async Task<IActionResult> PostApp(ApplicationDto dto)
        {
            //var _auth = Request.Headers["Authorization"];

            var result = await _applicationService.AddNewApplicationAsync(dto);
            return Ok(result);
        }

        [HttpGet]
        [Route(nameof(GetMyApplications))]
        public async Task<IActionResult> GetMyApplications(string token, bool isFinished)
        {
            if (Request != null)
            {
                var _auth = Request.Headers["Authorization"];
                auth_token = _auth.ToString().Substring(7, _auth.ToString().Length - 7);
            }

            var result = await _applicationService.GetApplicationsByUser(auth_token, isFinished);
            return Ok(result);
        }

        [HttpGet]
        [Route(nameof(GetMyFinishedApplications))]
        public async Task<IActionResult> GetMyFinishedApplications(string token, bool isFinished)
        {
            if (Request != null)
            {
                var _auth = Request.Headers["Authorization"];
                auth_token = _auth.ToString().Substring(7, _auth.ToString().Length - 7);
            }

            var result = await _applicationService.GetApplicationsByUser(auth_token, isFinished);
            return Ok(result);
        }
        [HttpGet]
        [Route(nameof(GetAllApplications))]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> GetAllApplications()
        {
            return Ok(await _applicationService.GetAllApplicationsAsync());
        }

        [HttpGet]
        [Route(nameof(GetApplicationDetails))]
        public async Task<IActionResult> GetApplicationDetails(int id)
        {
            return Ok(await _applicationService.GetApplicationDetailsAsync(id));
        }

        [HttpPost]
        [Route(nameof(RefuseApplication))]
        public async Task<IActionResult> RefuseApplication(UserApplicationsDto dto)
        {
            if (Request != null)
            {
                var _auth = Request.Headers["Authorization"];
                auth_token = _auth.ToString().Substring(7, _auth.ToString().Length - 7);
            }
            return Ok(await _applicationService.RefuseApplicationAsync(dto, auth_token));
        }
        [HttpPost]
        [Route(nameof(NextStep))]
        public async Task<IActionResult> NextStep(UserApplicationsDto dto)
        {
            if (Request != null)
            {
                var _auth = Request.Headers["Authorization"];
                auth_token = _auth.ToString().Substring(7, _auth.ToString().Length - 7);
            }
            return Ok(await _applicationService.PassInNextStepAsync(dto, auth_token));
        }

        [HttpGet]
        [Route(nameof(GetApplicationHistory))]
        public async Task<IActionResult> GetApplicationHistory(int appId)
        {
            return Ok(await _applicationService.GetApplicationHistoryAsync(appId));
        }
       
    }
}
