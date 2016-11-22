using UnityEngine;
#if Unity_Editor
using UnityEditor;
#endif
using System;
using System.Collections;
using System.Collections.Generic;

[Serializable]
public class tNodePropertyView : tViewBase
{
    #region Public Variables
    #endregion

    #region Prtected Variables
    #endregion

    #region Constructors
    public tNodePropertyView() : base("Property View") { }
    #endregion

    #region Main Methods
    public override void UpdateView(Rect editorRect, Rect percentageRect)
    {
        base.UpdateView(editorRect, percentageRect);
        Debug.Log("Updating Property View");
    }
    #endregion

    #region Utililty Methods
    #endregion
}
