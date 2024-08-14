using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XvTSwitcher.Manifests.Interfaces;

namespace XvTSwitcher.Manifests.Models
{
  public class HeaderModel : IHeader
  {
    public string? HeaderText { get; protected set; }

    public List<IMission> Missions => throw new NotImplementedException();
  }
}
