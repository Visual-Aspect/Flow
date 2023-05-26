using System;

namespace FlowNS;

public class Vector3 {
    public float X { get; set; }
    public float Y { get; set; }
    public float Z { get; set; }

    public Vector3(float x, float y, float z) {
        X = x;
        Y = y;
        Z = z;
    }

    public Vector3() {
        X = 0;
        Y = 0;
        Z = 0;
    }

    public static Vector3 operator +(Vector3 a, Vector3 b) => new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
    public static Vector3 operator -(Vector3 a, Vector3 b) => new Vector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
    public static Vector3 operator *(Vector3 a, Vector3 b) => new Vector3(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
    public static Vector3 operator /(Vector3 a, Vector3 b) => new Vector3(a.X / b.X, a.Y / b.Y, a.Z / b.Z);
    public static Vector3 operator %(Vector3 a, Vector3 b) => new Vector3(a.X % b.X, a.Y % b.Y, a.Z % b.Z);

    public static Vector3 operator +(Vector3 a, float b) => new Vector3(a.X + b, a.Y + b, a.Z + b);
    public static Vector3 operator -(Vector3 a, float b) => new Vector3(a.X - b, a.Y - b, a.Z - b);
    public static Vector3 operator *(Vector3 a, float b) => new Vector3(a.X * b, a.Y * b, a.Z * b);
    public static Vector3 operator /(Vector3 a, float b) => new Vector3(a.X / b, a.Y / b, a.Z / b);
    public static Vector3 operator %(Vector3 a, float b) => new Vector3(a.X % b, a.Y % b, a.Z % b);
}

public class Vector3i {
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public Vector3i(int x, int y, int z) {
        X = x;
        Y = y;
        Z = z;
    }

    public Vector3i() {
        X = 0;
        Y = 0;
        Z = 0;
    }

    public static Vector3i operator +(Vector3i a, Vector3i b) => new Vector3i(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
    public static Vector3i operator -(Vector3i a, Vector3i b) => new Vector3i(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
    public static Vector3i operator *(Vector3i a, Vector3i b) => new Vector3i(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
    public static Vector3i operator /(Vector3i a, Vector3i b) => new Vector3i(a.X / b.X, a.Y / b.Y, a.Z / b.Z);
    public static Vector3i operator %(Vector3i a, Vector3i b) => new Vector3i(a.X % b.X, a.Y % b.Y, a.Z % b.Z);

    public static Vector3i operator +(Vector3i a, int b) => new Vector3i(a.X + b, a.Y + b, a.Z + b);
    public static Vector3i operator -(Vector3i a, int b) => new Vector3i(a.X - b, a.Y - b, a.Z - b);
    public static Vector3i operator *(Vector3i a, int b) => new Vector3i(a.X * b, a.Y * b, a.Z * b);
    public static Vector3i operator /(Vector3i a, int b) => new Vector3i(a.X / b, a.Y / b, a.Z / b);
    public static Vector3i operator %(Vector3i a, int b) => new Vector3i(a.X % b, a.Y % b, a.Z % b);
}

public class Vector3r {
    public Vector3 Start { get; set; }
    public Vector3 End { get; set; }

    public Vector3r(Vector3 start, Vector3 end) {
        Start = start;
        End = end;
    }

    public Vector3r() {
        Start = new Vector3();
        End = new Vector3();
    }
}

public class Vector3ri {
    public Vector3i Start { get; set; }
    public Vector3i End { get; set; }

    public Vector3ri(Vector3i start, Vector3i end) {
        Start = start;
        End = end;
    }

    public Vector3ri() {
        Start = new Vector3i();
        End = new Vector3i();
    }
}
