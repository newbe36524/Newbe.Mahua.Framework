using Newbe.Mahua.Commands;
using System.Runtime.Serialization;

namespace Newbe.Mahua.QQLight.Commands
{
    [DataContract]
    public class GetQqWalletDataCommand : QqLightCommand
    {
        [DataMember]
        public int Type { get; set; }

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

    internal class GetQqWalletDataCommandHandler : ICommandHandler<GetQqWalletDataCommand>
    {
        public void Handle(GetQqWalletDataCommand message)
        {
            // todo
        }
    }
}
