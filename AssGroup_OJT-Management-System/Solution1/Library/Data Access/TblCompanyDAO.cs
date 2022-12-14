using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data_Access
{
    public class TblCompanyDAO
    {
        //Using singleton
        private TblCompanyDAO() { }
        private static TblCompanyDAO instance = null;
        private static readonly object InstanceLock = new object();
        public static TblCompanyDAO Instance
        {
            get
            {
                lock (InstanceLock)
                {
                    if (instance == null)
                    {
                        instance = new TblCompanyDAO();
                    }
                    return instance;
                }
            }
        }
    }
}
