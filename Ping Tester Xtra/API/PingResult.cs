using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;
using System.Net;

namespace PingTesterXtra
{
    public class PingResult
    {
        public int Time { get; private set; }
        public string IPAddress { get; private set; }
        public string HostName { get; private set; }
        public IPStatus PreciseStatus { get; private set; }
        public PingRating Rating { get; private set; }
        public BriefIPStatus SimplifiedStatus { get; private set; }
        public string TimeString
        {
            get
            {
                return string.Format("{0} ms", this.Time);
            }
        }

        public PingResult()
        {
            this.Time = -1;
            this.IPAddress = string.Empty;
            this.HostName = string.Empty;
            this.PreciseStatus = IPStatus.Unknown;
            this.Rating = PingRating.Empty;
            this.SimplifiedStatus = BriefIPStatus.Error;
        }

        public PingResult(BriefIPStatus simplifiedStatus)
            : this()
        {
            if (simplifiedStatus == BriefIPStatus.OK)
            {
                throw new ArgumentException("PingResult.SimplifiedStatus can't be manually set to OK.");
            }
            this.SimplifiedStatus = simplifiedStatus;
        }

        public PingResult(PingReply reply)
        {
            this.Time = (int)reply.RoundtripTime;
            this.IPAddress = reply.Address.ToString();
            this.HostName = Dns.GetHostEntry(reply.Address).HostName;
            this.PreciseStatus = reply.Status;

            if (reply.Status == IPStatus.Success)
            {
                this.Rating = PingRating.FromTime(reply.RoundtripTime);
                this.SimplifiedStatus = BriefIPStatus.OK;
            }
            else
            {
                this.Rating = PingRating.Empty;
                this.SimplifiedStatus = BriefIPStatus.Error;
            }
        }
    }
}
