local luaunit = require("luaunit")

require("repeat_n_strz_double")

TestRepeatNStrzDouble = {}

function TestRepeatNStrzDouble:test_repeat_n_strz_double()
    local r = RepeatNStrzDouble:from_file("src/repeat_n_strz.bin")

    luaunit.assertEquals(r.qty, 2)
    luaunit.assertEquals(r.lines1, {"foo"})
    luaunit.assertEquals(r.lines2, {"bar"})
end
