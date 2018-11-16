#include <boost/test/unit_test.hpp>

#include <enum_fancy.h>

#include <iostream>
#include <fstream>
#include <vector>

BOOST_AUTO_TEST_CASE(test_enum_fancy) {
    std::ifstream ifs("src/enum_0.bin", std::ifstream::binary);
    kaitai::kstream ks(&ifs);
    enum_fancy_t* r = new enum_fancy_t(&ks);

    BOOST_CHECK_EQUAL(r->pet_1(), enum_fancy_t::ANIMAL_CAT);
    BOOST_CHECK_EQUAL(r->pet_2(), enum_fancy_t::ANIMAL_CHICKEN);

    delete r;
}