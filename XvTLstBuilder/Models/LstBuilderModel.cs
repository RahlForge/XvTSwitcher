using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using XvTSwitcher.LstBuilder.Interfaces;
using XvTSwitcher.Manifests.Interfaces;

namespace XvTSwitcher.LstBuilder.Models
{
  public class LstBuilderModel : ILstBuilder
  {
    public string GamePath { get; protected set; } = string.Empty;

    public void BuildLstsFromManifest(IManifest manifest)
    {
      var targetPath = Path.Combine(GamePath, manifest.TargetDirectory);
      manifest.Lsts.ForEach(lst => BuildLst(targetPath, lst));
    }

    public void BuildLst(string targetPath, ILst lst)
    {
      var lstFile = File.CreateText($"{targetPath}/{lst.Name}.lst");
      
      if (string.IsNullOrEmpty(lst.MissionCount) == false)
        lstFile.WriteLine(lst.MissionCount);

      lst.Headers.ForEach(header => BuildHeader(lstFile, header));

      lst.DescriptionText?.ForEach(lstFile.WriteLine);
    }

    public void BuildHeader(StreamWriter streamWriter, IHeader header)
    {
      if (string.IsNullOrEmpty(header.HeaderText) == false)
      {
        streamWriter.WriteLine($"""
          //
          {header.HeaderText}
          //
          """);
      }

      header.Missions.ForEach(mission =>
      {
        if (string.IsNullOrEmpty(mission.ID) == false)
          streamWriter.WriteLine(mission.ID);

        streamWriter.WriteLine(mission.Filename);

        if (string.IsNullOrEmpty(mission.Name) == false)
          streamWriter.WriteLine(mission.Name);
      });
    }

    public void LoadManifests(string gameDirectory, string modName = "DefaultManifest")
    {
      GamePath = $"{gameDirectory}/BalanceOfPower/";
      var modManifest = File.ReadAllText($"{GamePath}{modName}.json") 
        ?? throw new FileFormatException($"{modName}.json is not a properly formatted manifest");
      
      var manifests = JsonSerializer.Deserialize<List<IManifest>>(modManifest)
        ?? throw new Exception("Unable to deserialize manifest");

      manifests.ForEach(BuildLstsFromManifest);
    }
  }
}
