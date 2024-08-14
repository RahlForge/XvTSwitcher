using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XvTSwitcher.Manifests.Interfaces;

namespace XvTSwitcher.LstBuilder.Interfaces
{
  public interface ILstBuilder
  {
    string GamePath { get; }
    void LoadManifests(string gameDirectory, string modName = "DefaultManifest");
    void BuildLstsFromManifest(IManifest manifest);
    void BuildLst(string targetPath, ILst lst);
    void BuildHeader(StreamWriter streamWriter, IHeader header);
  }
}
