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
    public class RandevuManeger : IRandevuService
    {
        private readonly IRandevuDal _randevudal;

        public RandevuManeger(IRandevuDal randevudal)
        {
            _randevudal = randevudal;
        }

        public void TDelete(int id)
        {
            _randevudal.Delete(id);
        }

        public Randevu TGetById(int id)
        {
            return _randevudal.GetById(id);
        }

        public List<Randevu> TGetList()
        {
            return _randevudal.GetList();
        }

        public void TInsert(Randevu item)
        {
            _randevudal.Insert(item);
        }

        public void TUpdate(Randevu item)
        {
            _randevudal.Update(item);
        }
    }
}
