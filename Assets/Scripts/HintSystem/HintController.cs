using UnityEngine;

public class HintController : MonoBehaviour
{
    public PathFinder pathFinder;
    public HintLine hintLine;

    void Update()
    {
        if (UserInput.instance.HintInput)
        {
            var path = pathFinder.GetPath();
            hintLine.DrawPath(path);
            hintLine.gameObject.SetActive(true);
        }

        if (UserInput.instance.JumpTrigerred)
        {
            hintLine.gameObject.SetActive(false);
        }
    }
}
