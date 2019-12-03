using ASPNETCoreTutorial01.Interfaces;
using System;

namespace ASPNETCoreTutorial01.Workers
{
    public class SystemDateTime : IDateTime
    {
        public DateTime Now
        {
            get { return DateTime.Now; }
        }
    }
}
