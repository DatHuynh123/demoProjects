using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Model2.NewFolder1;

namespace Model2
{
    public class AccountModel
    {
        private SBDDBConText context = null;
        public AccountModel()
        {
            context = new SBDDBConText();
        }
        public bool Login( String TenTk, String  PW)
        {
            object[] sqlParams =
            {
                new SqlParameter("@TenTK",TenTk),
                new SqlParameter("@PW",PW),
            };
            var res = context.Database.SqlQuery<bool>("Sp_tblUser_Login @TenTK,@PW", sqlParams).SingleOrDefault();
            return res;
        }
    }
}
