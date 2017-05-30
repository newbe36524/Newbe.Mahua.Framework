using System;
using Newbe.Mahua.Framework.Commands;

namespace Newbe.Mahua.Framework.CQP.Commands.CommandResults
{
    [Serializable]
    internal class AppInfoCommandResult : MahuaCommandResult
    {
        public string AppId { get; set; }
    }
}