using ICOBusinessLayer.DataModel;
using System.Collections.Generic;

namespace ICOBusinessLayer.Contract
{
    public interface IExchangeService
    {
        IEnumerable<StarIco> GetStarIcos();

        IcoScamStatus GetIcoScamStatus(string icoName);
    }
}
