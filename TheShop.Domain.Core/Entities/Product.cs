using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheShop.Domain.Core.Values;

namespace TheShop.Domain.Core.Entities
{
    public class Product
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Price AskingPrice { get; set; }

        public override string ToString()
        {
            return string.Format("Product: '{0}' \t Asking Price: Kr.{1}", Name, AskingPrice.Value.ToString("### ### ###.00"));
        }
    }
}
