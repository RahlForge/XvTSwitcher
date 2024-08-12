using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XvTSwitcher.Interfaces
{
  interface IInstallationManager
  {
    string ActiveInstallationName { get; }
    List<string> Installations { get; }
    string Add(string newInstallationName);
    string Update(string installationName);
    string Delete(string installationName);

  }
}
