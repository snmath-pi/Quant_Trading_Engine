﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingEngineServer.Core.Configuration
{
    internal class TradingEngineServerConfiguration
    {
        public TradingEngineServerConfiguration? TradingEngineServerSettings { get; set; }
    }

    class TradingEngineServerSettings
    {
        public int Port { get; set; }
    }
}
