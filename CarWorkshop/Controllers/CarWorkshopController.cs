using CarWorkshop.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace CarWorkshop.Controllers {
    //[Route("api/[controller]")]
    //[ApiController]
    public class CarWorkshopController : Controller
    {
        private readonly ICarWorkshopService _carWorkshopService;

        public CarWorkshopController(ICarWorkshopService carWorkshopService)
        {
            _carWorkshopService = carWorkshopService;
        }

        public IActionResult Create() 
        {
            return View();
        }


        [HttpPost]
        public async Task <IActionResult> Create(Domain.Entities.CarWorkshop carWorkshop) 
        {
            await _carWorkshopService.Create(carWorkshop);
            return RedirectToAction(nameof(Create)); // todo refactor

        }
    }
}
