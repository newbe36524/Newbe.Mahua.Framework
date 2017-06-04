# Newbe.Mahua.Framework

dev                                                                                                                                                                              | master
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
[![Build status](https://ci.appveyor.com/api/projects/status/9m8guue6ukpn01pa/branch/dev?svg=true)](https://ci.appveyor.com/project/Newbe36524/newbe-mahua-framework/branch/dev) | [![Build status](https://ci.appveyor.com/api/projects/status/9m8guue6ukpn01pa/branch/master?svg=true)](https://ci.appveyor.com/project/Newbe36524/newbe-mahua-framework/branch/master)

## 你打麻花，谁疼？麻花疼。

本SDK为实现QQ机器人平台的大一统，全新实现支持以下高级特性：

- 支持多种机器人平台：酷Q、MyPCQQ、Amanda等
- 支持Framework452
- 支持依赖注入

你只要基于SDK的接口开发一次，便可以将你的插件发布到所有支持的QQ机器人平台。

[点击此处，加入QQ群一起讨论吧](http://shang.qq.com/wpa/qunwpa?idkey=62199995e33f098e64625f54d213a3e00ed0fb01f71d839a11e7186a92b03fa6)

## 名词表

中文    | 英文                     | 说明
----- | ---------------------- | ------------------
QQ    | QQ                     |
群     | Group                  |
群成员   | GroupMember            |
讨论组   | Discuss                |
好友    | Friend                 |
好友申请  | FriendAddingRequest    |
入群申请  | GroupJoiningRequest    |
加群邀请  | GroupJoiningInvitation |
私聊消息  | PrivateMessage         |
群消息   | GroupMessage           |
讨论组消息 | DiscussMessage         |
禁言    | Ban                    |
机器人平台 | Platform               | 酷Q、Amanda、MyPCQQ等等
插件    | Plugin                 |

## MahuaEvent支持列表

事件                                           | 说明               | CQP | MPQ | Amanda
-------------------------------------------- | ---------------- | --- | --- | ------
IDiscussMessageReceivedMahuaEvent            | 讨论组消息接受事件        | √   |     |
IFriendAddedMahuaEvent                       | 已添加新好友事件         | √   |     |
IFriendAddingRequestMahuaEvent               | 好友申请接受事件         | √   |     |
IGroupAdminChangedMahuaEvent                 | 群管理员变更事件         | √   |     |
IGroupAdminDisabledMahuaEvent                | 解除群管理员事件         | √   |     |
IGroupAdminEnabledMahuaEvent                 | 任命新管理员事件         | √   |     |
IGroupJoiningInvitationReceivedMahuaEvent    | 入群邀请接收事件         | √   |     |
IGroupJoiningRequestReceivedMahuaEvent       | 入群申请接收事件         | √   |     |
IGroupMemberChangedMahuaEvent                | 群成员变更事件          | √   |     |
IGroupMemberDecreasedMahuaEvent              | 群成员减少事件          | √   |     |
IGroupMemberIncreasedMahuaEvent              | 群成员增多事件          | √   |     |
IGroupMessageReceivedMahuaEvent              | 群消息接收事件          | √   |     |
IGroupUploadedMahuaEvent                     | 群文件上传事件          | √   |     |
IPlatfromExitedMahuaEvent                    | 机器人平台退出事件        | √   |     |
IPluginDisabledMahuaEvent                    | 插件被禁用事件          | √   |     |
IPluginEnabledMahuaEvent                     | 插件被启用事件          | √   |     |
IPrivateMessageFromDiscussReceivedMahuaEvent | 来自讨论组成员的私聊消息接收事件 | √   |     |
IPrivateMessageFromFriendReceivedMahuaEvent  | 来自好友的私聊消息接收事件    | √   |     |
IPrivateMessageFromGroupReceivedMahuaEvent   | 来自群成员的私聊消息接收事件   | √   |     |
IPrivateMessageFromOnlineReceivedMahuaEvent  | 来自在线状态的私聊消息接收事件  | √   |     |
IPrivateMessageReceivedMahuaEvent            | 私聊消息接收事件         | √   |     |

## MahuaApi支持列表

Api                          | 说明             | CQP | MPQ | Amanda
---------------------------- | -------------- | --- | --- | ------
AcceptFriendAddingRequest    | 同意添加好友请求       | √   | √   | √
AcceptGroupJoiningInvitation | 接受入群邀请         | √   | √   | √
AcceptGroupJoiningRequest    | 管理员同意入群申请      | √   | √   | √
BanFriend                    | 将QQ移入黑名单       |     | √   | √
BanGroupAnonymousMember      | 设置禁言某匿名群员      | √   | √   | √
BanGroupMember               | 禁言某群成员         | √   | √   | √
CreateDiscuss                | 创建讨论组          |     | √   | √
DisableGroupAdmin            | 删除群管理员         | √   | √   | √
DissolveGroup                | 解散群            | √   | √   | √
EnableGroupAdmin             | 设置群管理员         | √   | √   | √
GetCookies                   | 取Cookies       | √   | √   | √
GetCsrfToken                 | 取CsrfToken，bkn | √   | √   | √
GetDiscusses                 | 获取讨论组列表        |     | √   | √
GetFriends                   | 获取好友列表         |     | √   | √
GetGroupMemebers             | 获取群成员列表        |     | √   | √
GetGroups                    | 获取群列表          |     | √   | √
GetLoginNick                 | 取当前登录QQ昵称      | √   | √   | √
GetLoginQq                   | 取当前登录QQ        | √   | √   | √
GetNotices                   | 获取群公告          |     | √   | √
GetRecord                    | 接收语音           | √   | √   | √
JoinGroup                    | 主动加群           |     | √   | √
KickDiscussMember            | 踢出讨论组          |     | √   | √
KickGroupMember              | 移出群成员          | √   | √   | √
LeaveDiscuss                 | 退出讨论组          | √   | √   | √
LeaveGroup                   | 退出群            | √   | √   | √
RejectFriendAddingRequest    | 拒绝添加好友请求       | √   | √   | √
RejectGroupJoiningInvitation | 拒绝入群邀请         | √   | √   | √
RejectGroupJoiningRequest    | 管理员拒绝入群申请      | √   | √   | √
RemoveBanFriend              | 将QQ移出黑名单       |     | √   | √
RemoveBanGroupMember         | 取消禁言某群成员       | √   | √   | √
RemoveFriend                 | 删除好友           |     | √   | √
SendDiscussJoiningInvitation | 发送讨论组邀请        |     | √   | √
SendDiscussMessage           | 发送讨论组消息        | √   | √   | √
SendGroupJoiningInvitation   | 发送入群邀请         |     | √   | √
SendGroupMessage             | 发送群消息          | √   | √   | √
SendLike                     | 发送名片赞          | √   | √   | √
SendPrivateMessage           | 发送私聊消息         | √   | √   | √
SetBanAllGroupMembersOption  | 设置全群禁言         | √   | √   | √
SetGroupAnonymousOption      | 设置群匿名设置        | √   | √   | √
SetGroupMemberCard           | 设置群成员名片        | √   | √   | √
SetGroupMemberSpecialTitle   | 设置群成员专属头衔      | √   | √   | √
SetNotice                    | 发布群公告          |     | √   | √
