using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MML
{
  public interface IFunction<_RetType, _ArgType>
  {
    public _RetType Val(_ArgType x);
  }

  public interface IRealFunction : IFunction<double, double>
  {
    //public double Val(double x);
  };

  public class RealFunction : IRealFunction
  {
    public delegate double FuncPtr(double x);
    FuncPtr _localFunc;

    public RealFunction(FuncPtr inFuncPtr) 
    {
      _localFunc = inFuncPtr;
    }
    public double Val(double x)
    {
      return _localFunc(x);
    }
  };

  public class ScalarFunction : IFunction<double, Vector>
  {
    public delegate double FuncPtr(Vector x);
    FuncPtr _localFunc;

    public ScalarFunction(FuncPtr inFuncPtr)
    {
      _localFunc = inFuncPtr;
    }
    public double Val(Vector x)
    {
      return _localFunc(x);
    }
  };

  public class VectorFunction : IFunction<Vector, Vector>
  {
    public delegate Vector FuncPtr(Vector x);
    FuncPtr _localFunc;

    public VectorFunction(FuncPtr inFuncPtr)
    {
      _localFunc = inFuncPtr;
    }
    public Vector Val(Vector x)
    {
      return _localFunc(x);
    }
  };

  public class ParametricCurve : IFunction<Vector, double>
  {
    public delegate Vector FuncPtr(double x);
    FuncPtr _localFunc;

    public ParametricCurve(FuncPtr inFuncPtr)
    {
      _localFunc = inFuncPtr;
    }
    public Vector Val(double x)
    {
      return _localFunc(x);
    }
  }

  public class Surface : IFunction<Vector, Vector2>
  {
    public delegate Vector FuncPtr(Vector2 x);
    FuncPtr _localFunc;

    public Surface(FuncPtr inFuncPtr)
    {
      _localFunc = inFuncPtr;
    }
    public Vector Val(Vector2 x)
    {
      return _localFunc(x);
    }
  };
}
