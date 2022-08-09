using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository
{
    public class RepositoryTblSemester: IRepositoryTblSemester
    {
        public IEnumerable<string> GetAllSemesterName() => TblSemesterDAO.Instance.GetAllSemesterName();

        public TblSemester GetCurrentSemester() => TblSemesterDAO.Instance.GetCurrentSemester();

        public TblSemester GetSemterIDBySemesterName(int id) => TblSemesterDAO.Instance.GetSemterIDBySemesterName(id);

    }
}
