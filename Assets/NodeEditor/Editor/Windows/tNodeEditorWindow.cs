using UnityEngine;
using UnityEditor;
using System.Collections;

public class tNodeEditorWindow : EditorWindow
{
    #region Variables
    public static tNodeEditorWindow curWindow;
    public tNodePropertyView propertyView;
    public tNodeWorkView workView; 

    #endregion

    #region Main Methods
    public static void InitEditorWindow()
    {
        curWindow = (tNodeEditorWindow)EditorWindow.GetWindow<tNodeEditorWindow>();
        curWindow.titleContent = new GUIContent("Node Editor");
        createViews();
    }

    void OnEnable()
    {
        Debug.Log("Enabled Window");
    }

    void OnDestroy()
    {
        Debug.Log("Disabled Window");
    }

    void Update()
    {
        Debug.Log("Updating Window");

    }

    void OnGUI()
    {
        if(propertyView == null || workView == null)
        {
            createViews();
            return;
        }
        EditorGUILayout.LabelField("This is our node editor...");  
        workView.UpdateView(position);
        propertyView.UpdateView(position);

        Repaint();
    }
    #endregion

    #region Utility Methods
    static void createViews()
    {
        if (curWindow != null)
        {
            curWindow.propertyView = new tNodePropertyView();
            curWindow.workView = new tNodeWorkView();
        }
        else
        {
            curWindow = (tNodeEditorWindow) EditorWindow.GetWindow<tNodeEditorWindow>();
        }
    }
    #endregion

}
