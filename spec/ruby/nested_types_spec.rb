require 'nested_types'

RSpec.describe NestedTypes do
  it 'parses test properly' do
    r = NestedTypes.from_file('src/fixed_struct.bin')

    expect(r.one.typed_at_root.value_b).to eq 80
    expect(r.one.typed_here.value_c).to eq 65
    expect(r.two.value_b).to eq 67
  end
end