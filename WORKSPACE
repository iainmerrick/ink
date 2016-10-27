# Top-level workspace file for building inklecate with Bazel - https://bazel.io

# ----------------------------------------------------------------------------------------
# C# support - see https://github.com/bazelbuild/rules_dotnet

git_repository(
    name = "io_bazel_rules_dotnet",
    remote = "https://github.com/bazelbuild/rules_dotnet.git",
    commit = "343ecc8fe6a1239785228ec1b8b128249814670a",
)

load(
    "@io_bazel_rules_dotnet//dotnet:csharp.bzl",
    "csharp_repositories",
    "nuget_package",
)

csharp_repositories(use_local_mono = False)

# ----------------------------------------------------------------------------------------
