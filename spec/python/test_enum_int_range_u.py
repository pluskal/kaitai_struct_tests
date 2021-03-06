# Autogenerated from KST: please remove this line if doing any edits by hand!

import unittest

from enum_int_range_u import EnumIntRangeU

class TestEnumIntRangeU(unittest.TestCase):
    def test_enum_int_range_u(self):
        with EnumIntRangeU.from_file('src/enum_int_range_u.bin') as r:

            self.assertEqual(r.f1, EnumIntRangeU.Constants.zero)
            self.assertEqual(r.f2, EnumIntRangeU.Constants.int_max)
