using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfFirmaRepository : GenericRepository<Firma> , IFirmaDal
    {

    }
}
