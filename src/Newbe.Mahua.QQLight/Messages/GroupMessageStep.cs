using Newbe.Mahua.Messages;
using Newbe.Mahua.Messages.Builders;

namespace Newbe.Mahua.QQLight.Messages
{
    public class GroupMessageStep : IGroupMessageStep
    {
        private readonly IGroupMessageStep2 _groupMessageStep2;
        private readonly IAtAll _atAll;
        private readonly IAt _at;
        private readonly IText _text;
        private readonly IImage _image;
        private readonly IFace _face;
        private readonly IBFace _bFace;
        private readonly ISFace _sFace;
        private readonly IEmoji _emoji;

        public GroupMessageStep(
            IGroupMessageStep2 groupMessageStep2,
            IAtAll atAll,
            IAt at,
            IText text,
            IImage image,
            IFace face,
            IBFace bFace,
            ISFace sFace,
            IEmoji emoji)
        {
            _groupMessageStep2 = groupMessageStep2;
            _atAll = atAll;
            _at = at;
            _text = text;
            _image = image;
            _face = face;
            _bFace = bFace;
            _sFace = sFace;
            _emoji = emoji;
        }

        public IGroupMessageStep2 AtlAll()
        {
            _atAll.AtlAll();
            return _groupMessageStep2;
        }

        public IGroupMessageStep2 At(string qq)
        {
            _at.At(qq);
            return _groupMessageStep2;
        }

        public IGroupMessageStep2 Text(string text)
        {
            _text.Text(text);
            return _groupMessageStep2;
        }

        public IGroupMessageStep2 Newline()
        {
            _text.Newline();
            return _groupMessageStep2;
        }

        public IGroupMessageStep2 Image(string file)
        {
            _image.Image(file);
            return _groupMessageStep2;
        }

        public IGroupMessageStep2 Face(string id)
        {
            _face.Face(id);
            return _groupMessageStep2;
        }

        public IGroupMessageStep2 BFace(string id)
        {
            _bFace.BFace(id);
            return _groupMessageStep2;
        }

        public IGroupMessageStep2 SFace(string id)
        {
            _sFace.SFace(id);
            return _groupMessageStep2;
        }

        public IGroupMessageStep2 Emoji(string id)
        {
            _emoji.Emoji(id);
            return _groupMessageStep2;
        }
    }
}
