using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EhliyetProjesii.ViewComponents.Default
{
    public class _FactsPartial:ViewComponent
    {
        private readonly IHizmetService _hizmetService;

        public _FactsPartial(IHizmetService hizmetService)
        {
            _hizmetService = hizmetService;
        }

        public IViewComponentResult Invoke()
        {
            var list = _hizmetService.TGetList();
            return View(list);
        }
    }
}
