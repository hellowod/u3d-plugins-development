mkdir build32 & pushd build32
cmake -G "Visual Studio 14 2015" ..
popd
cmake --build build32 --config Release
md ..\PluginsBuild\NativePlugins\x86
copy /Y build32\Release\tstunity.dll ..\PluginsBuild\NativePlugins\x86\tstunity.dll
pause