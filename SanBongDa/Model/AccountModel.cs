using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Model.Framework;

namespace Model
{
    public class AccountModel
    {
        private SanBongdaDBConText context = null;
        public AccountModel()
        {
            context = new SanBongdaDBConText();
        }
        public bool Login( String TenTk, String  PW)
        {
            object[] sqlParams =
            {
                new SqlParameter("@TenTK",TenTk),
                new SqlParameter("@PW",PW),
            };
            var res =
                context.Database.SqlQuery<bool>("Sp_tblUser_Login @TenTK,@PW", sqlParams).SingleOrDefault();
            return res;

           
        }
    }
}
