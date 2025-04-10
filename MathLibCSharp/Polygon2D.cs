using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MML
{
  public class Polygon2D
  {
    List<Point2Cartesian> _listPoints = new List<Point2Cartesian>();

    public List<Point2Cartesian> ListPoints { get => _listPoints; set => _listPoints = value; }

    public Polygon2D()
    {
    }
    public Polygon2D(List<Point2Cartesian> points)
    {
      _listPoints = points;
    }
  }
}
