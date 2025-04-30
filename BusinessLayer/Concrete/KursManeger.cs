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
    public class KursManeger : IKursService
    {
        private readonly IKursDal _kursDal;

        public KursManeger(IKursDal kursDal)
        {
            _kursDal = kursDal;
        }

        public void TDelete(int id)
        {
            _kursDal.Delete(id);
        }

        public Kurs TGetById(int id)
        {
            return _kursDal.GetById(id);
        }

        public List<Kurs> TGetList()
        {
            return _kursDal.GetList();
        }

        public void TInsert(Kurs item)
        {
            _kursDal.Insert(item);
        }

        public void TUpdate(Kurs item)
        {
            _kursDal.Update(item);
        }
    }
}
