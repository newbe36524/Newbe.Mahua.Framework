using Newbe.Mahua.Messages;
using Newbe.Mahua.Messages.Builders;

namespace Newbe.Mahua.CQP.Messages
{
    public class DiscussMessageStep : IDiscussMessageStep
    {
        private readonly IDiscussMessageStep2 _discussMessageStep2;
        private readonly IAtAll _atAll;
        private readonly IAt _at;
        private readonly IText _text;
        private readonly IImage _image;
        private readonly IFace _face;
        private readonly IBFace _bFace;
        private readonly ISFace _sFace;
        private readonly IEmoji _emoji;
        private readonly IRecord _record;

        public DiscussMessageStep(
            IDiscussMessageStep2 discussMessageStep2,
            IAtAll atAll,
            IAt at,
            IText text,
            IImage image,
            IFace face,
            IBFace bFace,
            ISFace sFace,
            IEmoji emoji,
            IRecord record)
        {
            _discussMessageStep2 = discussMessageStep2;
            _atAll = atAll;
            _at = at;
            _text = text;
            _image = image;
            _face = face;
            _bFace = bFace;
            _sFace = sFace;
            _emoji = emoji;
            _record = record;
        }

        public IDiscussMessageStep2 AtlAll()
        {
            _atAll.AtlAll();
            return _discussMessageStep2;
        }

        public IDiscussMessageStep2 At(string qq)
        {
            _at.At(qq);
            return _discussMessageStep2;
        }

        public IDiscussMessageStep2 Text(string text)
        {
            _text.Text(text);
            return _discussMessageStep2;
        }

        public IDiscussMessageStep2 Newline()
        {
            _text.Newline();
            return _discussMessageStep2;
        }

        public IDiscussMessageStep2 Image(string file)
        {
            _image.Image(file);
            return _discussMessageStep2;
        }

        public IDiscussMessageStep2 Face(string id)
        {
            _face.Face(id);
            return _discussMessageStep2;
        }

        public IDiscussMessageStep2 BFace(string id)
        {
            _bFace.BFace(id);
            return _discussMessageStep2;
        }

        public IDiscussMessageStep2 SFace(string id)
        {
            _sFace.SFace(id);
            return _discussMessageStep2;
        }

        public IDiscussMessageStep2 Emoji(string id)
        {
            _emoji.Emoji(id);
            return _discussMessageStep2;
        }

        public IDiscussMessageStep2 Record(string file)
        {
            _record.Record(file);
            return _discussMessageStep2;
        }

        public IDiscussMessageStep2 Record(string file, bool magic)
        {
            _record.Record(file, magic);
            return _discussMessageStep2;
        }
    }
}
