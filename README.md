# Newbe.Mahua.Framework

先点击一下右上角的Star，开启隐藏功能。

[![GitHub last commit](https://img.shields.io/github/last-commit/Newbe36524/Newbe.Mahua.Framework.svg?style=flat-square)]()
[![All Contributors](https://img.shields.io/badge/all_contributors-9-orange.svg?style=flat-square)](#contributors)

## 入坑提示

建议开发者先根据自身需求结合表格，选择属于自己的专属开发框架，避免浪费时间。

1. 编写一套代码就能在多个平台运行
2. 支持使用除了C#之外的开发语言来开发
3. 我希望他足够简单，不用学习太多就能掌握，通常只需要半个小时就能掌握所有内容
4. 我希望社区的反馈足够快，有问题都可以帮我解决

| SDK名称                                                                     | （1） | （2） | （3） | （4） |
| --------------------------------------------------------------------------- | ----- | ----- | ----- | ----- |
| 论坛中的其他SDK                                                             | ✔     | ✔     | ✔     | ✔     |
| [Jie2GG.Native.Csharp.Frame](https://github.com/Jie2GG/Native.Csharp.Frame) | ✔     | ✘     | ✔     | ✔     |
| [Newbe.Mahua V2](https://github.com/newbe36524/Newbe.Mahua.Framework/)      | ✔     | ✔     | ✘     | ✘     |
| [Newbe.Mahua V1](https://github.com/newbe36524/Newbe.Mahua.Framework.V1)    | ✔     | ✘     | ✘     | ✘     |

### 论坛其他SDK的链接

- [CQP](https://d.oo14.com/b7oy?target=cqp)         
- [MPQ](https://d.oo14.com/b7oy?target=mpq)         
- [QQLight](https://d.oo14.com/b7oy?target=qqlight) 

## 开篇一张图，功能全靠编

![Newbe.Mahua.Version](i/体系结构.png)

[![FOSSA Status](https://app.fossa.io/api/projects/git%2Bgithub.com%2Fnewbe36524%2FNewbe.Mahua.Framework.svg?type=shield)](https://app.fossa.io/projects/git%2Bgithub.com%2Fnewbe36524%2FNewbe.Mahua.Framework?ref=badge_shield)

## 你打麻花，谁疼？麻花疼。

QQ协议实现也有不少，QQ机器人平台有不少，这些平台大多具有不同的接口，对接开发存在巨大困难。

使用该SDK开发可以实现一次开发，运行于多个不同平台的绝佳体验。

SDK提供多种可用的跨进程通信方案，开发者可以从中灵活选择自己适用的开发语言进行对接。

你只要基于SDK的接口开发一次，便可以将你的插件发布到所有支持的QQ机器人平台。

不用担心某个平台被咔嚓。

## 支持跨进程通行方案

| 名称      | 调用 | 回调 | 说明                                                |
| --------- | ---- | ---- | --------------------------------------------------- |
| HTTP      | ✔    | ✔    | http 的方式进行通信                                 |
| Websocket | ✔    | ✔    | websocket 双工通信方案，由客户程序连接到Newbe.Mahua |

调用：是指开发者的进程调用 Newbe.Mahua 的接口。

回调：是指 Newbe.Mahua 调用 开发者的进程的接口。

[如果开发者有新的通信方案希望支持，不妨告知我们](https://github.com/newbe36524/Newbe.Mahua.Framework/issues/new/choose)

## 支持的平台

- [CQP](https://d.oo14.com/b7oy?target=cqp)         
- [MPQ](https://d.oo14.com/b7oy?target=mpq)         
- [QQLight](https://d.oo14.com/b7oy?target=qqlight) 

## 立马开始

[点击查看帮助文档](https://d.oo14.com/08ZI?v=v2) 开始编写第一个QQ机器人。

### 快乐实践

[我想将我的项目加在此处](https://github.com/newbe36524/Newbe.Mahua.Framework/issues/new/choose)

#### [Python QQBot](https://github.com/892768447/QQBot)

使用 Python 对接 Newbe.Mahua.Plugin.Agent插件实现各大机器人平台的Http接口功能，对接QQBot Web Server服务端实现统一各大机器人平台收发数据

## 版本

| 包                         | 版本                                                                                                                                                                                 | 下载量                                                                                                                                                                                 | 开发版                                                                                                                                                                                      | 说明                         |
| -------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------- |
| Newbe.Mahua.CQP.Asset      | [![Newbe.Mahua.CQP.Asset.Version](https://img.shields.io/nuget/v/Newbe.Mahua.CQP.Asset.svg?style=flat-square)](https://www.nuget.org/packages/Newbe.Mahua.CQP.Asset/)                | [![Newbe.Mahua.CQP.Asset.Download](https://img.shields.io/nuget/dt/Newbe.Mahua.CQP.Asset.svg?style=flat-square)](https://www.nuget.org/packages/Newbe.Mahua.CQP.Asset/)                | [![Newbe.Mahua.CQP.Asset.Version.Pre](https://img.shields.io/nuget/vpre/Newbe.Mahua.CQP.Asset.svg?style=flat-square)](https://www.nuget.org/packages/Newbe.Mahua.CQP.Asset/)                | CQP（酷Q）实现               |
| Newbe.Mahua.QQLight.Asset  | [![Newbe.Mahua.QQLight.Asset.Version](https://img.shields.io/nuget/v/Newbe.Mahua.QQLight.Asset.svg?style=flat-square)](https://www.nuget.org/packages/Newbe.Mahua.QQLight.Asset/)    | [![Newbe.Mahua.QQLight.Asset.Download](https://img.shields.io/nuget/dt/Newbe.Mahua.QQLight.Asset.svg?style=flat-square)](https://www.nuget.org/packages/Newbe.Mahua.QQLight.Asset/)    | [![Newbe.Mahua.QQLight.Asset.Version.Pre](https://img.shields.io/nuget/vpre/Newbe.Mahua.QQLight.Asset.svg?style=flat-square)](https://www.nuget.org/packages/Newbe.Mahua.QQLight.Asset/)    | QQLight实现                  |
| Newbe.Mahua.MPQ.Asset      | [![Newbe.Mahua.MPQ.Asset.Version](https://img.shields.io/nuget/v/Newbe.Mahua.MPQ.Asset.svg?style=flat-square)](https://www.nuget.org/packages/Newbe.Mahua.MPQ.Asset/)                | [![Newbe.Mahua.MPQ.Asset.Download](https://img.shields.io/nuget/dt/Newbe.Mahua.MPQ.Asset.svg?style=flat-square)](https://www.nuget.org/packages/Newbe.Mahua.MPQ.Asset/)                | [![Newbe.Mahua.MPQ.Asset.Version.Pre](https://img.shields.io/nuget/vpre/Newbe.Mahua.MPQ.Asset.svg?style=flat-square)](https://www.nuget.org/packages/Newbe.Mahua.MPQ.Asset/)                | MPQ（MyPcQQ）实现            |
| Newbe.Mahua.CleverQQ.Asset | [![Newbe.Mahua.CleverQQ.Asset.Version](https://img.shields.io/nuget/v/Newbe.Mahua.CleverQQ.Asset.svg?style=flat-square)](https://www.nuget.org/packages/Newbe.Mahua.CleverQQ.Asset/) | [![Newbe.Mahua.CleverQQ.Asset.Download](https://img.shields.io/nuget/dt/Newbe.Mahua.CleverQQ.Asset.svg?style=flat-square)](https://www.nuget.org/packages/Newbe.Mahua.CleverQQ.Asset/) | [![Newbe.Mahua.CleverQQ.Asset.Version.Pre](https://img.shields.io/nuget/vpre/Newbe.Mahua.CleverQQ.Asset.svg?style=flat-square)](https://www.nuget.org/packages/Newbe.Mahua.CleverQQ.Asset/) | CleverQQ实现（已经停止维护） |

## Contributors

Thanks goes to these wonderful people ([emoji key](https://github.com/kentcdodds/all-contributors#emoji-key)):

<!-- ALL-CONTRIBUTORS-LIST:START - Do not remove or modify this section -->
<!-- prettier-ignore -->
<table>
  <tr>
    <td align="center"><a href="http://www.newbe.pro"><img src="https://avatars1.githubusercontent.com/u/7685462?v=4" width="100px;" alt="Newbe36524"/><br /><sub><b>Newbe36524</b></sub></a><br /><a href="https://github.com/newbe36524/Newbe.Mahua.Framework/commits?author=newbe36524" title="Documentation">📖</a> <a href="https://github.com/newbe36524/Newbe.Mahua.Framework/commits?author=newbe36524" title="Code">💻</a> <a href="#tool-newbe36524" title="Tools">🔧</a> <a href="#blog-newbe36524" title="Blogposts">📝</a> <a href="#example-newbe36524" title="Examples">💡</a></td>
    <td align="center"><a href="https://traceless.site/"><img src="https://avatars1.githubusercontent.com/u/12078678?v=4" width="100px;" alt="Traceless"/><br /><sub><b>Traceless</b></sub></a><br /><a href="https://github.com/newbe36524/Newbe.Mahua.Framework/commits?author=traceless0929" title="Code">💻</a> <a href="https://github.com/newbe36524/Newbe.Mahua.Framework/issues?q=author%3Atraceless0929" title="Bug reports">🐛</a></td>
    <td align="center"><a href="https://github.com/kotoneme"><img src="https://avatars1.githubusercontent.com/u/43395785?v=4" width="100px;" alt="kotoneme"/><br /><sub><b>kotoneme</b></sub></a><br /><a href="https://github.com/newbe36524/Newbe.Mahua.Framework/commits?author=kotoneme" title="Code">💻</a></td>
    <td align="center"><a href="https://github.com/allenxie888"><img src="https://avatars1.githubusercontent.com/u/7455309?v=4" width="100px;" alt="AllenXie"/><br /><sub><b>AllenXie</b></sub></a><br /><a href="https://github.com/newbe36524/Newbe.Mahua.Framework/commits?author=allenxie888" title="Code">💻</a></td>
    <td align="center"><a href="https://github.com/bgli100"><img src="https://avatars1.githubusercontent.com/u/7760499?v=4" width="100px;" alt="bgli100"/><br /><sub><b>bgli100</b></sub></a><br /><a href="https://github.com/newbe36524/Newbe.Mahua.Framework/commits?author=bgli100" title="Code">💻</a> <a href="https://github.com/newbe36524/Newbe.Mahua.Framework/issues?q=author%3Abgli100" title="Bug reports">🐛</a></td>
    <td align="center"><a href="https://github.com/newce36524"><img src="https://avatars1.githubusercontent.com/u/20368567?v=4" width="100px;" alt="Q-Q"/><br /><sub><b>Q-Q</b></sub></a><br /><a href="https://github.com/newbe36524/Newbe.Mahua.Framework/commits?author=newce36524" title="Code">💻</a> <a href="https://github.com/newbe36524/Newbe.Mahua.Framework/issues?q=author%3Anewce36524" title="Bug reports">🐛</a></td>
    <td align="center"><a href="https://github.com/LollipopGeneral"><img src="https://avatars1.githubusercontent.com/u/45588935?v=4" width="100px;" alt="LollipopGeneral"/><br /><sub><b>LollipopGeneral</b></sub></a><br /><a href="https://github.com/newbe36524/Newbe.Mahua.Framework/commits?author=LollipopGeneral" title="Code">💻</a></td>
  </tr>
  <tr>
    <td align="center"><a href="http://www.nbyang.com"><img src="https://avatars1.githubusercontent.com/u/1086084?v=4" width="100px;" alt="nbyang"/><br /><sub><b>nbyang</b></sub></a><br /><a href="https://github.com/newbe36524/Newbe.Mahua.Framework/issues?q=author%3Aiomect" title="Bug reports">🐛</a></td>
    <td align="center"><a href="http://www.r4v3zn.com"><img src="https://avatars2.githubusercontent.com/u/18393907?v=4" width="100px;" alt="r4v3zn"/><br /><sub><b>r4v3zn</b></sub></a><br /><a href="#example-0nise" title="Examples">💡</a></td>
  </tr>
</table>

<!-- ALL-CONTRIBUTORS-LIST:END -->

This project follows the [all-contributors](https://github.com/kentcdodds/all-contributors) specification. Contributions of any kind welcome!

## 说在最后面

开发本SDK的目的是为了促进.Net技术的交流学习。

由本SDK衍生的任何产品均与本SDK无关！

由本SDK支持的QQ自动化管理助手平台均与本SDK无关！

禁止用于国家或地区法律法规所禁止的范围！

**最后，但是最重要的，一定要Star一下！**

[借一步说话](http://www.newbe.pro/donate/)

特别感谢 Jetbrain 公司提供的 License 以支持该项目

[![jetbrains](i/jetbrains-variant-3.png)](https://www.jetbrains.com/?from=Newbe.Mahua.Framework)

## License
[![FOSSA Status](https://app.fossa.io/api/projects/git%2Bgithub.com%2Fnewbe36524%2FNewbe.Mahua.Framework.svg?type=large)](https://app.fossa.io/projects/git%2Bgithub.com%2Fnewbe36524%2FNewbe.Mahua.Framework?ref=badge_large)
