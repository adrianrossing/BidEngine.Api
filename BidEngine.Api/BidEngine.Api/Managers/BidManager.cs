using System;
using System.Collections.Generic;
using BidEngine.Api.Interfaces.Managers;
using BidEngine.Api.Types;

namespace BidEngine.Api.Managers
{
    public class BidManager :IBidManager
    {
        public BidManager()
        {
        }

        public List<Bid> GetCurrentBids()
        {
            return new List<Bid>()
            {
                new Bid(){
                    Amount= 10.00m
                },
                new Bid() {
                    Amount= .90m
                }
            };
        }


        Bid IBidManager.CalculateNextBid(Bid currentBid)
        {
            return new Bid()
            {
                Amount = 1.00m
            };
        }
    }
}
