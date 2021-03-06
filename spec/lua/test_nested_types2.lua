local luaunit = require("luaunit")

require("nested_types2")

TestNestedTypes2 = {}

function TestNestedTypes2:test_nested_types2()
    local r = NestedTypes2:from_file("src/fixed_struct.bin")

    luaunit.assertEquals(r.one.typed_at_root.value_b, 80)

    luaunit.assertEquals(r.one.typed_here1.value_c, 65)

    luaunit.assertEquals(r.one.typed_here1.typed_here.value_d, 67)
    luaunit.assertEquals(r.one.typed_here1.typed_parent.value_cc, 75)
    luaunit.assertEquals(r.one.typed_here1.typed_root.value_b, 45)

    luaunit.assertEquals(r.one.typed_here2.value_cc, 49)

    luaunit.assertEquals(r.two.value_b, -1)
end
