using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace SteffBeckers.Abp.Sales.Accounts
{
    public class AccountAlreadyExistsException : BusinessException
    {
        public AccountAlreadyExistsException(string name)
            : base(SalesErrorCodes.AccountAlreadyExists)
        {
            WithData("name", name);
        }
    }
}
