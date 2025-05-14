using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-TQ162FD\\SQLEXPRESS;database=EhliyetProjesii;integrated security=true; TrustServerCertificate=True");
        }
        DbSet<Anasayfa>anasayfas { get; set; }
        DbSet<Hizmet>hizmets { get; set; }
        DbSet<Hakkımızda>hakkımızdas { get; set; }
        DbSet<Kurs>kurs { get; set; }
        DbSet<Randevu>randevus { get; set; }
        DbSet<Çalışan>çalışans {  get; set; }
        DbSet<Yorumlar> yorumlars { get; set; }
        DbSet<Özellikler>özelliklers { get; set; }
    }
}
