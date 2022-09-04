using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom2HuynhThiPhuongTram1951052208.LopLienQuan
{
    class CacCongThucToanHoc
    {
        public static int UCLN(int tu, int mau) //static : sử dụng được ở nhiều class mà không cần phải tạo mới
        {
            int t, m;
            t = Math.Abs(tu);
            m = Math.Abs(mau);
            if (m == 0)
            {
                return t;
            }
            return UCLN(m, t % m);
        }
    }
}
