using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

[CustomEditor(typeof(AnserDatabase))]
public class AnserEditor : Editor
{
   
    private AnserDatabase anserDatabase;

    private void OnEnable()
    {
        anserDatabase = target as AnserDatabase;//allow enter database
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();//Creat button at database in Unity
        if (GUILayout.Button("ansApply", GUILayout.Height(30)))
        {
            AnserApply();
        }
    }
    private void AnserApply()
    {
        string filePath = Path.Combine(Application.dataPath, "RealAnser.cs");//create file to save the info pages data
        string code = "public enum applyAnser{";
        foreach (Anser ans in anserDatabase.gameAnser)
        {
            code += ans.anserID + ",";
        }
        code += "}";
        File.WriteAllText(filePath, code);
        AssetDatabase.ImportAsset("Assets/RealAnser.cs");

    }
}


