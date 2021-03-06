// Autogenerated from KST: please remove this line if doing any edits by hand!

package spec

import (
	"os"
	"testing"
	"github.com/kaitai-io/kaitai_struct_go_runtime/kaitai"
	. "test_formats"
)

func TestValidFailEqInt(t *testing.T) {
	f, err := os.Open("../../src/fixed_struct.bin")
	if err != nil {
		t.Fatal(err)
	}
	s := kaitai.NewStream(f)
	var r ValidFailEqInt
	err = r.Read(s, &r, &r)
	switch v := err.(type) {
	case kaitai.ValidationNotEqualError:
		break
	default:
		t.Fatalf("expected kaitai.ValidationNotEqualError, got %T", v)
	}

}
