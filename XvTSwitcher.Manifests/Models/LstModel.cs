using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XvTSwitcher.Manifests.Interfaces;

namespace XvTSwitcher.Manifests.Models
{
  public class LstModel : ILst
  {
    public string Name { get; protected set; } = string.Empty;

    public string? MissionCount { get; protected set; }

    public List<IHeader> Headers { get; protected set; } = [];

    public List<string>? DescriptionText { get; protected set; }
  }
}
