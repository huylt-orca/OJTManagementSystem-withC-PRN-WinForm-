using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data_Access
{
    public class TblSemesterDAO
    {
        private OJT_MANAGEMENT_PRN211_Vs1Context db = new OJT_MANAGEMENT_PRN211_Vs1Context();
        //Using singleton
        private TblSemesterDAO() { }
        private static TblSemesterDAO instance = null;
        private static readonly object InstanceLock = new object();
        public static TblSemesterDAO Instance
        {
            get
            {
                lock (InstanceLock)
                {
                    if (instance == null)
                    {
                        instance = new TblSemesterDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<string> GetAllSemesterName()
        {
            var list = from c in db.TblSemesters
                       select c.SemesterName;
            return list.ToList();
        }
        public TblSemester GetSemterIDBySemesterName(int id) => db.TblSemesters.Find(id);
        public TblSemester GetCurrentSemester() => db.TblSemesters.OrderBy(p => p.SemesterId).FirstOrDefault();


    }
}
