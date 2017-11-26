using Newbe.Mahua.Commands;
using System.Runtime.Serialization;

namespace Newbe.Mahua.Amanda.Commands
{
    internal class GetQqWalletDataCommandHandler : ICommandHandler<GetQqWalletDataCommand>
    {
        public void Handle(GetQqWalletDataCommand command)
        {
            //todo
        }
    }

    [DataContract]
    public class GetQqWalletDataCommand : AmandaCommand
    {
        [DataMember]
        public string Type { get; set; }

        [DataMember]
        public string Fromgroup { get; set; }

        [DataMember]
        public string Fromqq { get; set; }

        [DataMember]
        public string Money { get; set; }

        [DataMember]
        public string FriendRemark { get; set; }

        [DataMember]
        public string OrderNo { get; set; }
    }
}
