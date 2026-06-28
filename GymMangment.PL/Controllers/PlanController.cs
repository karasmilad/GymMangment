using GymMnagment.DAL.Repositorities.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GymMangment.PL.Controllers
{
    public class PlanController : Controller
    {
        private readonly IPlanRepository planRepository;
        public PlanController(IPlanRepository repository)
        {
            this.planRepository = repository;
        }
        public async Task<IActionResult> Index()
        {
            var data = await planRepository.GetAllAsync();
            return View(data);
        }
    }
}
