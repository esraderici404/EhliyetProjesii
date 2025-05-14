using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfÖzelliklerDal : GenericRepository<Özellikler>, IÖzelliklerDal
    {
        public EfÖzelliklerDal(Context context) : base(context)
        {
        }
    }
}
