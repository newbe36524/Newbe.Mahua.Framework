using System;
using Newbe.Mahua.Commands;

namespace Newbe.Mahua.Amanda.Commands
{
    internal class GetQqWalletDataCommandHandler : CommandHandlerBase<GetQqWalletDataCommand>
    {
        protected override void HandleCore(GetQqWalletDataCommand command)
        {
            //todo
        }
    }

    [Serializable]
    internal class GetQqWalletDataCommand : AmandaCommand
    {
        public string Type { get; set; }
        public string Fromgroup { get; set; }
        public string Fromqq { get; set; }
        public string Money { get; set; }
        public string FriendRemark { get; set; }
        public string OrderNo { get; set; }
    }
}