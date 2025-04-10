using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MML
{
  public class Point2Cartesian
  {
    double _x;
    double _y;

    public Point2Cartesian(double x, double y)
    {
      X = x;
      Y = y;
    }

    public double X { get => _x; set => _x = value; }
    public double Y { get => _y; set => _y = value; }
  }

  public class Point2Polar
  {
    double _r;
    double _phi;

    public Point2Polar(double r, double phi)
    {
      R = r;
      Phi = phi;
    }

    public double R { get => _r; set => _r = value; }
    public double Phi { get => _phi; set => _phi = value; }
  }

  public class Point3Cartesian
  {
    double _x;
    double _y;
    double _z;

    public Point3Cartesian() { }
    public Point3Cartesian(double x, double y, double z)
    {
      X = x;
      Y = y;
      Z = z;
    }

    public double X { get => _x; set => _x = value; }
    public double Y { get => _y; set => _y = value; }
    public double Z { get => _z; set => _z = value; }

    public Point3Spherical GetSpherical()
    {
      Point3Spherical ret = new Point3Spherical();

      ret.R = Math.Sqrt(X * X + Y * Y + Z * Z);
      ret.Theta = Math.Atan2(Math.Sqrt(X * X + Y * Y), Z);
      ret.Phi =  Math.Atan2(Y, X);

      return ret;
    }
  }

  public class Point3Spherical
  {
    double _r;
    double _theta;
    double _phi;

    public Point3Spherical() { }

    public Point3Spherical(double r, double theta, double phi)
    {
      R = r;
      Theta= theta;
      Phi = phi;
    }

    public double R { get => _r; set => _r = value; }
    public double Phi { get => _phi; set => _phi = value; }
    public double Theta { get => _theta; set => _theta = value; }

    public Point3Cartesian  GetCartesian()
    {
      Point3Cartesian ret = new Point3Cartesian();

      ret.X = R * Math.Sin(Theta) * Math.Cos(Phi);
      ret.Y = R * Math.Sin(Theta) * Math.Sin(Phi);
      ret.Z = R * Math.Cos(Theta);

      return ret;
    }
  }
}
