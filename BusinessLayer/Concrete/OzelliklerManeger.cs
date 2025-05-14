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
    public class OzelliklerManeger : IÖzelliklerService
    {
        private readonly IÖzelliklerDal _özelliklerDal;

        public OzelliklerManeger(IÖzelliklerDal özelliklerDal)
        {
            _özelliklerDal = özelliklerDal;
        }

        public void TDelete(int id)
        {
            _özelliklerDal.Delete(id);
        }

        public Özellikler TGetById(int id)
        {
            return _özelliklerDal.GetById(id);
        }

        public List<Özellikler> TGetList()
        {
            return _özelliklerDal.GetList();
        }

        public void TInsert(Özellikler item)
        {
            _özelliklerDal.Insert(item);
        }

        public void TUpdate(Özellikler item)
        {
            _özelliklerDal.Update(item);
        }
    }
}
