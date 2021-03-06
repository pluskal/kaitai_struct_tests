// Autogenerated from KST: please remove this line if doing any edits by hand!

extern crate kaitai_struct;
extern crate rust;

use kaitai_struct::KaitaiStruct;
use rust::ParamsCallShort;

#[test]
fn test_params_call_short() {
    if let Ok(r) = ParamsCallShort::from_file("src/term_strz.bin") {
        assert_eq!(r.buf1.body, "foo|b");
        assert_eq!(r.buf2.body, "ar|ba");
        assert_eq!(r.buf2.trailer, 122);
    }
}
