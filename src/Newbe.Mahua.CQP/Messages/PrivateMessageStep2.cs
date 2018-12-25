using Newbe.Mahua.Messages;
using Newbe.Mahua.Messages.Builders;
using Newbe.Mahua.Messages.CancelMessage;
using Newbe.Mahua.Messages.Steps;

namespace Newbe.Mahua.CQP.Messages
{
    public class PrivateMessageStep2 : IPrivateMessageStep2
    {
        private readonly IPrivateMessageDone _privateMessageDone;
        private readonly IText _text;
        private readonly IImage _image;
        private readonly IFace _face;
        private readonly IBFace _bFace;
        private readonly ISFace _sFace;
        private readonly IEmoji _emoji;
        private readonly IRecord _record;

        public PrivateMessageStep2(
            IPrivateMessageDone privateMessageDone,
            IText text,
            IImage image,
            IFace face,
            IBFace bFace,
            ISFace sFace,
            IEmoji emoji,
            IRecord record)
        {
            _privateMessageDone = privateMessageDone;
            _text = text;
            _image = image;
            _face = face;
            _bFace = bFace;
            _sFace = sFace;
            _emoji = emoji;
            _record = record;
        }

        public IPrivateMessageStep2 Text(string text)
        {
            _text.Text(text);
            return this;
        }

        public IPrivateMessageStep2 Newline()
        {
            _text.Newline();
            return this;
        }

        public IPrivateMessageStep2 Image(string file)
        {
            _image.Image(file);
            return this;
        }

        public IPrivateMessageStep2 Face(string id)
        {
            _face.Face(id);
            return this;
        }

        public IPrivateMessageStep2 BFace(string id)
        {
            _bFace.BFace(id);
            return this;
        }

        public IPrivateMessageStep2 SFace(string id)
        {
            _sFace.SFace(id);
            return this;
        }

        public IPrivateMessageStep2 Emoji(string id)
        {
            _emoji.Emoji(id);
            return this;
        }

        public IPrivateMessageStep2 Record(string file)
        {
            _record.Record(file);
            return this;
        }

        public IPrivateMessageStep2 Record(string file, bool magic)
        {
            _record.Record(file, magic);
            return this;
        }

        public void Done()
        {
            _privateMessageDone.Done();
        }

        public IMessageCancelToken DoneWithToken()
        {
            return _privateMessageDone.DoneWithToken();
        }

    }
}