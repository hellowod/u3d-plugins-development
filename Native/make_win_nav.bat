echo off

mkdir build32 & pushd build32
cmake -G"Visual Studio 15 2017" ..
popd
cmake --build build32 --config Release
md ..\Bin\Native\x86
copy /Y build32\Release\nav-rcn.dll ..\Bin\Native\x86\nav-rcn.dll

mkdir build64 & pushd build64
cmake -G"Visual Studio 15 2017 Win64" ..
popd
cmake --build build64 --config Release
md ..\Bin\Native\x86_64
copy /Y build64\Release\nav-rcn.dll ..\Bin\Native\x86_64\nav-rcn.dll

pause