using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoCodeBiz.IBiz;
using GoCodeData;
using GoCodeData.Model;

namespace GoCodeBiz.CBiz
{
    public class CGoUser:IGoUser
    {
        public GoUser Add(GoUser user)
        {
            using (GoDataContext context = new GoDataContext())
            {
                user = context.GoUsers.Add(user);
            }

            return user;
        }

        public GoUser Get(Func<GoUser, bool> predicate)
        {
            GoUser model = null;
            using (GoDataContext context = new GoDataContext())
            {
                model = context.GoUsers.FirstOrDefault(predicate);
            }

            return model;
        }
    }
}
