using UnityEngine;

[RequireComponent(typeof(Outline))]
public class TelekinesisTargetHighlighter : MonoBehaviour
{
    private Material originalMat;
    private Material highlightMat;
    private Outline rend;

    private void Awake()
    {
        rend = GetComponent<Outline>();
    }

    internal void SetHighlight(bool state)
    {
        if (rend == null) return;

        if (state)
            rend.OutlineMode = Outline.Mode.OutlineVisible;
        //rend.material = highlightMat;
        else
            rend.OutlineMode = Outline.Mode.OutlineHidden;
            //rend.material = originalMat;
    }
}
