// Autogenerated from KST: please remove this line if doing any edits by hand!

#include <boost/test/unit_test.hpp>
#include <enum_long_range_u.h>
#include <iostream>
#include <fstream>
#include <vector>

BOOST_AUTO_TEST_CASE(test_enum_long_range_u) {
    std::ifstream ifs("src/enum_long_range_u.bin", std::ifstream::binary);
    kaitai::kstream ks(&ifs);
    enum_long_range_u_t* r = new enum_long_range_u_t(&ks);


    BOOST_CHECK_EQUAL(r->f1(), enum_long_range_u_t::CONSTANTS_ZERO);
    BOOST_CHECK_EQUAL(r->f2(), enum_long_range_u_t::CONSTANTS_INT_MAX);
    BOOST_CHECK_EQUAL(r->f3(), enum_long_range_u_t::CONSTANTS_INT_OVER_MAX);
    BOOST_CHECK_EQUAL(r->f4(), enum_long_range_u_t::CONSTANTS_LONG_MAX);

    delete r;
}
