## Unity原生态插件开发  🤘🤘🤘

[![GitHub stars](https://img.shields.io/github/stars/hellowod/unity-plugins-development.svg)](https://github.com/hellowod/unity-plugins-development/stargazers)
[![GitHub forks](https://img.shields.io/github/forks/hellowod/unity-plugins-development.svg)](https://github.com/hellowod/unity-plugins-development/network)
[![GitHub issues](https://img.shields.io/github/issues/hellowod/unity-plugins-development.svg)](https://github.com/hellowod/unity-plugins-development/issues)
[![GitHub release](https://img.shields.io/github/release/hellowod/unity-plugins-development.svg)](https://github.com/hellowod/unity-plugins-development/releases)
[![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://raw.githubusercontent.com/hellowod/unity-plugins-development/master/LICENSE)

Unity可以开发两种插件，Managed plugins和Native plugins。

Managed plugins 是托管式.NET插件，使用对应Unity的.NET版本进行开发。

Native plugins 平台相关的原生插件，可以访问操作系统的插件或者第三方的插件。

在Unity5之前，通过插件存放的目录来区分支持的目标平台；然而Unity5可以把插件放
在任何目录，通过Plugin Inspector设置相关属性就可以了，但为了兼容以前的版本，
Unity5也会支持插件存放的目录，进行默认的插件设置。

规则如下:

```
文件夹	                                                默认插件设置
Assets/**/Editor	                                    只兼容Editor
Assets/**/Editor/(x86 or x86_64 or x64)	                只兼容Editor，如果子文件夹存在，用于匹配目标CPU
Assets/Plugins/x86_64(or x64)	                        x64兼容
Assets/Plugins/x86	                                    x86兼容
Assets/Plugins/Android/(x86 or armeabi or armeabi-v7a)	只跟Android兼容，如果子文件夹存在，用于匹配目标CPU
Assets/Plugins/iOS	                                    只跟iOS兼容
```

## 托管插件（Managed plugins）

通常情况下，我们直接使用脚本实现相关功能，然后由Unity编译成目标可执行文件。但有
时我们想在外部把脚本编译成DLL，然后放在Unity中使用。这个DLL就是这里所说的托管式
插件，兼容.NET二进制。

托管插件相对来说比较常见，也是项目开发中比较常见的方式，文章结尾的unity-plugins-development
项目也给出了简单的托管插件的案例，敬请参考。

## 原生插件（Native Plugins）

原生插件一般采用C,C++,Objective-C等等编写，Unity允许游戏代码来访问这些原生插件中的函数，
允许Unity和一些中间件库或者已有的C/C++进行整合和。

原生插件，这里推荐使用C或C++语言进行开发，不要使用Objective-C或者是Java开发，原因C或C++
接口跨平台支持的更好，这里说的标准C和C++。这里给出的案例就是使用C进行开发简单加减乘除插件
为Unity使用。


### Plugin Demo

这里给出demo的编译工具使用CMake，当然你也可以使用其他的编译工具如make等，不熟悉的可以查看官方文档，
或者是:[cmake 简单介绍](https://abaojin.github.io/2017/02/10/build-cmake/),
也可以查看：[CMake官网](https://cmake.org/)，这里就不过多介绍CMake的相关规则。

tstunity_conf.h

```
/*
config
*/

#if defined(_MSC_VER)
#define TST_API __declspec(dllexport)
#else
#define TST_API
#endif
```

math_helper.h

```
#ifndef MATH_HELPER_
#define MATH_HELPER_

#include "tstunity_conf.h"

TST_API int add(int a, int b);
TST_API int sub(int a, int b);
TST_API int div(int a, int b);
TST_API int mul(int a, int b);

#endif//MATH_HELPER_
```

math_helper.c

```
#define TST_LIB

#include "math_helper.h"

TST_API int add(int a, int b){
	return a + b;
}
TST_API int sub(int a, int b){
	return a - b;
}
TST_API int div(int a, int b){
	return a / b;
}
TST_API int mul(int a, int b){
	return a * b;
}
```

### Mac平台

在Mac系统下生成.bundle插件包，生成Shell脚本在：NativePlugins/make_osx.sh

### Window平台

在Window32系统下生成Dll插件包，生成bat脚本在：NativePlugins/make_win32.sh

在Window64系统下生成Dll插件包，生成bat脚本在：NativePlugins/make_win64.sh

### Android平台

在Mac系统下生成.so插件包，生成Shell脚本在：NativePlugins/make_Android.sh

android平台下面的编译需要NDK（Native Development Kit）的支持，由于国内google
被墙，没有的同学也可以从我的网盘下载：链接：http://pan.baidu.com/s/1hsLZl9E 密码：t7ir

### iOS平台

在Mac系统下生成.so插件包，生成Shell脚本在：NativePlugins/make_iOS.sh

## CMake使用

关于CMake介绍这里补充一下，相对来说，CMake比make编译工具要复杂的多，中文的资料
相对比较少，这里推荐几篇文章感兴趣的可以阅读一下：

[CMake cmake 学习笔记(一，二，三)](https://my.oschina.net/chen0dgax/blog/151894)
和大多数资料相比，这篇写的更加的通俗易懂，如果大家还是觉得使用起来比较陌生，后面
会专门单独一个git项目演示CMake是如何实现扩平台编译的。

## 参考资料

[unity-plugins-development Github](https://github.com/hellowod/unity-plugins-development)

[Unity Manual](https://docs.unity3d.com/Manual/UnityManual.html)

[Unity Plugins](https://docs.unity3d.com/Manual/Plugins.html)

[Building Plugins for iOS](https://docs.unity3d.com/Manual/PluginsForIOS.html)

[Building Plugins for Android](https://docs.unity3d.com/Documentation/Manual/PluginsForAndroid.html)

[Building Plugins for Desktop Platforms](https://docs.unity3d.com/Documentation/Manual/PluginsForDesktop.html)