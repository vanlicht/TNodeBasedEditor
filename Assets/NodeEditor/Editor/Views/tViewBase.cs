using UnityEngine;
#if Unity_Editor
using UnityEditor;
#endif
using System;
using System.Collections;

[Serializable]
public class tViewBase
{
    #region Public Variables
    public string viewTitle;
    public Rect viewRect;
    #endregion

    #region Protected Variables
    private GUISkin viewSkin;
    #endregion

    #region Constructors
    public tViewBase(string title)
    {
        viewTitle = title;
    }
    #endregion

    #region Main Methods
    public virtual void UpdateView(Rect editorRect, Rect percentageRect)
    {
        //Debug.Log("Updating Base View Class");
        viewRect = new Rect
            (
            editorRect.x * percentageRect.x,
            editorRect.y * percentageRect.y,
            editorRect.width * percentageRect.width,
            editorRect.height * percentageRect.height
            );
    }

    public virtual void ProcessEvents() { }

    #endregion

    #region Utility Methods
    protected void GetEditorSkin() { }
    #endregion
}
