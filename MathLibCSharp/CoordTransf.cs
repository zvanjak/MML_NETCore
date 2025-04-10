using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MML
{
  public interface ICoordTransf<_VecFrom, _VecTo>
  {
    public _VecTo transf(_VecFrom v);

    public _VecFrom transfInverse(_VecTo v);

    //virtual IScalarFunction<N>& coordTransfFunc(int i) = 0;
    //virtual IScalarFunction<N>& inverseCoordTransfFunc(int i) = 0;
  }

  public class CoordTransfSphericalToCartesian : ICoordTransf<Vector3Cartesian, Vector3Cartesian>
  {
    public Vector3Cartesian transf(Vector3Cartesian v)
    {
      return new Vector3Cartesian();
    }
    public Vector3Cartesian transfInverse(Vector3Cartesian v)
    {
      return new Vector3Cartesian();
    }
  }
}
