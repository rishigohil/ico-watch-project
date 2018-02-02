using ICOBusinessLayer.Contract;
using ICOBusinessLayer.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICOBusinessLayer.Manager
{
    public class ExchangeService : IExchangeService
    {
        /// <summary>
        /// Service method to send all star ico's. The logic will be updated in future after investigation.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<StarIco> GetStarIcos()
        {
            return new List<StarIco> {
                new StarIco{
                    IcoDescription = "Vitalik, Vlad and 500 more..",
                    IcoName = "Test ICO",
                    DownVoteNumber = 500
                },
                new StarIco{
                    IcoDescription = "Vinny Lingham, Charlie Lee and 500 more..",
                    IcoName = "Russia Coin",
                    DownVoteNumber = 500
                },
                new StarIco{
                    IcoDescription = "Vitalik, Vlad and 500 more..",
                    IcoName = "Music Coin",
                    DownVoteNumber = 500
                }
            };
        }

        /// <summary>
        /// Service method to send a model object containing Token scam information. The logic will be updated in future after investigation.
        /// </summary>
        /// <param name="icoName">Name of the token</param>
        /// <returns>Scam status object containing scam information and error message (if any)</returns>
        public IcoScamStatus GetIcoScamStatus(string icoName)
        {
            var scamStatus = new IcoScamStatus();

            if (string.IsNullOrEmpty(icoName))
            {
                scamStatus.ErrorMessage = "Token name cannot be empty.";
                return scamStatus;
            }

            scamStatus.IsScam = false;


            return scamStatus;
        }
    }
}
