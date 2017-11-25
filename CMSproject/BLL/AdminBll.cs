using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AdminBll
    {
        public CategoryBll categoryBll { get; set; }
        public UserBll userBll { get; set; }
        public UrlBll urlBll { get; set; }

        public AdminBll()
        {
            categoryBll = new CategoryBll();
            userBll = new UserBll();
            urlBll = new UrlBll();
        }
    }
}
