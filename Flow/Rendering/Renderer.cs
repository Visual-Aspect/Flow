using System;

namespace FlowNS;

public class Renderer {
    public List<Layer> Elements { get; set; }

    public Renderer() {
        Elements = new List<Layer>();
    }

    public void AddElement(Element element, int zIndex) => Elements.Add(new Layer(element, zIndex));
    public void AddElement(Element element) => Elements.Add(new Layer(element));

    public PixelMap Draw() {
        PixelMap pixelMap = new PixelMap(Console.WindowWidth, Console.WindowHeight);

        Elements.Sort((a, b) => a.zIndex.CompareTo(b.zIndex));
        foreach (Layer layer in Elements) {
            pixelMap = layer.element.Render(pixelMap);
        }

        return pixelMap;
    }

    public void Render() {
        PixelMap pixelMap = Draw();

        string output = "";

        for (int y = 0; y < pixelMap.Height; y++) {
            for (int x = 0; x < pixelMap.Width; x++) {
                if (pixelMap.Pixels[x, y] != null)
                    output += pixelMap.Pixels[x, y].character;
                else output += " ";
            }
            output += "\n";
        }

        Console.SetCursorPosition(0, 0);
        Console.Write(output);
    }
}

public class Layer {
    public Element element;
    public int zIndex;

    public Layer(Element element, int zIndex) {
        this.element = element;
        this.zIndex = zIndex;
    }

    public Layer(Element element) {
        this.element = element;
        this.zIndex = 0;
    }
}
