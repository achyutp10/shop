using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Specifications
{
    public class ProductSpecParams
    {
		private List<string> _brands = [];

		public List<string> Brands
		{
			get => _brands; // types=borads, gloves
			set
			{
				_brands = value.SelectMany(x=>x.Split(',',
					StringSplitOptions.RemoveEmptyEntries)).ToList();
			}
		}

        private List<string> _types = [];

        public List<string> Types
        {
            get => _types; // types=borads, gloves
            set
            {
                _types = value.SelectMany(x => x.Split(',',
                    StringSplitOptions.RemoveEmptyEntries)).ToList();
            }
        }

        public string? Sort { get; set; }

    }
}
