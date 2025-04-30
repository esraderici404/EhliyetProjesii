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
    public class YorumlarManeger : IYorumlarService
    {
        private readonly IYorumlarDal _yorumlarDal;
        
        public YorumlarManeger(IYorumlarDal yorumlarDal)
        {
            _yorumlarDal = yorumlarDal;
        }

        public void TDelete(int id)
        {
            _yorumlarDal.Delete(id);
        }

        public Yorumlar TGetById(int id)
        {
            return _yorumlarDal.GetById(id);
        }

        public List<Yorumlar> TGetList()
        {
            return _yorumlarDal.GetList();
        }

        public void TInsert(Yorumlar item)
        {
            _yorumlarDal.Insert(item);
        }

        public void TUpdate(Yorumlar item)
        {
            _yorumlarDal.Update(item);
        }
    }
}
