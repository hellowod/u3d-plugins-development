mkdir -p build_ios && cd build_ios
cmake -DCMAKE_TOOLCHAIN_FILE=../cmake/iOS.toolchain.cmake  -GXcode ../
cd ..
cmake --build build_ios --config Release
mkdir -p ../Bin/Native/iOS/
cp build_ios/Release-iphoneos/libtstunity.a ../Bin/Native/iOS/libtstunity.a

