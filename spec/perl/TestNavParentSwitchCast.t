# Autogenerated from KST: please remove this line if doing any edits by hand!

package spec::perl::TestNavParentSwitchCast;

use strict;
use warnings;
use base qw(Test::Class);
use Test::More;
use NavParentSwitchCast;

sub test_nav_parent_switch_cast: Test(3) {
    my $r = NavParentSwitchCast->from_file('src/switch_integers.bin');


    is($r->foo()->buf_type(), 1, 'Equals');
    is($r->foo()->flag(), 7, 'Equals');
    is($r->foo()->buf()->bar()->flag(), 7, 'Equals');
}

Test::Class->runtests;
