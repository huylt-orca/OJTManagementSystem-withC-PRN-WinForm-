using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository
{
    public interface IRepositoryTblSemester
    {
        IEnumerable<string> GetAllSemesterName();
        TblSemester GetSemterIDBySemesterName(int id);

        TblSemester GetCurrentSemester();
    }
}
