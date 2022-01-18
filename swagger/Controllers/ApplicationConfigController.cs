using eProtokollCore.Dtos;
using eProtokollCore.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace swagger.Controllers
{
    public class ApplicationConfigController : ApiController
    {
        private readonly IInstitutionService _institutionService;
        private readonly IAppTypeService _appTypeService;
        public ApplicationConfigController(IInstitutionService institutionService, IAppTypeService appTypeService)
        {
            _institutionService = institutionService;
            _appTypeService = appTypeService;
        }

        [HttpPost]
        [Route(nameof(PostInstitution))]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> PostInstitution(InstitutionDto institutionDto)
        {
            var result = await _institutionService.AddInstitutionAsync(institutionDto);
            return Ok(result);
        }


        [HttpGet]
        [Route(nameof(GetInstitution))]
        public async Task<IActionResult> GetInstitution()
        {
            return Ok(await _institutionService.GetAllInstitutionAsync());
        }

        [HttpPost]
        [Route(nameof(PostType))]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PostType(TypeDto typeDto)
        {
            var result = await _appTypeService.AddAppTypeAsync(typeDto);
            return Ok(result);
        }
        [HttpGet]
        [Route(nameof(GetTypes))]
        public async Task<IActionResult> GetTypes()
        {
            return Ok(await _appTypeService.GetAllTypesAsync());
        }
        [HttpGet]
        [Route(nameof(GetStatuses))]
        public async Task<IActionResult> GetStatuses()
        {
            return Ok(await _appTypeService.GetAllTypesAsync());
        }
    }
}
