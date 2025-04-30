using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EhliyetProjesii.ViewComponents.Default
{
    public class _TestimonialPartial:ViewComponent
    {
        private readonly IYorumlarService _yorumlarService;

        public _TestimonialPartial(IYorumlarService yorumlarService)
        {
            _yorumlarService = yorumlarService;
        }

        public IViewComponentResult Invoke()
        {
            var List = _yorumlarService.TGetList();
            return View(List);
        }
    }
}
