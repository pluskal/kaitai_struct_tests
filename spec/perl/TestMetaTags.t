# Autogenerated from KST: please remove this line if doing any edits by hand!

package spec::perl::TestMetaTags;

use strict;
use warnings;
use base qw(Test::Class);
use Test::More;
use MetaTags;

sub test_meta_tags: Test(0) {
    my $r = MetaTags->from_file('src/fixed_struct.bin');

}

Test::Class->runtests;
