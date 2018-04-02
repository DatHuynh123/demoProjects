using Model.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class SanModel
    {
         private SanBongdaDBConText context = null;
        public SanModel()
        {
            context = new SanBongdaDBConText();

        }
        public List<tblSan> ListAll()
        {
            var list = (from c in context.tblSans select c).ToList();
            return list;
        }

    }
}
