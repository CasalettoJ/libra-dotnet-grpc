How to set up a basic .NET Core gRPC Client for Libra using the libra project:

1. Set up the dotnet project (In this case, `dotnet new console`)
2. Add the grpc and protobug nuget packages: 
```
dotnet add package grpc
dotnet add package grpc.core
dotnet add package grpc.tools
dotnet add package google.protobuf
```
3. Take the .proto files from the libra project and place them in the project directory somewhere (I put them in libra_proto)
4. Edit your .csproj file, make sure to add `PrivateAssets="All"` to the grpc.tools import if it's not already set somehow.  (read why here: https://grpc.io/blog/grpc-dotnet-build/)
5. Add the Protobuf files to the .csproj file: `<Protobuf Include="**/*.proto" ProtoRoot="xx" />` setting `ProtoRoot` to the directory in your project you are storing your .proto files
6. At this point you should be able to run `dotnet build` which will include protobuf .CS file generation from the protobuf/grpc packages added.  When it builds, there should be a ton of generated .cs files in `obj/` to prove it is working.
7. You should be able to interact with libra gRPC via the protobuf classes with no issue now.  See Program.cs for an example.  Figuring out how it all works is another journey. :)

Example run:
```
dotnet run
Opening channel to testnet...
Client created.  Testing empty UpdateToLatestLedger call...

Ledger Version: 232336
Transaction Accumulator Hash: RgVvI3A32y3+inBYVBhlVzLHunia/KzPwmXWKedR76M=
Consensus Data Hash: y7181x+CEuP15t78yN39VX+T3rDgEuJ2qWenMvDlc+E=
Consensus Block ID: vyPxbyq5IA6fZv/C5/zkJpV9HTcs1enQZ0r4dgU9XPs=
EpochNum: 0
Timestamp: 1561609122738664 (microseconds unix time)
Validators:
#1:
Signature: LBDlFUYosT2k9Qi+ObO1L4xH8YB2R9sp1LsZbV5UnbCRib/dKaFM0DobgdHA+3WTPVzTCbSR6NO6UolQCCqDBQ==
Validator ID: TXirkLdZ7Kyv5OaHxducwpNqeinISqi+d39U21GddWs=
#2:
Signature: e9oVXkzbADN2s8c+GR5vYzStiE3EOdWVOICbLRwZ3iH+BWBhadasfsK/zleTu9dOtavxA2m0fC7wzmBCgxw6AA==
Validator ID: Joc97NkzAGWYiwrPUCdmK1CX+1CROuKiZStQqYad9Ps=
#3:
Signature: TPwrZcmgeCbXUiwrn05ch885SLLJYVr2kAcgDpzpuc/WGEXm/zLWJbqDiYOHq8hEp11D/Kdr4hvbmW1Qjpr2CQ==
Validator ID: SZVVnEhEt+QQHEhgNTKUAqi6SXbBviMIC6xb3famDw0=
#4:
Signature: 7z/SBoUpMJNhZvFp/CuuHHVCScAZPa595gpr+Ixa73Wj1erSrNT356Vo6aGRHY+RXSlxy75UAu8eFVdyd2akCA==
Validator ID: ZofppubD3g3E9+kerLxnaiKKnAxGRQu8y9EHJ4C/yzA=
#5:
Signature: XGoRH4Z8ayQuFsaaUyS5NBT8raZpAUAY6OGosMlMgT4wwXBmcRYpVNTp3UHVAKPmPWAi1oKPZ6Knqr0ESnhMDw==
Validator ID: +XcMqgvgwK1CfyBMIqLC17Iu43Ohuc9v12j79IoHlVQ=
#6:
Signature: 8fDs48cnoIskGFenL/EeAAREE/OPAecp1tUF1ngHl1omxm4iHOOBYnoIcZsjCXRircRrsgIRMHERJlzY+RDXAQ==
Validator ID: wouVNZDFgReuhDFFbqKPZ8L54XMweLII4ae9W9QIHp4=
#7:
Signature: iAqDmukGRvOf4Khv74lg2jdBVmoXugLr7TQJbG4HEi0M+wbShK9V0ZmWZRE1/CL6RF/P3r1MwkY8QDu2y3y4Bw==
Validator ID: kQK9exrX6PMQI8UANxzH0pcXWLRQz6icAD77OrGSpLg=
```
