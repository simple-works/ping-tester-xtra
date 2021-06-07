using System;
using System.Drawing;
using System.Net.NetworkInformation;

namespace PingTesterXtra
{
    public static class PingTest
    {
        public static PingResult Run(string host)
        {
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                try
                {
                    PingReply reply = new Ping().Send(host);
                    return new PingResult(reply);
                }
                catch
                {
                    return new PingResult(BriefIPStatus.Error);
                }
            }
            else
            {
                return new PingResult(BriefIPStatus.Disconnected);
            }
        }
    }
}
