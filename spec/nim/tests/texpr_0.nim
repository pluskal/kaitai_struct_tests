# Autogenerated from KST: please remove this line if doing any edits by hand!

let r = Expr0.fromFile("src" / "str_encodings.bin")

check(r.mustBeF7 == 247)
check(r.mustBeAbc123 == "abc123")