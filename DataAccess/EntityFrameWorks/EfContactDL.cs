using DataAccess.Abstract;
using DataAccess.Concrete.Repositories;
using EntityLayer.Concrete_Somut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFrameWorks
{
    public class EfContactDL :GenericRepository<Contact>,IContactDl
    {
    }
}
