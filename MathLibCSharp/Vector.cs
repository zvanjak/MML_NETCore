using System;

namespace MML
{
  public class Vector
  {
    private int _dim;
    protected double[] _elems;

    public Vector(int dim)
    {
      _dim = dim;
      _elems = new double[dim];
    }

    public int Dim { get => _dim; set => _dim = value; }
    public double[] Elements { get => _elems; set => _elems = value; }

    public double At(int i)
    {
      return _elems[i];
    } 

    // TODO resize
    public static Vector operator +(Vector a, Vector b)
    {
      // TODO check dimensions
      Vector ret = new Vector(a._dim);
      for (int i = 0; i < a._dim; i++)
        ret._elems[i] = a._elems[i] + b._elems[i];
      return ret;
    }



  }

  public class Vector2 : Vector
  {
    public double X1 { get => _elems[0]; set => _elems[0] = value; }
    public double X2 { get => _elems[1]; set => _elems[1] = value; }

    public Vector2() : base(2) { }
    public Vector2(double x1, double x2) : base(2) 
    { 
      _elems[0] = x1;
      _elems[1] = x2;
    }
  }
  public class Vector3 : Vector
  {
    public double X1 { get => _elems[0]; set => _elems[0] = value; }
    public double X2 { get => _elems[1]; set => _elems[1] = value; }
    public double X3 { get => _elems[2]; set => _elems[2] = value; }

    public Vector3() : base(3) { }
    public Vector3(double x1, double x2, double x3) : base(3)
    {
      _elems[0] = x1;
      _elems[1] = x2;
      _elems[2] = x3;
    }
  }

  public class Vector2Cartesian : Vector2
  {
    public double X { get => X1; set => X1 = value; }
    public double Y { get => X2; set => X2 = value; }

    public Vector2Cartesian() { }

    public Vector2Cartesian(double inX, double inY) : base(inX, inY) { }

    public static Vector2Cartesian operator +(Vector2Cartesian a, Vector2Cartesian b)
        => new Vector2Cartesian(a.X + b.X, a.Y + b.Y);

    public static Vector2Cartesian operator -(Vector2Cartesian a, Vector2Cartesian b)
        => new Vector2Cartesian(a.X - b.X, a.Y - b.Y);

    public static Vector2Cartesian operator *(double a, Vector2Cartesian b)
        => new Vector2Cartesian(a * b.X, a * b.Y);

    public static Vector2Cartesian operator *(Vector2Cartesian a, double b)
    => new Vector2Cartesian(b * a.X, b * a.Y);

    public static Vector2Cartesian operator /(Vector2Cartesian a, double b)
    => new Vector2Cartesian(a.X / b, a.Y / b);

    public override string ToString() => $"[{X}, {Y}]";

    public double Norm()
    {
      return Math.Sqrt(X * X + Y * Y);
    }

    public static double ScalProd(Vector2Cartesian a, Vector2Cartesian b)
    {
      return (a.X * b.X + a.Y * b.Y);
    }
  }

  public class Vector3Cartesian : Vector3
  {
    public double X { get => X1; set => X1 = value; }
    public double Y { get => X2; set => X2 = value; }
    public double Z { get => X3; set => X3 = value; }

    public Vector3Cartesian()  { }

    public Vector3Cartesian(double inX, double inY, double inZ) : base(inX, inY, inZ) { }

    public static Vector3Cartesian operator +(Vector3Cartesian a, Vector3Cartesian b)
        => new Vector3Cartesian(a.X + b.X, a.Y + b.Y, a.Z + b.Z);

    public static Vector3Cartesian operator -(Vector3Cartesian a, Vector3Cartesian b)
        => new Vector3Cartesian(a.X - b.X, a.Y - b.Y, a.Z - b.Z);

    public static Vector3Cartesian operator *(double a, Vector3Cartesian b)
        => new Vector3Cartesian(a * b.X, a * b.Y, a * b.Z);

    public static Vector3Cartesian operator *(Vector3Cartesian a, double b)
    => new Vector3Cartesian(b * a.X, b * a.Y, b * a.Z);

    public static Vector3Cartesian operator /(Vector3Cartesian a, double b)
    => new Vector3Cartesian(a.X / b, a.Y / b, a.Z / b);

    public override string ToString() => $"[{X}, {Y}, {Z}]";

    public double Norm()
    {
      return Math.Sqrt(X * X + Y * Y + Z * Z);
    }

    public static double VectorAngle(Vector3Cartesian a, Vector3Cartesian b)
    {
      double cos = ScalProd(a, b) / (a.Norm() * b.Norm());
      return Math.Acos(cos);
    }

    public static double ScalProd(Vector3Cartesian a, Vector3Cartesian b)
    {
      return (a.X * b.X + a.Y * b.Y + a.Z * b.Z);
    }

    public static Vector3Cartesian VectorProd(Vector3Cartesian a, Vector3Cartesian b)
    {
      return new Vector3Cartesian(a.Y * b.Z - a.Z * b.Y, a.Z * b.X - a.X * b.Z, a.X * b.Y - a.Y * b.X);
    }

  }
}
