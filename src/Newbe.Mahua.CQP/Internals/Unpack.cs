using System;
using System.Linq;
using System.Text;

namespace Newbe.Mahua.CQP.Internals
{
    internal class Unpack
    {
        private readonly byte[] _source;
        private int _location;

        public Unpack(byte[] source)
        {
            _source = source;
            _location = 0;
        }

        public byte[] GetAll()
        {
            return _source.SubArray(_location, _source.Length - _location);
        }

        public byte[] GetBin(int len)
        {
            if (len <= 0)
            {
                return Enumerable.Empty<byte>().ToArray();
            }
            var bin = _source.SubArray(_location, len);
            _location += len;
            return bin;
        }

        public byte GetByte()
        {
            var bin = (byte)_source.SubArray(_location, 1).GetValue(0);
            _location += 1;
            return bin;
        }

        public int GetInt()
        {
            var bin = _source.SubArray(_location, 4);
            _location += 4;
            return bin.ToInt();
        }

        public long GetLong()
        {
            var bin = _source.SubArray(_location, 8);
            _location += 8;
            return bin.ToLong();
        }

        public short GetShort()
        {
            var bin = _source.SubArray(_location, 2);
            _location += 2;
            return bin.ToShort();
        }

        public string GetLenStr()
        {
            var len = GetShort();
            var bytes = GetBin(len);
            try
            {
                return Encoding.GetEncoding("GB2312").GetString(bytes);
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        public byte[] GetToken()
        {
            var len = GetShort();
            return GetBin(len);
        }

        public int Len()
        {
            return _source.Length - _location;
        }
    }
}
