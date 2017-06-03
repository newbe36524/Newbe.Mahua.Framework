# Newbe.Mahua.Framework

dev                                                                              | master
-------------------------------------------------------------------------------- | -----------------------------------------------------------------------------------
![build:](https://travis-ci.org/Newbe36524/Newbe.Mahua.Framework.svg?branch=dev) | ![build:](https://travis-ci.org/Newbe36524/Newbe.Mahua.Framework.svg?branch=master)

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
机器人平台 | Platform               | 酷Q、Amanda、MyPCQQ等等
插件    | Plugin                 |

## MahuaEvents 支持列表

事件                                                                  | CQP | MPQ
------------------------------------------------------------------- | --- | ---
[讨论组消息接受事件](#"IDiscussMessageReceivedMahuaEvent")                   | √   |
[已添加新好友事件](#"IFriendAddedMahuaEvent")                               | √   |
[好友申请接受事件](#"IFriendAddingRequestMahuaEvent")                       | √   |
[群管理员变更事件](#"IGroupAdminChangedMahuaEvent")                         | √   |
[解除群管理员事件](#"IGroupAdminDisabledMahuaEvent")                        | √   |
[任命新管理员事件](#"IGroupAdminEnabledMahuaEvent")                         | √   |
[入群邀请接收事件](#"IGroupJoiningInvitationReceivedMahuaEvent")            | √   |
[入群申请接收事件](#"IGroupJoiningRequestReceivedMahuaEvent")               | √   |
[群成员变更事件](#"IGroupMemberChangedMahuaEvent")                         | √   |
[群成员减少事件](#"IGroupMemberDecreasedMahuaEvent")                       | √   |
[群成员增多事件](#"IGroupMemberIncreasedMahuaEvent")                       | √   |
[群消息接收事件](#"IGroupMessageReceivedMahuaEvent")                       | √   |
[群文件上传事件](#"IGroupUploadedMahuaEvent")                              | √   |
[机器人平台退出事件](#"IPlatfromExitedMahuaEvent")                           | √   |
[插件被禁用事件](#"IPluginDisabledMahuaEvent")                             | √   |
[插件被启用事件](#"IPluginEnabledMahuaEvent")                              | √   |
[来自讨论组成员的私聊消息接收事件](#"IPrivateMessageFromDiscussReceivedMahuaEvent") | √   |
[来自好友的私聊消息接收事件](#"IPrivateMessageFromFriendReceivedMahuaEvent")     | √   |
[来自群成员的私聊消息接收事件](#"IPrivateMessageFromGroupReceivedMahuaEvent")     | √   |
[来自群成员的私聊消息接收事件](#"IPrivateMessageFromOnlineReceivedMahuaEvent")    | √   |
[来自群成员的私聊消息接收事件](#"IPrivateMessageReceivedMahuaEvent")              | √   |
