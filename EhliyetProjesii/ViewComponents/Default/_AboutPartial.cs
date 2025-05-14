using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EhliyetProjesii.ViewComponents.Default
{
    public class _AboutPartial:ViewComponent
    {
      

        private readonly IHakkımızdaService _hakkımızdaService;

        public _AboutPartial(IHakkımızdaService hakkımızdaService)
        {
            _hakkımızdaService = hakkımızdaService;
        }

        public IViewComponentResult Invoke()
        {
            var list = _hakkımızdaService.TGetList();
            return View(list);
        }
    }
}
