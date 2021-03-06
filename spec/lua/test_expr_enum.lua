local luaunit = require("luaunit")

require("expr_enum")

TestExprEnum = {}

function TestExprEnum:test_expr_enum()
    local r = ExprEnum:from_file("src/term_strz.bin")

    luaunit.assertEquals(r.const_dog, ExprEnum.Animal.dog)
    luaunit.assertEquals(r.derived_boom, ExprEnum.Animal.boom)
    luaunit.assertEquals(r.derived_dog, ExprEnum.Animal.dog)
end
