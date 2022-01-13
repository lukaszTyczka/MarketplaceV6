using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Domain
{
    public class ClassifiedAd
    {
        public Guid Id { get; private set; }

        public ClassifiedAd(Guid id)
        {
            if(id == default)
                throw new ArgumentNullException("Identity must be specified", nameof(id));
            Id = id;
        }

        private Guid _ownerId;
        private string _title;
        private string _text;
        private decimal _price;
    }
}
