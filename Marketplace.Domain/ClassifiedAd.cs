using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Domain
{
    public class ClassifiedAd
    {
        public Guid Id { get; }

        public ClassifiedAd(Guid id, Guid ownerId)
        {
            if(id == default)
                throw new ArgumentException("Identity must be specified", nameof(id));
            if(_ownerId == default)
                throw new ArgumentException("Owner id must be specified", nameof(ownerId));
            Id = id;
            _ownerId = ownerId;
        }

        public void SetTitle(string title) => _title = title;
        public void UpdateText(string text) => _text = text;
        public void UpdatePrice(decimal price) => _price = price;

        private Guid _ownerId;
        private string _title;
        private string _text;
        private decimal _price;
    }
}
