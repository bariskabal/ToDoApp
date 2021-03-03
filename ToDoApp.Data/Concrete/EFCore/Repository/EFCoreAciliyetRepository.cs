using System.Collections.Generic;
using System.Linq;
using ToDoApp.Data.Concrete.EFCore.Contexts;
using ToDoApp.Data.Interfaces;
using ToDoApp.Entities.Interfaces;
using ToDoApp.Entities.Concrete;

namespace ToDoApp.Data.Concrete.EFCore.Repository
{
    public class EFCoreAciliyetRepository : EFGenericRepository<Aciliyet>,IAciliyetDal
    {
        
    }
}