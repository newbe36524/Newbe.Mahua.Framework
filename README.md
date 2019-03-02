# Newbe.Mahua.Framework

先点击一下右上角的Star，开启隐藏功能。

[![](https://img.shields.io/appveyor/tests/Newbe36524/newbe-mahua-framework.svg?style=flat-square)](https://ci.appveyor.com/project/Newbe36524/newbe-mahua-framework) [![](https://img.shields.io/appveyor/ci/Newbe36524/newbe-mahua-framework.svg?style=flat-square)](https://ci.appveyor.com/project/Newbe36524/newbe-mahua-framework) [![GitHub last commit](https://img.shields.io/github/last-commit/Newbe36524/Newbe.Mahua.Framework.svg?style=flat-square)]()
[![All Contributors](https://img.shields.io/badge/all_contributors-7-orange.svg?style=flat-square)](#contributors)

## 开篇一张图，功能全靠编

![Newbe.Mahua.Version](i/体系结构.png)

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

| 名称     | 地址                                       |
| -------- | ------------------------------------------ |
| CQP      | <https://cqp.cc/>                          |
| MPQ      | <https://f.mypcqq.cc/thread-2327-1-1.html> |
| CleverQQ | <https://d.cleverqq.cn/forum.php>          |
| QQLight  | <http://www.52chat.cc/>                    |

## 立马开始

[点击查看帮助文档](http://www.newbe.pro) 开始编写第一个QQ机器人。

## 版本

- [版本变更情况](https://github.com/Newbe36524/Newbe.Mahua.Framework/blob/master/ReleaseNotes.md)

| 包                         | 版本                                                                                                                                                                                 | 下载量                                                                                                                                                                                 | 开发版                                                                                                                                                                                      | 说明              |
| -------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------- |
| Newbe.Mahua.CQP.Asset      | [![Newbe.Mahua.CQP.Asset.Version](https://img.shields.io/nuget/v/Newbe.Mahua.CQP.Asset.svg?style=flat-square)](https://www.nuget.org/packages/Newbe.Mahua.CQP.Asset/)                | [![Newbe.Mahua.CQP.Asset.Download](https://img.shields.io/nuget/dt/Newbe.Mahua.CQP.Asset.svg?style=flat-square)](https://www.nuget.org/packages/Newbe.Mahua.CQP.Asset/)                | [![Newbe.Mahua.CQP.Asset.Version.Pre](https://img.shields.io/nuget/vpre/Newbe.Mahua.CQP.Asset.svg?style=flat-square)](https://www.nuget.org/packages/Newbe.Mahua.CQP.Asset/)                | CQP（酷Q）实现    |
| Newbe.Mahua.QQLight.Asset  | [![Newbe.Mahua.QQLight.Asset.Version](https://img.shields.io/nuget/v/Newbe.Mahua.QQLight.Asset.svg?style=flat-square)](https://www.nuget.org/packages/Newbe.Mahua.QQLight.Asset/)    | [![Newbe.Mahua.QQLight.Asset.Download](https://img.shields.io/nuget/dt/Newbe.Mahua.QQLight.Asset.svg?style=flat-square)](https://www.nuget.org/packages/Newbe.Mahua.QQLight.Asset/)    | [![Newbe.Mahua.QQLight.Asset.Version.Pre](https://img.shields.io/nuget/vpre/Newbe.Mahua.QQLight.Asset.svg?style=flat-square)](https://www.nuget.org/packages/Newbe.Mahua.QQLight.Asset/)    | QQLight实现       |
| Newbe.Mahua.CleverQQ.Asset | [![Newbe.Mahua.CleverQQ.Asset.Version](https://img.shields.io/nuget/v/Newbe.Mahua.CleverQQ.Asset.svg?style=flat-square)](https://www.nuget.org/packages/Newbe.Mahua.CleverQQ.Asset/) | [![Newbe.Mahua.CleverQQ.Asset.Download](https://img.shields.io/nuget/dt/Newbe.Mahua.CleverQQ.Asset.svg?style=flat-square)](https://www.nuget.org/packages/Newbe.Mahua.CleverQQ.Asset/) | [![Newbe.Mahua.CleverQQ.Asset.Version.Pre](https://img.shields.io/nuget/vpre/Newbe.Mahua.CleverQQ.Asset.svg?style=flat-square)](https://www.nuget.org/packages/Newbe.Mahua.CleverQQ.Asset/) | CleverQQ实现      |
| Newbe.Mahua.MPQ.Asset      | [![Newbe.Mahua.MPQ.Asset.Version](https://img.shields.io/nuget/v/Newbe.Mahua.MPQ.Asset.svg?style=flat-square)](https://www.nuget.org/packages/Newbe.Mahua.MPQ.Asset/)                | [![Newbe.Mahua.MPQ.Asset.Download](https://img.shields.io/nuget/dt/Newbe.Mahua.MPQ.Asset.svg?style=flat-square)](https://www.nuget.org/packages/Newbe.Mahua.MPQ.Asset/)                | [![Newbe.Mahua.MPQ.Asset.Version.Pre](https://img.shields.io/nuget/vpre/Newbe.Mahua.MPQ.Asset.svg?style=flat-square)](https://www.nuget.org/packages/Newbe.Mahua.MPQ.Asset/)                | MPQ（MyPcQQ）实现 |

## 相关技术

- <https://github.com/3F/DllExport>
- <https://github.com/autofac/Autofac>
- <https://gitee.com/yks/Newbe.Common>
- <https://www.sonarlint.org/visualstudio/>
- <https://github.com/xunit/xunit>
- <http://www.fluentassertions.com/>
- <https://github.com/ctaggart/SourceLink>
- <https://github.com/aspnet/AspNetCore>

## Contributors

Thanks goes to these wonderful people ([emoji key](https://github.com/kentcdodds/all-contributors#emoji-key)):

<!-- ALL-CONTRIBUTORS-LIST:START - Do not remove or modify this section -->
<!-- prettier-ignore -->
| [<img src="https://avatars1.githubusercontent.com/u/7685462?v=4" width="100px;"/><br /><sub><b>Newbe36524</b></sub>](http://www.newbe.pro)<br />[📖](https://github.com/newbe36524/Newbe.Mahua.Framework/commits?author=newbe36524 "Documentation") [💻](https://github.com/newbe36524/Newbe.Mahua.Framework/commits?author=newbe36524 "Code") [🔧](#tool-newbe36524 "Tools") [📝](#blog-newbe36524 "Blogposts") [💡](#example-newbe36524 "Examples") | [<img src="https://avatars1.githubusercontent.com/u/12078678?v=4" width="100px;"/><br /><sub><b>Traceless</b></sub>](https://traceless.site/)<br />[💻](https://github.com/newbe36524/Newbe.Mahua.Framework/commits?author=traceless0929 "Code") [🐛](https://github.com/newbe36524/Newbe.Mahua.Framework/issues?q=author%3Atraceless0929 "Bug reports") | [<img src="https://avatars1.githubusercontent.com/u/43395785?v=4" width="100px;"/><br /><sub><b>kotoneme</b></sub>](https://github.com/kotoneme)<br />[💻](https://github.com/newbe36524/Newbe.Mahua.Framework/commits?author=kotoneme "Code") | [<img src="https://avatars1.githubusercontent.com/u/7455309?v=4" width="100px;"/><br /><sub><b>AllenXie</b></sub>](https://github.com/allenxie888)<br />[💻](https://github.com/newbe36524/Newbe.Mahua.Framework/commits?author=allenxie888 "Code") | [<img src="https://avatars1.githubusercontent.com/u/7760499?v=4" width="100px;"/><br /><sub><b>bgli100</b></sub>](https://github.com/bgli100)<br />[💻](https://github.com/newbe36524/Newbe.Mahua.Framework/commits?author=bgli100 "Code") [🐛](https://github.com/newbe36524/Newbe.Mahua.Framework/issues?q=author%3Abgli100 "Bug reports") | [<img src="https://avatars1.githubusercontent.com/u/20368567?v=4" width="100px;"/><br /><sub><b>Q-Q</b></sub>](https://github.com/newce36524)<br />[💻](https://github.com/newbe36524/Newbe.Mahua.Framework/commits?author=newce36524 "Code") [🐛](https://github.com/newbe36524/Newbe.Mahua.Framework/issues?q=author%3Anewce36524 "Bug reports") | [<img src="https://avatars1.githubusercontent.com/u/45588935?v=4" width="100px;"/><br /><sub><b>LollipopGeneral</b></sub>](https://github.com/LollipopGeneral)<br />[💻](https://github.com/newbe36524/Newbe.Mahua.Framework/commits?author=LollipopGeneral "Code") |
| :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: | :--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: | :-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: |
<!-- ALL-CONTRIBUTORS-LIST:END -->

This project follows the [all-contributors](https://github.com/kentcdodds/all-contributors) specification. Contributions of any kind welcome!

## 说在最后面

开发本SDK的目的是为了促进.Net技术的交流学习。

由本SDK衍生的任何产品均与本SDK无关！

由本SDK支持的QQ自动化管理助手平台均与本SDK无关！

禁止用于国家或地区法律法规所禁止的范围！

**最后，但是最重要的，一定要Star一下！**

[借一步说话](http://www.newbe.pro/donate.html)