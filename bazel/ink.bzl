# This doesn't work! The external workspace can't resolve "//:inklecate"

def ink_story(name, srcs, visibility=None):
    native.genrule(
        name = name,
        srcs = srcs,
        outs = [name + ".json"],
        cmd = "$(location //:inklecate) -o $@ $(SRCS)",
        tools = [
            "//:inklecate",
        ],
        visibility = visibility,
    )

# This works, but how do I know that this workspace will be imported as @ink?
# The external workspace could call it something else.

def ink_story_2(name, srcs, visibility=None):
    native.genrule(
        name = name,
        srcs = srcs,
        outs = [name + ".json"],
        cmd = "$(location @ink//:inklecate) -o $@ $(SRCS)",
        tools = [
            "@ink//:inklecate",
        ],
        visibility = visibility,
    )
