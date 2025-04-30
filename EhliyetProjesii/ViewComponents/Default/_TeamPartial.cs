using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EhliyetProjesii.ViewComponents.Default
{
    public class _TeamPartial:ViewComponent
    {
        private readonly IÇalışanService _çalışanService;

        public _TeamPartial(IÇalışanService çalışanService)
        {
            _çalışanService = çalışanService;
        }

        public IViewComponentResult Invoke()
        {
            var List = _çalışanService.TGetList();
            return View(List);
        }
    }
}
