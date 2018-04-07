using Newbe.Mahua.Messages.Builders;
using System;

namespace Newbe.Mahua.Amanda.Messages.Builders
{
    public class AmandaMessageBuilder :
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
        private readonly IAmandaMessage _amandaMessage;

        public AmandaMessageBuilder(
            IAmandaMessage amandaMessage)
        {
            _amandaMessage = amandaMessage;
        }

        public void At(string qq)
        {
            _amandaMessage.Append($"[QQ:at={qq}]");
        }

        public void AtlAll()
        {
            _amandaMessage.Append("[QQ:at=all]");
        }

        /// <summary>
        /// {1}为该原创表情的ID，存放在酷Q目录的data\bface\下
        /// </summary>
        /// <param name="id"></param>
        public void BFace(string id)
        {
            MahuaGlobal.NotSupportedMessageBuilderConvertion.Handle<IBFace>();
        }

        public void Emoji(string id)
        {
            _amandaMessage.Append($"[QQ:emoji={id}]");
        }

        public void Face(string id)
        {
            _amandaMessage.Append($"[QQ:face={id}]");
        }

        /// <summary>
        /// {1}为图片文件名称，图片存放在酷Q目录的data\image\下
        /// </summary>
        /// <param name="file"></param>
        public void Image(string file)
        {
            _amandaMessage.Append($"[QQ:pic={file}]");
        }

        public void Record(string file)
        {
            _amandaMessage.Append($"[QQ:voice={file}]");
        }

        public void SFace(string id)
        {
            MahuaGlobal.NotSupportedMessageBuilderConvertion.Handle<ISFace>();
        }

        public void Shake()
        {
            _amandaMessage.Shake = true;
        }

        public void Text(string text)
        {
            _amandaMessage.Append(text);
        }

        public void Newline()
        {
            _amandaMessage.Append(Environment.NewLine);
        }
    }
}
