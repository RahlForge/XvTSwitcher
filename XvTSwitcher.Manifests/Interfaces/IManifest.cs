using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XvTSwitcher.Manifests.Interfaces
{
  public interface IManifest
  {
    string TargetDirectory { get; }
    List<ILst> Lsts { get; }
  }
}
