﻿using System;

namespace Newbe.Mahua.Framework.CQP.Commands
{
    [Serializable]
    internal class InitializeCommand : CqpCommand
    {
        public int AuthCode { get; set; }
    }
}