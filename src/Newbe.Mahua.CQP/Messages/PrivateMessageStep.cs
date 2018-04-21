using Newbe.Mahua.Messages;
using Newbe.Mahua.Messages.Builders;
using Newbe.Mahua.Messages.Steps;

namespace Newbe.Mahua.CQP.Messages
{
    public class PrivateMessageStep : IPrivateMessageStep
    {
        private readonly IPrivateMessageStep2 _privateMessageStep2;
        private readonly IPrivateMessageDone _privateMessageDone;
        private readonly IShake _shake;
        private readonly IText _text;
        private readonly IImage _image;
        private readonly IFace _face;
        private readonly IBFace _bFace;
        private readonly ISFace _sFace;
        private readonly IEmoji _emoji;

        public PrivateMessageStep(
            IPrivateMessageStep2 privateMessageStep2,
            IPrivateMessageDone privateMessageDone,
            IShake shake,
            IText text,
            IImage image,
            IFace face,
            IBFace bFace,
            ISFace sFace,
            IEmoji emoji)
        {
            _privateMessageStep2 = privateMessageStep2;
            _privateMessageDone = privateMessageDone;
            _shake = shake;
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
            return _privateMessageStep2;
        }

        public IPrivateMessageStep2 Newline()
        {
            _text.Newline();
            return _privateMessageStep2;
        }

        public IPrivateMessageStep2 Image(string file)
        {
            _image.Image(file);
            return _privateMessageStep2;
        }

        public IPrivateMessageStep2 Face(string id)
        {
            _face.Face(id);
            return _privateMessageStep2;
        }

        public IPrivateMessageStep2 BFace(string id)
        {
            _bFace.BFace(id);
            return _privateMessageStep2;
        }

        public IPrivateMessageStep2 SFace(string id)
        {
            _sFace.SFace(id);
            return _privateMessageStep2;
        }

        public IPrivateMessageStep2 Emoji(string id)
        {
            _emoji.Emoji(id);
            return _privateMessageStep2;
        }

        public IPrivateMessageDone Shake()
        {
            _shake.Shake();
            return _privateMessageDone;
        }
    }
}
