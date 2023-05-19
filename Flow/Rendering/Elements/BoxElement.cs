
namespace FlowNS;

public class BoxElement : Element {
    public int Width { get; set; }
    public int Height { get; set; }
    public Pixel Pixel { get; set; }

    public BoxElement(int width, int height, Pixel pixel) {
        Width = width;
        Height = height;
        Pixel = pixel;
    }

    public override PixelMap Render(PixelMap pixelMap) {
        for (int x = 0; x < Width; x++) {
            pixelMap.Pixels[x, 0] = Pixel;
            pixelMap.Pixels[x, Height - 1] = Pixel;
        }

        for (int y = 0; y < Height; y++) {
            pixelMap.Pixels[0, y] = Pixel;
            pixelMap.Pixels[Width - 1, y] = Pixel;
        }

        return pixelMap;
    }
}
