# Top-level workspace file for building inklecate with Bazel - https://bazel.io

# ----------------------------------------------------------------------------------------
# C# support - see https://github.com/bazelbuild/rules_dotnet

git_repository(
    name = "io_bazel_rules_dotnet",
    remote = "https://github.com/iainmerrick/rules_dotnet.git",
    commit = "a5acb86b84280e14a6168478804d305479f4be69",
)

load(
    "@io_bazel_rules_dotnet//dotnet:csharp.bzl",
    "csharp_repositories",
    "nuget_package",
)

csharp_repositories()

# ----------------------------------------------------------------------------------------
