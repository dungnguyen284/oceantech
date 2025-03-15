using BusinessLogicLayer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace OceanTech.API.Controllers
{
    [Route("api/province")]
    [ApiController]
    public class ProvinceController
    {
        private readonly IProvinceService _provinceService;
        public ProvinceController(IProvinceService provinceService)
        {
            _provinceService = provinceService;
        }
    }
}
