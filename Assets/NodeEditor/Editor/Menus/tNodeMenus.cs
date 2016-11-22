using UnityEngine;
using UnityEditor;
using System.Collections;

public static class tNodeMenus
{
    [MenuItem("Node Editor/Launch Editor")]
    public static void InitNodeEditor()
    {
        tNodeEditorWindow.InitEditorWindow();
    }
}