using Model.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class HoaDonModel
    {
        private SanBongdaDBConText context = null;
        public HoaDonModel()
        {
            context = new SanBongdaDBConText();

        }
        public List<tblHoaDon> ListAll()
        {
            var list = (from c in context.tblHoaDons select c).ToList();
            return list;
        }
    }
}
