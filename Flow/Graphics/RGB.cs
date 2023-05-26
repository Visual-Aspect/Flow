using System;

namespace FlowNS;

public class RGB {
    public byte R { get; set; }
    public byte G { get; set; }
    public byte B { get; set; }

    public RGB(byte r, byte g, byte b) {
        R = r;
        G = g;
        B = b;
    }

    public string ToString(bool fg = false) {
        return $"\x1b[{(fg ? "38" : "48")};2;{R};{G};{B}m";
    }

    public override string ToString() => ToString();
}
