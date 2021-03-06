# Autogenerated from KST: please remove this line if doing any edits by hand!

import unittest, os, streams, options, sequtils, ../testhelpers
import ../../../compiled/nim/enum_0

var
  stream = newFileStream("test_out/nim/junitreports/enum_0.xml", fmWrite)
  outputFormatter = newJUnitOutputFormatter(stream)
addOutputFormatter(outputFormatter)

suite "Kaitai Struct Compiler Test Suite":
  test "Nim: Enum0":
    let r = Enum0.fromFile("src/enum_0.bin")

    check(r.pet1 == Animal())
    check(r.pet2 == Animal())

close(outputFormatter)
