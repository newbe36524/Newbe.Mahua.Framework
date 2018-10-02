using Newbe.Mahua.Messages;
using Newbe.Mahua.Messages.Builders;
using Newbe.Mahua.Messages.CancelMessage;
using Newbe.Mahua.Messages.Steps;

namespace Newbe.Mahua.CleverQQ.Messages
{
    public class PrivateMessageStep2 : IPrivateMessageStep2
    {
        private readonly IBFace _bFace;
        private readonly IEmoji _emoji;
        private readonly IFace _face;
        private readonly IImage _image;
        private readonly IPrivateMessageDone _privateMessageDone;
        private readonly ISFace _sFace;
        private readonly IText _text;

        public PrivateMessageStep2(
            IPrivateMessageDone privateMessageDone,
            IText text,
            IImage image,
            IFace face,
            IBFace bFace,
            ISFace sFace,
            IEmoji emoji)
        {
            _privateMessageDone = privateMessageDone;
            _text = text;
            _image = image;
            _face = face;
            _bFace = bFace;
            _sFace = sFace;
            _emoji = emoji;
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