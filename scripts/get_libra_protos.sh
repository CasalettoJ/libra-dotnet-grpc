#!/bin/bash

grpctoolsvr="1.21.0"
grpctoolsos="macosx_x64"

if [ -z "$LIBRA" ]; then
    echo "\$LIBRA environment variable missing."
    echo "Please set \$LIBRA to the Libra Core root path"
    exit 1
fi

if [ -z "$NUGET" ]; then
    echo "\$NUGET environment variable missing."
    echo "Please set \$NUGET to the NuGet path (probably ~/.nuget)"
    exit 1
fi

sourcedir=$(pwd)
mkdir -p libra_proto
rm -rf ./libra_proto/*

echo "Copying Libra protobuf files..."
find $LIBRA -name "*.proto" \
    -execdir echo "Copying {}" \; \
    -execdir cp "{}" "$sourcedir/libra_proto" \; \
    -execdir sed -i '' 's#import \"shared/#import \"#g' "$sourcedir/libra_proto/{}" \;

echo "Building proto c# files"
find "libra_proto" -name "*.proto" \
    -execdir echo "Building {}" \; \
    -execdir protoc --grpc_out="." --csharp_out="." --csharp_opt=file_extension=.g.cs --plugin=protoc-gen-grpc="$NUGET/packages/grpc.tools/$grpctoolsvr/tools/$grpctoolsos/grpc_csharp_plugin" "{}" \;