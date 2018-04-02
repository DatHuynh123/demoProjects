using Model.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Model
{
    public class NhanVienModel
    {
        private SanBongdaDBConText context = null;
        public NhanVienModel()
        {
            context = new SanBongdaDBConText();
            
        }
        public List<tblNhanVien> ListAll()
        {
            var list = (from c in context.tblNhanViens select c).ToList();
        return list;
        }
        
    }
}
