export ANDROID_NDK=/Users/xsj/Tools/android-ndk-r10e

mkdir -p build_v7a && cd build_v7a
cmake -DANDROID_ABI=armeabi-v7a -DCMAKE_TOOLCHAIN_FILE=../cmake/android.toolchain.cmake -DANDROID_TOOLCHAIN_NAME=arm-linux-androideabi-clang3.6 -DANDROID_NATIVE_API_LEVEL=android-9 ../
cd ..
cmake --build build_v7a --config Release
mkdir -p ../../../bin/native/Android/libs/armeabi-v7a/
cp build_v7a/libtstunity.so ../../../bin/native/Android/libs/armeabi-v7a/libtstunity.so

mkdir -p build_x86 && cd build_x86
cmake -DANDROID_ABI=x86 -DCMAKE_TOOLCHAIN_FILE=../cmake/android.toolchain.cmake -DANDROID_TOOLCHAIN_NAME=x86-clang3.5 -DANDROID_NATIVE_API_LEVEL=android-9 ../
cd ..
cmake --build build_x86 --config Release
mkdir -p ../../../bin/native/Android/libs/x86/
cp build_x86/libtstunity.so ../../../bin/native/Android/libs/x86/libtstunity.so

rm -rf ./build_v7a
rm -rf ./build_x86


