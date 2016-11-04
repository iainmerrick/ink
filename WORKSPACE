# ----------------------------------------------------------------------------------------
# Top-level config for using inklecate with the Bazel build system - https://bazel.build
#
# Bazel uses Python syntax. Turn on Python syntax highlighting to make this file look nice
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
