using Newbe.Mahua.Messages;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Newbe.Mahua.MPQ.Messages
{
    public interface IMpqMessage : IMessage
    {
        bool Shake { get; set; }

        ImageCollection Images { get; }
    }

    public class ImageCollection : IEnumerable<KeyValuePair<string, string>>
    {
        private IDictionary<string, string> _images = new Dictionary<string, string>();

        public string Add(string file)
        {
            var id = GetId(_images.Count);
            _images.Add(id, file);
            return id;
        }
        public void Upload(Func<string, string> uploader)
        {
            var currentDic = AppDomain.CurrentDomain.BaseDirectory;
            _images = _images.ToDictionary(x => x.Key,
                image =>
                {
                    var file = image.Value;
                    if (file.StartsWith("http") || file.StartsWith(currentDic))
                    {
                        return $"[{image.Value}]";
                    }
                    var re = uploader(file);
                    return re;
                });
        }

        public string Formate(string source)
        {
            var re = source;
            foreach (var image in _images)
            {
                re = re.Replace(image.Key, image.Value);
            }
            return re;
        }

        private string GetId(int index) => $"[mpqImage_{index}]";
        public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
        {
            return _images.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
