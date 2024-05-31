# gRPC-AutoCompiler

[![GitHub Repository](https://img.shields.io/badge/GitHub-Repo-blue?style=flat&logo=github)](https://github.com/AmSoMad/gRPC-AutoCompiler)

**gRPC-AutoCompiler**는 새로운 시대의 프로토콜 컴파일링 자동화를 목표로 합니다. 
이 프로젝트는 WinForms 애플리케이션을 사용하여 프로토콜 버퍼 파일을 여러 언어로 자동 컴파일합니다.

gRPC와 여러 프로그래밍 언어를 활용하여 마이크로서비스 구조를 개발하는 개발자들에게 완벽한 해결책을 제공합니다.
수동 컴파일링의 번거로움 없이, 애플리케이션을 통해 proto 파일을 선택하고, 컴파일 버튼을 누르면 나머지는 **gRPC-AutoCompiler**가 알아서 처리합니다.

이 프로젝트를 활용하면 개발 시간을 절약하고, 프로토콜 정의의 일관성을 유지하면서 효율적인 협업을 도모할 수 있습니다.

개발자, 엔지니어, 시스템 아키텍트 모두에게 유용한 이 툴을 지금 바로 사용해보세요!

---

### 지원하는 언어

| 언어       | 아이콘                                                                                              |
|------------|-------------------------------------------------------------------------------------------------------|
| C#         | <img src="https://raw.githubusercontent.com/github/explore/main/topics/csharp/csharp.png" width="50" height="50"> |
| JavaScript | <img src="https://raw.githubusercontent.com/github/explore/main/topics/javascript/javascript.png" width="50" height="50"> |
| Java       | <img src="https://raw.githubusercontent.com/github/explore/main/topics/java/java.png" width="50" height="50">     |
| Dart       | <img src="https://raw.githubusercontent.com/github/explore/main/topics/dart/dart.png" width="50" height="50">     |
| gRPC-Web   | <img src="https://raw.githubusercontent.com/github/explore/main/topics/grpc/grpc.png" width="50" height="50">     |
| Python     | <img src="https://raw.githubusercontent.com/github/explore/main/topics/python/python.png" width="50" height="50"> |

---

## 프로젝트 목적

이 프로젝트는 gRPC 프로토콜을 사용하는 다양한 언어로 작성된 서비스에 대한 컴파일을 자동화하기 위한 목적으로 생성되었습니다. 
사용자는 WinForms 애플리케이션을 통해 프로토콜 버퍼 파일을 선택하고, 컴파일 버튼을 눌러 다양한 언어로 컴파일된 파일을 얻을 수 있습니다.

## 사용 방법

1. 저장소를 클론하거나 다운로드합니다:
    ```sh
    git clone https://github.com/AmSoMad/gRPC-AutoCompiler.git
    ```
2. 솔루션 파일(`ProtoFileAutoCompiler.sln`)을 Visual Studio에서 엽니다.
3. `protoc` 디렉터리 안에 필요한 바이너리와 include 파일이 있는지 확인합니다.
4. 애플리케이션을 빌드하고 실행합니다.
5. 애플리케이션에서 폴더 선택 버튼을 클릭하여 .proto 파일이 있는 폴더를 선택합니다.
6. 컴파일 버튼을 눌러 선택된 폴더의 모든 .proto 파일을 컴파일합니다.

---

## 프로젝트 구조

```plaintext
ProtoFileAutoCompiler/
├── protoc/
│   ├── win32/
│   │   └── protoc.exe
│   ├── win64/
│   │   └── protoc.exe
│   └── include/
│       └── ... (include files)
├── Form1.cs
├── Form1.Designer.cs
├── Form1.resx
├── Program.cs
├── ProtoFileAutoCompiler.csproj
├── ProtoFileAutoCompiler.sln
├── README.md
└── .gitignore
```

## 연락처

무엇이든 물어보고 싶으시거나 도움이 필요하시면, 저장소의 이슈 트래커를 사용하시거나 직접 [연락](https://github.com/AmSoMad)주시기 바랍니다.
