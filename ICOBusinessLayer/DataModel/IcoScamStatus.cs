using System;
using System.Collections.Generic;
using System.Text;

namespace ICOBusinessLayer.DataModel
{
    /// <summary>
    /// Data model to send scam status.
    /// </summary>
    public class IcoScamStatus
    {
        public Boolean IsScam { get; set; }

        public string ErrorMessage { get; set; }
    }
}
