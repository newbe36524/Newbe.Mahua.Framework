# 版本变更情况

变更情况只记录主版本和次版本变化。版本号严格按照以下情况进行变更：

- 当版本出现了与上一版本不兼容的情况，将变更主版本号
- 当版本兼容上一版本，将变更次版本号

兼容，即升级不需要变更任何代码便可以编译通过。

兼容，也要求`Newbe.Mahua`和对应的`Newbe.Mahua.xxx`需要具备相同的主版本和次版本，否则也是不兼容的。

对于修订号的变更此列表将不会记录，直接升级没有影响。

## 1.13

增加消息撤回支持

详细内容：<http://www.newbe.pro/docs/mahua/releasenodes/2018/10/02/Release-Notes-1-13-0.html>

## 1.12

1. 添加 QQLight、CleverQQ 支持，移除 Amanda 支持
2. 公开各平台私有API

详细内容：<http://www.newbe.pro/docs/mahua/releasenodes/2018/09/16/Release-Notes-1-12-0.html>

## 1.11

重新调整nuget包结构。支持插件热更新。

详细内容：<http://www.newbe.pro/docs/mahua/releasenodes/2018/08/02/Release-Notes-1-11-0.html>

## 1.10

升级 Amanda SDK ，适应最新版本。

增加 Log4View 日志输出方式，日志可见容易查看。

详细内容：<http://www.newbe.pro/docs/mahua/releasenodes/2018/06/24/Release-Notes-1-10-0.html>

## 1.9

增加 MahuaRobotManager 和 RobotSession 机制，支持在 MahuaEvent 之外调用机器人API。

详细内容：<http://www.newbe.pro/docs/mahua/releasenodes/2018/06/10/Release-Notes-1-9-0.html>

## 1.8

增加了"消息发送Fluent API"，发送消息接口更加方便。

详细内容：<http://www.newbe.pro/docs/mahua/releasenodes/2018/04/21/Release-Notes-1-8-0.html>

## 1.7

可以在插件中追加MahuaApi的实现。

支持在构建时对CQP的JSON文件进行修改。

详细内容：<http://www.newbe.pro/docs/mahua/releasenodes/2018/01/07/Release-Notes-1-7-0.html>

## 1.6

此次版本发布主要围绕"开发便利性提升"特性。可调试行、可追踪性都有进一步提升。

详细内容：<http://www.newbe.pro/docs/mahua/releasenodes/2017/12/30/Release-Notes-1-6-0.html>

## 1.5

新增`设置中心`。

既可以通过扩展菜单，实现对设置中心的扩展，也可以直接实现接口，重做`设置中心`UI。

实现多平台统一配置界面的目的。

## 1.4

新增MPQ（MyPCQQ）实现，是本SDK支持的第一个支持多开QQ的机器人平台。

至此，本SDK已经能够支持CQP、Amanda和MPQ三个平台。

增加了VS插件支持，插件下载地址：<https://marketplace.visualstudio.com/items?itemName=Newbe36524.NewbeMahuaVsExtensions#overview>

## 1.3

使用MessagePack替代JSON序列化，消息处理速度明显提升。

## 1.2

全新的打包机制：[Newbe.Mahua.Tools.Psake](https://www.nuget.org/packages/Newbe.Mahua.Tools.Psake/)

被废弃的打包机制：Newbe.Mahua.Msbuild [新版快速指南](http://www.newbe.cf/docs/mahua/2017/10/26/Begin-First-Plugin-With-Mahua-In-v1.2.html)

## 1.1

[#12](https://github.com/Newbe36524/Newbe.Mahua.Framework/issues/12) 提供对群列表、群成员列表的结构化接口支持

`IMahuaApi`新增方法:`GetGroupMemebersWithModel`,`GetGroupsWithModel`

## 1.0

主框架发布，支持CQP和Amanda机器人平台。
