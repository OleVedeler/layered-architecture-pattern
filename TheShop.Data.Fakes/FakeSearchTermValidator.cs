using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheShop.Domain.Core.Interfaces;

namespace TheShop.Data.Fakes
{
    public class FakeSearchTermValidator : ISearchTermValidator
    {
        public bool IsValid(string entityToValidate)
        {
            return true;
        }
    }
}
