using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XvTSwitcher.Manifests.Interfaces
{
  public interface ILst
  {
    string Name { get; }
    string? MissionCount { get; }
    List<IHeader> Headers { get; }
    List<string>? DescriptionText { get; }
  }
}
