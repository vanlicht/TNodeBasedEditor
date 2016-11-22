using UnityEngine;
#if Unity_Editor
using UnityEditor;
#endif
using System.Collections;
using System.Collections.Generic;

public class tNodeWorkView : tViewBase
{
    #region Public Variables
    #endregion

    #region Protected Variables
    #endregion

    #region Constructors
    public tNodeWorkView() : base("Work View") { }
    #endregion

    #region Main Methods
    public override void UpdateView(Rect editorRect, Rect percentageRect)
    {
        base.UpdateView(editorRect, percentageRect);
        Debug.Log("Updating Work View");
    }
    #endregion

    #region Utililty Methods

    #endregion
}
