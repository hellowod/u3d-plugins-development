## 简介

通常情况下，我们直接使用脚本实现相关功能，然后由Unity编译成目标可执行文件。
但有时我们不能不在外部把脚本编译成DLL，然后放在Unity中使用。这个DLL就是这
里所说的托管式插件，兼容.NET二进制。

## 注意事项

如果制作的DLL依赖Unity本身的DLL(UnityEngine.dll和UnityEditor.dll),还需要使
编译器能访问它们。 Mac系统，它们存放在/Applications/Unity/Unity.app/Contents/Frameworks/Managed/, Windows下，
存放在C:\Program Files\Unity\Editor\Data\Managed

## 项目设置

项目Target framework设置：Unity3.5 .net Subset Base Class Libraries。

项目Platform target设置：Any CPU。
