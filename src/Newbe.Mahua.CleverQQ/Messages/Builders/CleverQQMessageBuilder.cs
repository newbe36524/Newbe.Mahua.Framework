using Newbe.Mahua.Messages.Builders;
using System;

namespace Newbe.Mahua.CleverQQ.Messages.Builders
{
    /// <summary>
    /// 对象昵称：[ObjName]    应确保发送消息中包含IRC_触发对象_主动
    /// 对象QQ：[ObjQQ]        对象QQ号码
    /// 对象头像：[DisPic]     触发对象的头像
    /// 时间：[Time]           表示当前时间，例：2017年1月1日18时00分00秒
    /// 数字时间：[NumTime]    取时分两位数字时间，例：18:00
    /// 时间段：[TimePer]      例：凌晨、黎明、早上、中午、下午、傍晚、晚上
    /// 换行符：[\n]           换行
    /// 星期：[Week]           表示当前日期星期几
    /// 群名：[GName]          当前消息来源群名
    /// 群号：[GNum]           当前消息来源群号
    /// 机器人昵称：[RName]    机器人的昵称
    /// 机器人QQ：[RQQ]        机器人号码
    /// 农历：[LunC]           例如：五月初五
    /// 随机数：[1,300]        快速取随机数
    /// 随机Face表情：[RFace]  QQ小黄豆表情
    /// 信息分段发送：[Next]    将一条消息分作两次发送
    /// 艾特全体：[IR:at=all]   艾特全体成员，当然必须是管理员
    /// 艾特码： 艾特全群：[IR:at=全体人员]
    /// 艾特个人：[IR:at=QQ] 如：[IR:at=123456]
    /// 表情码： [FaceX.gif]（将X替换为1-213）‘此处应注意大小写
    /// 表情代码详情请见http://doc.irqq.me/，如：[Face1.gif]
    /// 颜表情：[emoji=表情代码]   具体代码请发送颜表情给机器人查看
    /// 图片发送：[IR:pic=图片路径或地址]   或者 直接发送框架收到的图片GUID
    /// 图片发送也可用GUID：[IR:pic={xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx}.jpg]  这样的格式
    /// 秀图发送[IR:ShowPic=图片路径或地址,type=秀图特效]  秀图特效可参考常量，或 0 1 2 3 4 5 代替    （Pro可用）
    /// 秀图发送也可用GUID：[IR:ShowPic={xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx}.jpg,type=秀图特效]   这样的格式    （Pro可用）
    /// 闪照发送：[IR:FlashPic=图片路径或地址]  或者 直接发送框架收到的闪照GUID   （Pro可用）
    /// 闪照发送也可用GUID：[IR:FlashPic={xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx}.jpg] 这样的格式    （Pro可用）
    /// 语音发送：[IR:Voi={xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx}.amr]
    /// </summary>
    public class CleverQQMessageBuilder :
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
        private readonly ICleverQQMessage _cleverqqMessage;

        public CleverQQMessageBuilder(
            ICleverQQMessage cleverqqMessage)
        {
            _cleverqqMessage = cleverqqMessage;
        }

        public void At(string qq)
        {
            _cleverqqMessage.Append($"[IR:at={qq}]");
        }

        public void AtlAll()
        {
            _cleverqqMessage.Append("[IR:at=all]");
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
            _cleverqqMessage.Append($"[emoji={id}]");
        }

        public void Face(string id)
        {
            _cleverqqMessage.Append($"[Face{id}.gif]");
        }

        /// <summary>
        /// {1}为图片文件名称，可以是腾讯直接返回的GUID或本地文件
        /// </summary>
        /// <param name="file"></param>
        public void Image(string file)
        {
            var id = _cleverqqMessage.Images.Add(file);
            var imgStr = $"[IR:pic={id}]";
            _cleverqqMessage.Append(imgStr);
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
            _cleverqqMessage.Shake = true;
        }

        public void Text(string text)
        {
            _cleverqqMessage.Append(text);
        }

        public void Newline()
        {
            _cleverqqMessage.Append(Environment.NewLine);
        }
    }
}
