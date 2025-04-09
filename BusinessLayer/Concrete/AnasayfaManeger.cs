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
    public class AnasayfaManeger : IAnasayfaService
    {
        private readonly IAnasayfaDal _anasayfaDal;

        public AnasayfaManeger(IAnasayfaDal anasayfaDal)
        {
            _anasayfaDal = anasayfaDal;
        }

        public void TDelete(int id)
        {
            _anasayfaDal.Delete(id);
        }

        public Anasayfa TGetById(int id)
        {
            return _anasayfaDal.GetById(id);
        }

        public List<Anasayfa> TGetList()
        {
            return _anasayfaDal.GetList();
        }

        public void TInsert(Anasayfa item)
        {
            _anasayfaDal.Insert(item);
        }

        public void TUpdate(Anasayfa item)
        {
            _anasayfaDal.Update(item);
        }
    }
}
