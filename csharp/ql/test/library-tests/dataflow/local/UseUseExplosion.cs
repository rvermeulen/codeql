class C
{
    int Prop { get; set; }

    // Should generate 100 + 100 local use-use flow steps for `x`, and not 100 * 100
    //
    // Generated by quick-evaling `gen/0` below:
    //
    // ```ql
    // string gen(int depth) {
    //   depth in [0 .. 100] and
    //   (
    //     if depth = 0
    //     then result = ""
    //     else result = "if (Prop > " + depth + ") { " + gen(depth - 1) + " } else Use(x);"
    //   )
    // }
    //
    // string gen() { result = "var x = 0;\n" + gen(100) + "\n" + gen(100) }
    // ```
    void M()
    {
        var x = 0;
        if (Prop > 100) { if (Prop > 99) { if (Prop > 98) { if (Prop > 97) { if (Prop > 96) { if (Prop > 95) { if (Prop > 94) { if (Prop > 93) { if (Prop > 92) { if (Prop > 91) { if (Prop > 90) { if (Prop > 89) { if (Prop > 88) { if (Prop > 87) { if (Prop > 86) { if (Prop > 85) { if (Prop > 84) { if (Prop > 83) { if (Prop > 82) { if (Prop > 81) { if (Prop > 80) { if (Prop > 79) { if (Prop > 78) { if (Prop > 77) { if (Prop > 76) { if (Prop > 75) { if (Prop > 74) { if (Prop > 73) { if (Prop > 72) { if (Prop > 71) { if (Prop > 70) { if (Prop > 69) { if (Prop > 68) { if (Prop > 67) { if (Prop > 66) { if (Prop > 65) { if (Prop > 64) { if (Prop > 63) { if (Prop > 62) { if (Prop > 61) { if (Prop > 60) { if (Prop > 59) { if (Prop > 58) { if (Prop > 57) { if (Prop > 56) { if (Prop > 55) { if (Prop > 54) { if (Prop > 53) { if (Prop > 52) { if (Prop > 51) { if (Prop > 50) { if (Prop > 49) { if (Prop > 48) { if (Prop > 47) { if (Prop > 46) { if (Prop > 45) { if (Prop > 44) { if (Prop > 43) { if (Prop > 42) { if (Prop > 41) { if (Prop > 40) { if (Prop > 39) { if (Prop > 38) { if (Prop > 37) { if (Prop > 36) { if (Prop > 35) { if (Prop > 34) { if (Prop > 33) { if (Prop > 32) { if (Prop > 31) { if (Prop > 30) { if (Prop > 29) { if (Prop > 28) { if (Prop > 27) { if (Prop > 26) { if (Prop > 25) { if (Prop > 24) { if (Prop > 23) { if (Prop > 22) { if (Prop > 21) { if (Prop > 20) { if (Prop > 19) { if (Prop > 18) { if (Prop > 17) { if (Prop > 16) { if (Prop > 15) { if (Prop > 14) { if (Prop > 13) { if (Prop > 12) { if (Prop > 11) { if (Prop > 10) { if (Prop > 9) { if (Prop > 8) { if (Prop > 7) { if (Prop > 6) { if (Prop > 5) { if (Prop > 4) { if (Prop > 3) { if (Prop > 2) { if (Prop > 1) { } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x);
        if (Prop > 100) { if (Prop > 99) { if (Prop > 98) { if (Prop > 97) { if (Prop > 96) { if (Prop > 95) { if (Prop > 94) { if (Prop > 93) { if (Prop > 92) { if (Prop > 91) { if (Prop > 90) { if (Prop > 89) { if (Prop > 88) { if (Prop > 87) { if (Prop > 86) { if (Prop > 85) { if (Prop > 84) { if (Prop > 83) { if (Prop > 82) { if (Prop > 81) { if (Prop > 80) { if (Prop > 79) { if (Prop > 78) { if (Prop > 77) { if (Prop > 76) { if (Prop > 75) { if (Prop > 74) { if (Prop > 73) { if (Prop > 72) { if (Prop > 71) { if (Prop > 70) { if (Prop > 69) { if (Prop > 68) { if (Prop > 67) { if (Prop > 66) { if (Prop > 65) { if (Prop > 64) { if (Prop > 63) { if (Prop > 62) { if (Prop > 61) { if (Prop > 60) { if (Prop > 59) { if (Prop > 58) { if (Prop > 57) { if (Prop > 56) { if (Prop > 55) { if (Prop > 54) { if (Prop > 53) { if (Prop > 52) { if (Prop > 51) { if (Prop > 50) { if (Prop > 49) { if (Prop > 48) { if (Prop > 47) { if (Prop > 46) { if (Prop > 45) { if (Prop > 44) { if (Prop > 43) { if (Prop > 42) { if (Prop > 41) { if (Prop > 40) { if (Prop > 39) { if (Prop > 38) { if (Prop > 37) { if (Prop > 36) { if (Prop > 35) { if (Prop > 34) { if (Prop > 33) { if (Prop > 32) { if (Prop > 31) { if (Prop > 30) { if (Prop > 29) { if (Prop > 28) { if (Prop > 27) { if (Prop > 26) { if (Prop > 25) { if (Prop > 24) { if (Prop > 23) { if (Prop > 22) { if (Prop > 21) { if (Prop > 20) { if (Prop > 19) { if (Prop > 18) { if (Prop > 17) { if (Prop > 16) { if (Prop > 15) { if (Prop > 14) { if (Prop > 13) { if (Prop > 12) { if (Prop > 11) { if (Prop > 10) { if (Prop > 9) { if (Prop > 8) { if (Prop > 7) { if (Prop > 6) { if (Prop > 5) { if (Prop > 4) { if (Prop > 3) { if (Prop > 2) { if (Prop > 1) { } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x); } else Use(x);
    }

    void Use(int i) { }
}