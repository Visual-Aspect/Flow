using System;

namespace FlowNS;

public class PixelMap {
    public Pixel[,] Pixels { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }

    public PixelMap(int width, int height) {
        Width = width;
        Height = height;
        Pixels = new Pixel[width, height];
        this.Clear();
    }

    public void Clear() {
        for (int y = 0; y < Height; y++)
            for (int x = 0; x < Width; x++)
                Pixels[x, y] = new Pixel();
    }

    public void SetPixel(int x, int y, Pixel pixel) => Pixels[x, y] = pixel;
    public Pixel GetPixel(int x, int y) => Pixels[x, y];
}
