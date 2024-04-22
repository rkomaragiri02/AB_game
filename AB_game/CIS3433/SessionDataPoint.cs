using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS3433
{
    public class SessionDataPoint
    {
        public int sessionId { get; set; } 
        public string guess { get; set; } 
        public string hint { get; set; }

        public SessionDataPoint(int sessionId, string guess, string hint)
        {
            this.sessionId = sessionId;
            this.guess = guess;
            this.hint = hint;
        }
    }
}
