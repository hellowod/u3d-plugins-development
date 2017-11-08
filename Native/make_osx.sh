mkdir -p build_osx && cd build_osx
cmake -GXcode ../
cd ..
cmake --build build_osx --config Release
mkdir -p ../Bin/Native/tstunity.bundle/Contents/MacOS/
cp build_osx/Release/tstunity.bundle/Contents/MacOS/tstunity ../Bin/Native/tstunity.bundle/Contents/MacOS/tstunity

