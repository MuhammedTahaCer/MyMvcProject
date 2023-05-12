
using System.Data.Entity;

namespace DataAccess.Concrete
{
    public class Context: DbContext
         
    {

        public System.Data.Entity.DbSet<EntityLayer.Concrete_Somut.About> Abouts { get; set; }
        //Context sınıfının içindeki property ler tablo ismi ile sqlde karşılık bulacak
        //Bu layera EF kurmak gerekiyor ***
        //public DbSet<About> Abouts { get; set; } //Entity_Layer katmanını referans verdik <About>
        public DbSet<EntityLayer.Concrete_Somut.Category> Categories { get; set; }
        public DbSet<EntityLayer.Concrete_Somut.Contact> Contacts { get; set; }
        public DbSet<EntityLayer.Concrete_Somut.Content> Contents { get; set; }
        public DbSet<EntityLayer.Concrete_Somut.Head> Heads { get; set; }
        public DbSet<EntityLayer.Concrete_Somut.Writer> Writers{ get; set; }
        //Context sınıfı ne yapıcak; Buraya yazılan dbset türündeki propları, SQL de birer tablo olarak yansıtacak
        public DbSet<EntityLayer.Concrete_Somut.Message> Messages{ get; set; }
    }
}
