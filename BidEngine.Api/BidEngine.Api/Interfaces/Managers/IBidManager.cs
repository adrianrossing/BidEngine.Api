using System;
using System.Collections.Generic;
using BidEngine.Api.Types;

namespace BidEngine.Api.Interfaces.Managers
{
    public interface IBidManager
    {
        Bid CalculateNextBid(Bid currentBid);
        List<Bid> GetCurrentBids();
    }
}
