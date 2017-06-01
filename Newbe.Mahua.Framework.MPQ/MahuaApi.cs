using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newbe.Mahua.Framework.MPQ
{
    class MahuaApi : IMahuaApi
    {
        public void SendPrivateMsg(long qqId, string content)
        {
            throw new NotImplementedException();
        }

        string IMahuaApi.GetCookies()
        {
            throw new NotImplementedException();
        }

        int IMahuaApi.GetCsrfToken()
        {
            throw new NotImplementedException();
        }

        string IMahuaApi.GetGroupMemberInfo(long 群号, long qqid)
        {
            throw new NotImplementedException();
        }

        string IMahuaApi.GetLoginNick()
        {
            throw new NotImplementedException();
        }

        long IMahuaApi.GetLoginQq()
        {
            throw new NotImplementedException();
        }

        string IMahuaApi.GetRecord(string file, string outformat)
        {
            throw new NotImplementedException();
        }

        void IMahuaApi.SendDiscussMsg(long discussGroupNum, string msg)
        {
            throw new NotImplementedException();
        }

        void IMahuaApi.SendGroupMsg(long groupNum, string msg)
        {
            throw new NotImplementedException();
        }

        int IMahuaApi.SendLike(long qqid)
        {
            throw new NotImplementedException();
        }

        void IMahuaApi.SendPrivateMsg(long qqId, string content)
        {
            throw new NotImplementedException();
        }

        int IMahuaApi.SetDiscussLeave(long 讨论组号)
        {
            throw new NotImplementedException();
        }

        int IMahuaApi.SetFriendAddRequest(string 请求反馈标识, int 反馈类型, string 备注)
        {
            throw new NotImplementedException();
        }

        int IMahuaApi.SetGroupAddRequest(string 请求反馈标识, int 请求类型, int 反馈类型, string 理由)
        {
            throw new NotImplementedException();
        }

        int IMahuaApi.SetGroupAdmin(long 群号, long QQID, bool 成为管理员)
        {
            throw new NotImplementedException();
        }

        int IMahuaApi.SetGroupAnonymous(long 群号, bool 开启匿名)
        {
            throw new NotImplementedException();
        }

        int IMahuaApi.SetGroupAnonymousBan(long 群号, string 匿名, long 禁言时间)
        {
            throw new NotImplementedException();
        }

        int IMahuaApi.SetGroupBan(long 群号, long QQID, long 禁言时间)
        {
            throw new NotImplementedException();
        }

        int IMahuaApi.SetGroupCard(long 群号, long QQID, string 新名片_昵称)
        {
            throw new NotImplementedException();
        }

        int IMahuaApi.SetGroupKick(long 群号, long qqid, bool 拒绝再加群)
        {
            throw new NotImplementedException();
        }

        int IMahuaApi.SetGroupLeave(long 群号, bool 是否解散)
        {
            throw new NotImplementedException();
        }

        int IMahuaApi.SetGroupSpecialTitle(long 群号, long QQID, string 头衔, long 过期时间)
        {
            throw new NotImplementedException();
        }

        int IMahuaApi.SetGroupWholeBan(long 群号, bool 开启禁言)
        {
            throw new NotImplementedException();
        }
    }
}