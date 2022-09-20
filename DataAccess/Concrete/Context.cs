using EntityLayer.Concrete_Somut;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class Context: DbContext
         
    {
        //Context sınıfının içindeki property ler tablo ismi ile sqlde karşılık bulacak
        //Bu layera EF kurmak gerekiyor ***
        public DbSet<About> Abouts { get; set; } //Entity_Layer katmanını referans verdik <About>
        public DbSet<Contact> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Head> Heads { get; set; }
        public DbSet<Writer> Writers{ get; set; }
        //Context sınıfı ne yapıcak; Buraya yazılan dbset türündeki propları, SQL de birer tablo olarak yansıtacak
    }
}
