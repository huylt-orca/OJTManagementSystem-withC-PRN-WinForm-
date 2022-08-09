using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data_Access
{
    public class TblAccountDAO
    {
        private OJT_MANAGEMENT_PRN211_Vs1Context db = new OJT_MANAGEMENT_PRN211_Vs1Context();
        //Using singleton
        private TblAccountDAO() { }
        private static TblAccountDAO instance = null;
        private static readonly object InstanceLock = new object();
        public static TblAccountDAO Instance
        {
            get
            {
                lock(InstanceLock)
                {
                    if (instance == null)
                    {
                        instance = new TblAccountDAO();
                    }
                    return instance;
                }
            }
        }
        // hàm kiểm tra Email đã tồn tại chưa 
        public bool CheckEmailIsExist(String email)
        {
            var result = db.TblAccounts.Find(email);
            if (result != null)
            {
                return true;
            }
            return false;
        }

        public TblAccount GetAccountByEmail(string email) => db.TblAccounts.Find(email);


    }
}
