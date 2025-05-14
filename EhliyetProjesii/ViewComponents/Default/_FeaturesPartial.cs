using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EhliyetProjesii.ViewComponents.Default
{
    public class _FeaturesPartial:ViewComponent
    {
        private readonly IÖzelliklerService _özelliklerService;

        public _FeaturesPartial(IÖzelliklerService özelliklerService)
        {
            _özelliklerService = özelliklerService;
        }

        public IViewComponentResult Invoke()
        {
            var List = _özelliklerService.TGetList();
            return View(List);
        }
    }
}
