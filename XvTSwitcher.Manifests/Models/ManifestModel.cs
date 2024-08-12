using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XvTSwitcher.Manifests.Interfaces;

namespace XvTSwitcher.Manifests.Models
{
  public class ManifestModel : IManifest
  {
    public string TargetDirectory { get; protected set; } = $"./";
    public List<ILst> Lsts { get; protected set; } = [];

    public ManifestModel() { }
  }
}
