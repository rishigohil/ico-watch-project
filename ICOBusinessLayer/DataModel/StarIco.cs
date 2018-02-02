using System;
using System.Collections.Generic;
using System.Text;

namespace ICOBusinessLayer.DataModel
{
    /// <summary>
    /// Data model to send star ico information.
    /// </summary>
    public class StarIco
    {
        public string IcoName { get; set; }

        public int DownVoteNumber { get; set; }

        public string IcoDescription { get; set; }
    }
}
