using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository
{
    public interface IRepositoryTblStudent
    {
        bool ChecStudentIDIsExist(string studentID);
        IEnumerable<TblStudent> GetStudentListBySemesterID(int semesterID);
        IEnumerable<TblStudent> GetStudentListByStudentName(int semesterID, string studentName);
        IEnumerable<TblStudent> GetStudentListByStudentCode(int semesterID, string studentCode);
        IEnumerable<TblStudent> GetStudentListByAddress(int semesterID, string address);
        IEnumerable<TblStudent> GetStudentListByCredits(int semesterID, int credit);
        IEnumerable<TblStudent> GetStudentListByMajorName(int semesterID, string major);

    }
}
