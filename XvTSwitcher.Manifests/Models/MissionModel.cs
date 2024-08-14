using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XvTSwitcher.Manifests.Interfaces;

namespace XvTSwitcher.Manifests.Models
{
  public class MissionModel : IMission
  {
    public string? ID { get; protected set; }

    public string Filename { get; protected set; } = string.Empty;

    public string? Name { get; protected set; }
  }
}
