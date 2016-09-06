# coding: utf-8
require 'expr_3'

RSpec.describe Expr3 do
  it 'parses test properly' do
    r = Expr3.from_file('src/fixed_struct.bin')

    expect(r.one).to eq 80
    expect(r.two).to eq 'ACK'

    expect(r.three).to eq '@ACK'
    expect(r.four).to eq '_ACK_'
    expect(r.is_str_eq).to eq true
    expect(r.is_str_ne).to eq false
    expect(r.is_str_lt).to eq true
    expect(r.is_str_gt).to eq false
    expect(r.is_str_le).to eq true
    expect(r.is_str_ge).to eq false
    expect(r.is_str_lt2).to eq true
  end
end