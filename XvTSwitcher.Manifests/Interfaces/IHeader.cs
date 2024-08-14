using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XvTSwitcher.Manifests.Interfaces
{
  public interface IHeader
  {
    string? HeaderText { get; }
    List<IMission> Missions { get; }
  }
}
