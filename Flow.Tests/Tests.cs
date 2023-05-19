namespace FlowNS.Tests;

public class UnitTest1 {
    [Fact]
    public void Test() {
        BoxElement box = new BoxElement(10, 10, new Pixel('X', new RGB(150, 200, 255), new RGB(0, 0, 0)));
        Renderer renderer = new Renderer();
        renderer.AddElement(box);
        renderer.Render();
        Console.ReadLine();
    }
}
