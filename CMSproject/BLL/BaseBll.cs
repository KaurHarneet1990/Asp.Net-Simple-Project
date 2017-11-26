using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class BaseBll
    {
        public CategoryBll categoryBll { get; set; }
        public UserBll userBll { get; set; }
        public UrlBll urlBll { get; set; }

        public BaseBll()
        {
            categoryBll = new CategoryBll();
            userBll = new UserBll();
            urlBll = new UrlBll();
        }
    }
}
