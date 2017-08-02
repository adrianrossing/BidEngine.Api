using System;
using System.Collections.Generic;

namespace BidEngine.Api.Types
{
    public class Keyword
    {
        public List<string> Words { get; set; }
        public decimal AvgPricePerClick { get; set; }
		public int NumClicks { get; set; }
		public Bid Bid { get; set; }
	}
}
