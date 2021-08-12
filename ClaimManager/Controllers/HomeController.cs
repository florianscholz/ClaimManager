using ClaimManager.DataLayer.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ClaimManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILossTypeRepository _lossTypeRepository;
        public HomeController(ILossTypeRepository lossTypeRepository)
        {
            _lossTypeRepository = lossTypeRepository;
        }
        
        // GET
        [Authorize]
        public IActionResult Index()
        {
            var lossList = _lossTypeRepository.GetLossTypes();

            return View("Index", lossList);
        }
    }
}