using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MML
{
  public class Derivation
  {

    public static double NDer1(IRealFunction f, double x, double h)
    {
      double eps = 1e-16;

      double yh = f.Val(x + h);
      double y0 = f.Val(x);
      double diff = yh - y0;
      double error = 0;

      double ym = f.Val(x - h);
      double ypph = Math.Abs(yh - 2 * y0 + ym) / h;

      // h*|f''(x)|*0.5 + (|f(x+h)+|f(x)|)*eps/h
      error = ypph / 2 + (Math.Abs(yh) + Math.Abs(y0)) * eps / h;

      return diff / h;
    }
  }
}
