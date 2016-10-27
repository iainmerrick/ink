# Top-level workspace file for building inklecate with Bazel - https://bazel.io

# ----------------------------------------------------------------------------------------
# C# support - see https://github.com/bazelbuild/rules_dotnet

git_repository(
    name = "io_bazel_rules_dotnet",
    remote = "https://github.com/bazelbuild/rules_dotnet.git",
    commit = "ebc7c1cb61d45bd57042c60b6bfabdfff4979466",
)

load(
    "@io_bazel_rules_dotnet//dotnet:csharp.bzl",
    "csharp_repositories",
    "nuget_package",
)

csharp_repositories(use_local_mono = False)

# ----------------------------------------------------------------------------------------
