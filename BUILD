load(
    "@io_bazel_rules_dotnet//dotnet:csharp.bzl",
    "csharp_library",
    "csharp_binary",
)

csharp_binary(
    name = "inklecate",
    main_class = "Ink.CommandLineTool",
    srcs = glob([
        "inklecate/*.cs",
        "inklecate/**/*.cs",
        "ink-engine-runtime/*.cs",
    ]),
    warn = 3, # Suppress documentation warnings
)
