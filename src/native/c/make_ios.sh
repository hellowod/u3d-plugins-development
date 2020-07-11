mkdir -p build_ios && cd build_ios
cmake -DCMAKE_TOOLCHAIN_FILE=../cmake/iOS.toolchain.cmake  -GXcode ../
cd ..
cmake --build build_ios --config Release
mkdir -p ../../../bin/native/iOS/
cp build_ios/Release-iphoneos/libtstunity.a ../../../bin/native/iOS/libtstunity.a
rm -rf ./build_ios

