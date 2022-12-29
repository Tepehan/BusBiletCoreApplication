using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using EntityLayer;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfGuzergahOtobusRepository: GenericRepository<GuzergahOtobus>, IGuzergahOtobusDal
    {
    }
}
