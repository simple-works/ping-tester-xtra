using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PingTesterXtra.Properties;

namespace PingTesterXtra
{
    public class PingTestManager
    {
        private string _host;
        private int _interval;

        public string Host
        {
            get
            {
                return this._host;
            }
            set
            {
                Settings.Default.Host = this._host = value;
                Settings.Default.Save();
            }
        }
        public int Interval
        {
            get
            {
                return this._interval;
            }
            set
            {
                Settings.Default.Interval = this._interval = value;
                Settings.Default.Save();
            }
        }

        public PingTestManager()
        {
            this.Host = Settings.Default.Host;
            this.Interval = Settings.Default.Interval;
        }

        public PingResult RunPingTest()
        {
            return PingTest.Run(this.Host);
        }
    }
}
