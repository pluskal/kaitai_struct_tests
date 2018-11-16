// Autogenerated from KST: please remove this line if doing any edits by hand!

#include <boost/test/unit_test.hpp>
#include <float_to_i.h>
#include <iostream>
#include <fstream>
#include <vector>

BOOST_AUTO_TEST_CASE(test_float_to_i) {
    std::ifstream ifs("src/floating_points.bin", std::ifstream::binary);
    kaitai::kstream ks(&ifs);
    float_to_i_t* r = new float_to_i_t(&ks);

    BOOST_CHECK_EQUAL(r->single_value(), 0.5);
    BOOST_CHECK_EQUAL(r->double_value(), 0.25);
    BOOST_CHECK_EQUAL(r->single_i(), 0);
    BOOST_CHECK_EQUAL(r->double_i(), 0);
    BOOST_CHECK_EQUAL(r->float1_i(), 1);
    BOOST_CHECK_EQUAL(r->float2_i(), 1);
    BOOST_CHECK_EQUAL(r->float3_i(), 1);
    BOOST_CHECK_EQUAL(r->float4_i(), -2);

    delete r;
}