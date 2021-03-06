local luaunit = require("luaunit")

require("repeat_n_strz")

TestRepeatNStrz = {}

function TestRepeatNStrz:test_repeat_n_strz()
    local r = RepeatNStrz:from_file("src/repeat_n_strz.bin")

    luaunit.assertEquals(r.qty, 2)
    luaunit.assertEquals(r.lines, {"foo", "bar"})
end
