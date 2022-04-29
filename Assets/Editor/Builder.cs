using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Builder : MonoBehaviour
{
   public static void Build()
    {
        BuildPlayerOptions options = new BuildPlayerOptions();
        
        options.options = BuildOptions.None;
        options.scenes = new string[] { "Assets/Scenes/SampleScene.unity" };
        options.target = BuildTarget.StandaloneWindows;
        options.locationPathName = "Build";
        options.targetGroup = BuildTargetGroup.Standalone;
        
        BuildPipeline.BuildPlayer(options);
    }
}
