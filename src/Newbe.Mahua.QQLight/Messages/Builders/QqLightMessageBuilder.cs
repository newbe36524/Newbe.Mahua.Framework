using Newbe.Mahua.Messages.Builders;
using System;

namespace Newbe.Mahua.QQLight.Messages.Builders
{
    public class QqLightMessageBuilder :
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
        private readonly IQqLightMessage _qqLightMessage;

        public QqLightMessageBuilder(
            IQqLightMessage qqLightMessage)
        {
            _qqLightMessage = qqLightMessage;
        }

        public void At(string qq)
        {
            _qqLightMessage.Append($"[QQ:at={qq}]");
        }

        public void AtlAll()
        {
            _qqLightMessage.Append("[QQ:at=all]");
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
            _qqLightMessage.Append($"[QQ:emoji={id}]");
        }

        public void Face(string id)
        {
            _qqLightMessage.Append($"[QQ:face={id}]");
        }

        /// <summary>
        /// {1}为图片文件名称，图片存放在酷Q目录的data\image\下
        /// </summary>
        /// <param name="file"></param>
        public void Image(string file)
        {
            _qqLightMessage.Append($"[QQ:pic={file}]");
        }

        public void Record(string file)
        {
            _qqLightMessage.Append($"[QQ:voice={file}]");
        }

        public void SFace(string id)
        {
            MahuaGlobal.NotSupportedMessageBuilderConvertion.Handle<ISFace>();
        }

        public void Shake()
        {
            _qqLightMessage.Shake = true;
        }

        public void Text(string text)
        {
            _qqLightMessage.Append(text);
        }

        public void Newline()
        {
            _qqLightMessage.Append(Environment.NewLine);
        }
    }
}
