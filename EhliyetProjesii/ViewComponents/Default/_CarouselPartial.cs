using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EhliyetProjesii.ViewComponents.Default
{
    public class _CarouselPartial:ViewComponent
    {
        private readonly IAnasayfaService _anasayfaService;

        public _CarouselPartial(IAnasayfaService anasayfaService)
        {
            _anasayfaService = anasayfaService;
        }

        public IViewComponentResult Invoke()
        {
            var list = _anasayfaService.TGetList();
            return View(list);
        }
    }
}
