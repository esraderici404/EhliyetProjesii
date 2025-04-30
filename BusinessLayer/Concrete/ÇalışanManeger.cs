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
    public class ÇalışanManeger : IÇalışanService
    {
        private readonly IÇalışanDal _çalışanDal;

        public ÇalışanManeger(IÇalışanDal çalışanDal)
        {
            _çalışanDal = çalışanDal;
        }

        public void TDelete(int id)
        {
            _çalışanDal.Delete(id);
        }

        public Çalışan TGetById(int id)
        {
            return _çalışanDal.GetById(id);
        }

        public List<Çalışan> TGetList()
        {
            return _çalışanDal.GetList();
        }

        public void TInsert(Çalışan item)
        {
            _çalışanDal.Insert(item);
        }

        public void TUpdate(Çalışan item)
        {
            _çalışanDal.Update(item);
        }
    }
}
