using System;

namespace FlowNS;

public class Pixel {
    public char character;
    public RGB BG;
    public RGB FG;

    public Pixel(char character, RGB BG, RGB FG) {
        this.character = character;
        this.BG = BG;
        this.FG = FG;
    }

    public Pixel(RGB BG) {
        this.character = ' ';
        this.BG = BG;
        this.FG = new RGB(0, 0, 0);
    }

    public Pixel(char character) {
        this.character = character;
        this.BG = new RGB(0, 0, 0);
        this.FG = new RGB(0, 0, 0);
    }

    public Pixel() {
        this.character = ' ';
        this.BG = new RGB(0, 0, 0);
        this.FG = new RGB(0, 0, 0);
    }
}
