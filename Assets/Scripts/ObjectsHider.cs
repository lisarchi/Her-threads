using UnityEngine;

public class ObjectsHider : MonoBehaviour
{
    [SerializeField] private GameObject[] _objectsForHide;

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            HideObjects();
        }
    }
    public void OnTriggerExit(Collider col) 
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            ShowObjects();
        }
    }

    internal void HideObjects()
    {
        foreach (GameObject obj in _objectsForHide)
        {
            obj.GetComponent<MeshRenderer>().enabled = false;
        }
    }

    internal void ShowObjects()
    {
        foreach (GameObject obj in _objectsForHide)
        {
            obj.GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
