using GymMnagment.DAL.Data.Models;
using GymMnagment.DAL.Repositorities.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GymMangment.PL.Controllers
{
    public class PlanController : Controller
    {
        private readonly IGenericRepository<Plan> genericRepository;
        public PlanController(IGenericRepository<Plan> repository)
        {
            genericRepository = repository;
        }
        public async Task<IActionResult> Index()
        {
            var data = await genericRepository.GetAllAsync();
            return View(data);
        }
        public async Task<IActionResult> Details(int id)
        {
            var plan = await genericRepository.GetByIdAsync(id);
            if (plan == null)
            {
                return NotFound();
            }
            return View(plan);
        }
    }
}
