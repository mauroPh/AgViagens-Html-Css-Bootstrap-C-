using AgenciaDeViagens.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AgenciaDeViagens.Controllers
{
    public class PacoteController : Controller
    {
        private readonly IPacoteRepository _pacoteRepository;

        public PacoteController(IPacoteRepository pacoteRepository)
        {
            _pacoteRepository = pacoteRepository;
        }

        public IActionResult List()
        {
            var pacotes = _pacoteRepository.Pacotes;

            return View(pacotes);
        }
    }
}
