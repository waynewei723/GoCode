using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoCodeData.Model;

namespace GoCodeBiz.IBiz
{
    public interface IGoUser
    {
        GoUser Add(GoUser user);

        GoUser Get(Func<GoUser, bool> predicate);
    }
}
