# Autogenerated from KST: please remove this line if doing any edits by hand!

import unittest, os, streams, options, sequtils, ../testhelpers
import ../../../compiled/nim/bits_enum

var
  stream = newFileStream("test_out/nim/junitreports/bits_enum.xml", fmWrite)
  outputFormatter = newJUnitOutputFormatter(stream)
addOutputFormatter(outputFormatter)

suite "Kaitai Struct Compiler Test Suite":
  test "Nim: BitsEnum":
    let r = BitsEnum.fromFile("src/fixed_struct.bin")

    check(r.one == Animal())
    check(r.two == Animal())
    check(r.three == Animal())

close(outputFormatter)
