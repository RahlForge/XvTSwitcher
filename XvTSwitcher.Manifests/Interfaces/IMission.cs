using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XvTSwitcher.Manifests.Interfaces
{
  public interface IMission
  {
    string ID { get; }
    string Filename { get; }
    string Name { get; }
  }
}
