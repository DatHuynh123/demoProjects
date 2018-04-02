using Model.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class ThanhVienModel
    {

        private SanBongdaDBConText context = null;
        public ThanhVienModel()
        {
            context = new SanBongdaDBConText();

        }
        public List<tblThanhVien> ListAll()
        {
            var list = (from c in context.tblThanhViens select c).ToList();
            return list;
        }

    }
}
