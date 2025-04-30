using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EhliyetProjesii.ViewComponents.Default
{
    public class _CoursesPartial:ViewComponent
    {
        private readonly IKursService _kursService;

        public _CoursesPartial(IKursService kursService)
        {
            _kursService = kursService;
        }

        public IViewComponentResult Invoke()
        {
            var List = _kursService.TGetList();
            return View(List);
        }
    }
}
