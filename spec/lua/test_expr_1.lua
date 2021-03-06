local luaunit = require("luaunit")

require("expr_1")

TestExpr1 = {}

function TestExpr1:test_expr_1()
    local r = Expr1:from_file("src/str_encodings.bin")

    luaunit.assertEquals(r.len_of_1, 10)
    luaunit.assertEquals(r.len_of_1_mod, 8)
    luaunit.assertEquals(r.str1, "Some ASC")
    luaunit.assertEquals(r.str1_len, 8)
end
