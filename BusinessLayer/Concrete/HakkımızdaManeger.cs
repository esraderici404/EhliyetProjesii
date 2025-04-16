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
    public class HakkımızdaManeger : IHakkımızdaService
    {
        private readonly IHakkımızdaDal _hakkımzdaDal;

        public HakkımızdaManeger(IHakkımızdaDal hakkımzdaDal)
        {
            _hakkımzdaDal = hakkımzdaDal;
        }

        public void TDelete(int id)
        {
            _hakkımzdaDal.Delete(id);
        }

        public Hakkımızda TGetById(int id)
        {
            return _hakkımzdaDal.GetById(id);
        }

        public List<Hakkımızda> TGetList()
        {
           return _hakkımzdaDal.GetList();
        }

        public void TInsert(Hakkımızda item)
        {
            _hakkımzdaDal.Insert(item);
        }

        public void TUpdate(Hakkımızda item)
        {
            _hakkımzdaDal.Update(item);
        }
    }
}
