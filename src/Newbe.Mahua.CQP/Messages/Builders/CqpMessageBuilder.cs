using Newbe.Mahua.Messages;
using Newbe.Mahua.Messages.Builders;
using System;

namespace Newbe.Mahua.CQP.Messages.Builders
{
    public class CqpMessageBuilder :
        IAt,
        IAtAll,
        IBFace,
        IEmoji,
        IFace,
        IImage,
        IRecord,
        ISFace,
        IShake,
        IText
    {
        private readonly IMessageBuilder _messageBuilder;

        public CqpMessageBuilder(
            IMessageBuilder messageBuilder)
        {
            _messageBuilder = messageBuilder;
        }

        public void At(string qq)
        {
            _messageBuilder.Append($"[CQ:at,qq={qq}]");
        }

        public void AtlAll()
        {
            _messageBuilder.Append($"[CQ:at,qq=all]");
        }

        /// <summary>
        /// {1}为该原创表情的ID，存放在酷Q目录的data\bface\下
        /// </summary>
        /// <param name="id"></param>
        public void BFace(string id)
        {
            _messageBuilder.Append($"[CQ:bface,id={id}]");
        }

        public void Emoji(string id)
        {
            _messageBuilder.Append($"[CQ:emoji,id={id}]");
        }

        public void Face(string id)
        {
            _messageBuilder.Append($"[CQ:face,id={id}]");
        }

        /// <summary>
        /// {1}为图片文件名称，图片存放在酷Q目录的data\image\下
        /// </summary>
        /// <param name="file"></param>
        public void Image(string file)
        {
            _messageBuilder.Append($"[CQ:image,file={file}]");
        }

        /// <summary>
        /// {1}为音频文件名称，音频存放在酷Q目录的data\record\下
        /// </summary>
        /// <param name="file"></param>
        /// <param name="magic"></param>
        public void Record(string file, bool magic)
        {
            _messageBuilder.Append($"[CQ:record,file={file},magic={magic.ToString().ToLowerInvariant()}]");
        }

        public void Record(string file)
        {
            _messageBuilder.Append($"[CQ:record,file={file},magic=false]");
        }

        public void SFace(string id)
        {
            _messageBuilder.Append($"[CQ:sface,id={id}]");
        }

        public void Shake()
        {
            _messageBuilder.Append("[CQ:shake]");
        }

        public void Text(string text)
        {
            _messageBuilder.Append(text);
        }

        public void Newline()
        {
            _messageBuilder.Append(Environment.NewLine);
        }
    }
}
