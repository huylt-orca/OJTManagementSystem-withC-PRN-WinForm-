using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data_Access
{
    public class TblStudentDAO
    {
        private OJT_MANAGEMENT_PRN211_Vs1Context db = new OJT_MANAGEMENT_PRN211_Vs1Context();
        //Using singleton
        private TblStudentDAO() { }
        private static TblStudentDAO instance = null;
        private static readonly object InstanceLock = new object();
        public static TblStudentDAO Instance
        {
            get
            {
                lock (InstanceLock)
                {
                    if (instance == null)
                    {
                        instance = new TblStudentDAO();
                    }
                    return instance;
                }
            }
        }

        public bool ChecStudentIDIsExist(string studentID)
        {
            var result = db.TblStudents.Find(studentID);
            if (result == null)
            {
                return false;
            }
            return true;
        }

        public IEnumerable<TblStudent> GetStudentListBySemesterID(int semesterID)
        {
            var list = from student in db.TblStudents
                       join semester in db.TblStudentSemesters on student.StudentCode equals semester.StudentCode
                       where semester.SemesterId == semesterID
                       select student;
            return list;

        }
        public IEnumerable<TblStudent> GetStudentListByStudentName(int semesterID, string studentName)
        {
            var list = from student in db.TblStudents
                       join semester in db.TblStudentSemesters on student.StudentCode equals semester.StudentCode
                       where semester.SemesterId == semesterID && student.StudentName.Contains(studentName)
                       select student;
            return list;

        }
        public IEnumerable<TblStudent> GetStudentListByStudentCode(int semesterID, string studentCode)
        {
            var list = from student in db.TblStudents
                       join semester in db.TblStudentSemesters on student.StudentCode equals semester.StudentCode
                       where semester.SemesterId == semesterID && student.StudentCode.Contains(studentCode)
                       select student;
            return list;

        }
        public IEnumerable<TblStudent> GetStudentListByAddress(int semesterID, string address)
        {
            var list = from student in db.TblStudents
                       join semester in db.TblStudentSemesters on student.StudentCode equals semester.StudentCode
                       where semester.SemesterId == semesterID && student.Address.Contains(address)
                       select student;
            return list;

        }
        public IEnumerable<TblStudent> GetStudentListByCredits(int semesterID, int credit)
        {
            var list = from student in db.TblStudents
                       join semester in db.TblStudentSemesters on student.StudentCode equals semester.StudentCode
                       where semester.SemesterId == semesterID && student.Credit == credit
                       select student;
            return list;

        }
        public IEnumerable<TblStudent> GetStudentListByMajorName(int semesterID, string major)
        {
            var list = from student in db.TblStudents
                       join semester in db.TblStudentSemesters on student.StudentCode equals semester.StudentCode
                       where semester.SemesterId == semesterID && student.Majorname.Contains(major)
                       select student;
            return list;

        }


    }
}
