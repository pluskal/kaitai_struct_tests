# Autogenerated from KST: please remove this line if doing any edits by hand!

import unittest, os, streams, options, sequtils, ../testhelpers
import ../../../compiled/nim/user_type

var
  stream = newFileStream("test_out/nim/junitreports/user_type.xml", fmWrite)
  outputFormatter = newJUnitOutputFormatter(stream)
addOutputFormatter(outputFormatter)

suite "Kaitai Struct Compiler Test Suite":
  test "Nim: UserType":
    let r = UserType.fromFile("src/repeat_until_s4.bin")

    check(r.one.width == uint32(66))
    check(r.one.height == uint32(4919))

close(outputFormatter)
