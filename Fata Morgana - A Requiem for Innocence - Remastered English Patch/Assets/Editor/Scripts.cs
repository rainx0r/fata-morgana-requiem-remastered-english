using UnityEditor;
using UnityEditor.Sprites;
using UnityEngine;
using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class EditorScripts
{
    [Serializable]
    public struct AssetBundleEntry
    {
        public string AssetsPath;
        public string BundlePath;
    }

    [Serializable]
    public class AssetBundleConfig
    {
        public string BundleName;
        public AssetBundleEntry[] Entries;
    }

    [MenuItem("Project/Build AssetBundles")]
    static void BuildAllAssetBundles()
    {
        string assetBundleDirectory = "../build/FataMorganaReq_Data/StreamingAssets/AssetBundles/Windows64";
        if (!Directory.Exists(assetBundleDirectory))
        {
            Directory.CreateDirectory(assetBundleDirectory);
        }

        /* bgimage */
        var bgImageBundleConfig = JsonUtility.FromJson<AssetBundleConfig>(File.ReadAllText("Assets/Editor/bgimage_en.json"));
        var bgAddressableNames = new List<string>();
        var bgAssetNames = new List<string>();
        foreach (var entry in bgImageBundleConfig.Entries)
        {
            bgAssetNames.Add(entry.AssetsPath);
            bgAddressableNames.Add(entry.BundlePath);
        }
        var bgimage_en = new AssetBundleBuild {
            assetBundleName = bgImageBundleConfig.BundleName,
            assetNames = bgAssetNames.ToArray(),
            addressableNames = bgAddressableNames.ToArray()
        };

        /* patch */
        var PatchBundleConfig = JsonUtility.FromJson<AssetBundleConfig>(File.ReadAllText("Assets/Editor/patch.json"));
        var patchAddressableNames = new List<string>();
        var patchAssetNames = new List<string>();
        foreach (var entry in PatchBundleConfig.Entries)
        {
            patchAssetNames.Add(entry.AssetsPath);
            patchAddressableNames.Add(entry.BundlePath);
        }
        var patch = new AssetBundleBuild {
            assetBundleName = PatchBundleConfig.BundleName,
            assetNames = patchAssetNames.ToArray(),
            addressableNames = patchAddressableNames.ToArray()
        };

        BuildPipeline.BuildAssetBundles(assetBundleDirectory, new[] { bgimage_en, patch },
                                        BuildAssetBundleOptions.ChunkBasedCompression, 
                                        BuildTarget.StandaloneWindows64);
    }
}