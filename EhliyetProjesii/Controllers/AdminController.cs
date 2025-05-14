using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EhliyetProjesii.Controllers
{
    public class AdminController : Controller
    {
        private readonly IYorumlarService _yorumlarService;
        private readonly IRandevuService _randevuService;
        private readonly IÖzelliklerService _özelliklerService;
        private readonly IKursService _kursService;
        private readonly IHizmetService _hizmetService;
        private readonly IHakkımızdaService _hakkımızdaService;
        private readonly IÇalışanService _çalışanService;
        private IAnasayfaService _anasayfaService;
        public AdminController(IRandevuService randevuService, IYorumlarService yorumlarService, IÖzelliklerService özelliklerService, IKursService kursService, IHizmetService hizmetService, IHakkımızdaService hakkımızdaService, IÇalışanService çalışanService, IAnasayfaService anasayfaService)
        {
            _randevuService = randevuService;
            _yorumlarService = yorumlarService;
            _özelliklerService = özelliklerService;
            _kursService = kursService;
            _hizmetService = hizmetService;
            _hakkımızdaService = hakkımızdaService;
            _çalışanService = çalışanService;
            _anasayfaService = anasayfaService;
        }

        public IActionResult YorumlarList()
        {
            var yorumlarlist = _yorumlarService.TGetList();
            return View(yorumlarlist);
        }

        public IActionResult RandevuList()
        {
            var randevulist = _randevuService.TGetList();
            return View(randevulist);
        }

        public IActionResult ÖzellilerList()
        {
            var özelliklerlist = _özelliklerService.TGetList();
            return View(özelliklerlist);
          

        }

        public IActionResult KursList()
        {
            var kursList = _kursService.TGetList();
            return View(kursList);
        }

        public IActionResult Hizmet()
        {
            var hizmetlist = _hizmetService.TGetList();
            return View(hizmetlist);
        }

        public IActionResult Hakkımızda()
        {
            var hakkımızdaList = _hakkımızdaService.TGetList();
            return View(hakkımızdaList);
        }

        public IActionResult Çalışan()
        {
            var çalışanList = _çalışanService.TGetList();
            return View(çalışanList);
        }

        public IActionResult Anasayfa()
        {
            var anasayfaList = _anasayfaService.TGetList();
            return View(anasayfaList);
        }

        
    }
}
