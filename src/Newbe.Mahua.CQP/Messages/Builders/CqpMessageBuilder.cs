using Newbe.Mahua.Messages;
using Newbe.Mahua.Messages.Builders;
using System;
using System.IO;

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
        private readonly IMessage _message;

        public CqpMessageBuilder(
            IMessage message)
        {
            _message = message;
        }

        public void At(string qq)
        {
            _message.Append($"[CQ:at,qq={qq}]");
        }

        public void AtlAll()
        {
            _message.Append($"[CQ:at,qq=all]");
        }

        /// <summary>
        /// {1}为该原创表情的ID，存放在酷Q目录的data\bface\下
        /// </summary>
        /// <param name="id"></param>
        public void BFace(string id)
        {
            _message.Append($"[CQ:bface,id={id}]");
        }

        public void Emoji(string id)
        {
            _message.Append($"[CQ:emoji,id={id}]");
        }

        public void Face(string id)
        {
            _message.Append($"[CQ:face,id={id}]");
        }

        /// <summary>
        /// {1}为图片文件名称，图片存放在酷Q目录的data\image\下
        /// </summary>
        /// <param name="file"></param>
        public void Image(string file)
        {
            var destFileName = file;
            if (!file.StartsWith(CqpDirectories.Image))
            {
                destFileName = Path.Combine(CqpDirectories.Image, Path.GetFileName(file));
                File.Copy(file, destFileName);
            }
            _message.Append($"[CQ:image,file={destFileName}]");
        }

        public void Record(string file)
        {
            var destFileName = file;
            if (!file.StartsWith(CqpDirectories.Record))
            {
                destFileName = Path.Combine(CqpDirectories.Record, Path.GetFileName(file));
                File.Copy(file, destFileName);
            }
            _message.Append($"[CQ:record,file={destFileName},magic=false]");
        }

        public void SFace(string id)
        {
            _message.Append($"[CQ:sface,id={id}]");
        }

        public void Shake()
        {
            _message.Append("[CQ:shake]");
        }

        public void Text(string text)
        {
            _message.Append(text);
        }

        public void Newline()
        {
            _message.Append(Environment.NewLine);
        }
    }
}
