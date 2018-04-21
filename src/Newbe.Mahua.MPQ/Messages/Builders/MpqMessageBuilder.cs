using Newbe.Mahua.Messages.Builders;
using System;

namespace Newbe.Mahua.MPQ.Messages.Builders
{
    /// <summary>
    /// .版本 2
    /// ' 以下是可以随处使用的动态变量:
    /// ' 对象昵称:  [name]=[昵称]=[nick]
    /// ' 群名:[gname]=[群名]
    /// ' 自己的昵称:[myname]
    /// ' 对象QQ:   [QQ]
    /// ' 换行: 直接换行 或 \n 或 \r 或 \x0D
    /// ' unicode字符转义发送:\u+UTF8编码HEX
    /// ' 时间段(早上、中午、傍晚、晚上、凌晨等):  [时间段]
    /// ' 随机数0~100:  [r]    可叠加使用 [r][r]=0~10000
    /// ' 自定义随机数:  r[范围1,范围2]  如 r[0,100]=随机0~100
    /// ' 分句标识:   [next]     如:早上好[next]吃过早饭了吗？ 将会分成两条信息分别发送 每条信息最多允许使用10个分句标识
    /// ' QQ默认小黄豆表情发送:  face+表情号.gif   或 [bq+表情号]   表情号为0~170共计171个表情（2014年8月28日为止  将来腾讯方面还会继续添加）
    /// ' 颜表情:[em+颜表情号] 详细见：mypcqq emoji代码.jpg 和 mypcqq表情代码.png
    /// ' 群内@人：  [@+对象QQ号] 如:[@445491251]
    /// ' 群内@全体:   [@all] 要求为管理员
    /// ' 图片回复:  直接使用如同{CC10C739-C125-06BD-496C-7DBCE02BB9BB}.jpg 这样的图片GUID发送
    /// ' 图片上传：通直接发送 [网页连接] 或 [本地图片路径]上传 但  [本地图片路径]仅限于运行目录以及其子目录下  或过Api_UploadPic提交数据上传
    /// ' 自定义单条信息字体:  在信息中加上 字体[颜色=颜色值,大小=50]即可  如:字体颜色测试  字体[颜色=255,大小=13]
    /// ' 自定义气泡:[气泡+ID] 自定义本条信息气泡 可于任意位置插入如:测试[气泡234]  可以无差别使用任何气泡 已知ID 0~328不断增加中(截止2015年11月12日)
    /// ' 更多的动态标记还在不断添加中.
    ///
    /// ' MyPCQQ模版 修改于 2015年11月12日
    /// </summary>
    public class MpqMessageBuilder :
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
        private readonly IMpqMessage _mpqMessage;

        public MpqMessageBuilder(
            IMpqMessage mpqMessage)
        {
            _mpqMessage = mpqMessage;
        }

        public void At(string qq)
        {
            _mpqMessage.Append($"[@{qq}]");
        }

        public void AtlAll()
        {
            _mpqMessage.Append("[@all]");
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
            _mpqMessage.Append($"[em{id}]");
        }

        public void Face(string id)
        {
            _mpqMessage.Append($"[bq{id}]");
        }

        /// <summary>
        /// {1}为图片文件名称，图片存放在酷Q目录的data\image\下
        /// </summary>
        /// <param name="file"></param>
        public void Image(string file)
        {
            var id = _mpqMessage.Images.Add(file);
            _mpqMessage.Append(id);
        }

        public void Record(string file)
        {
            MahuaGlobal.NotSupportedMessageBuilderConvertion.Handle<IRecord>();
        }

        public void SFace(string id)
        {
            MahuaGlobal.NotSupportedMessageBuilderConvertion.Handle<ISFace>();
        }

        public void Shake()
        {
            _mpqMessage.Shake = true;
        }

        public void Text(string text)
        {
            _mpqMessage.Append(text);
        }

        public void Newline()
        {
            _mpqMessage.Append(Environment.NewLine);
        }
    }
}
