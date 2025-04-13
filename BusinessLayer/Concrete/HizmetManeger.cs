using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HizmetManeger : IHizmetService
    {
        private readonly IHizmetDal _hizmetService;

        public HizmetManeger(IHizmetDal hizmetService)
        {
            _hizmetService = hizmetService;
        }

        public void TDelete(int id)
        {
            _hizmetService.Delete(id);
        }

        public Hizmet TGetById(int id)
        {
            return _hizmetService.GetById(id);
        }

        public List<Hizmet> TGetList()
        {
            return _hizmetService.GetList();
        }

        public void TInsert(Hizmet item)
        {
            _hizmetService.Insert(item);
        }

        public void TUpdate(Hizmet item)
        {
            _hizmetService.Update(item);
        }
    }
}
