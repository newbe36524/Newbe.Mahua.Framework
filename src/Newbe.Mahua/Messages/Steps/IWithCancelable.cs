using Newbe.Mahua.Messages.Steps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newbe.Mahua.Messages.Steps
{
    public interface IWithCancelable : IMessageBuildStep
    {
        /// <summary>
        /// 提供撤回令牌并完成发送
        /// </summary>
        /// <param name="token"></param>
        void WithCancelToken(IMessageCancelToken token);
    }
}
