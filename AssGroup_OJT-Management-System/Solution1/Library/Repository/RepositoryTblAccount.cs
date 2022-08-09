using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository
{
    public class RepositoryTblAccount: IRepositoryTblAccount
    {
        public bool CheckEmailIsExist(string email) => TblAccountDAO.Instance.CheckEmailIsExist(email);

        public TblAccount GetAccountByEmail(string email) => TblAccountDAO.Instance.GetAccountByEmail(email);

    }
}
