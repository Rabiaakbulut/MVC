using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context: DbContext //Context sınıfı DbContext sınıfından miras alsın
    {
        //context sınıfı tanımlanan propertyleri SQL'e tablo olarak yansıtacak

        //pluralize isimlendirme
        //about  -> projenin içinde yer alan sınıfın ismi
        //abouts -> sql'e yansıyan tablonun ismi
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}
