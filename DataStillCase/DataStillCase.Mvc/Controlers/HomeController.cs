using DataStillCase.Core.Service.Models.Tables;
using Microsoft.AspNetCore.Mvc;


namespace DataStillCase.Mvc.Controlers
{
    public class HomeController : Controller
    {
        private readonly ICityService _cityService;
        private readonly IInformationService _informationService;
        private readonly IVisitorHistoryService _visitorHistoryService;
        public HomeController(
            ICityService cityService,
            IInformationService informationService,
            IVisitorHistoryService visitorHistoryService)
        {
            _cityService = cityService;
            _informationService = informationService;
            _visitorHistoryService = visitorHistoryService;
        }

        public async Task<IActionResult> Index()
        {
            var results = await _cityService.GetAllAsync();
            return View(results);
        }

        [HttpGet]
        [Route("GetCityDetail/{cityId}")]
        public async Task<IActionResult> GetCityDetail(int cityId)
        {
            var result = await _cityService.GetWithDetailAsync(cityId); 
            return Ok(result);
        }
    }
}
