using UnityEngine;

public class Vector3ZoneSwitch : MonoBehaviour
{
    public bool inZone;

    void Start()
    {
        inZone = false;
    }

    void OnTriggerEnter(Collider colZone)
    {
        if (colZone.CompareTag("Vector3Zone"))
        {
            print("inzone");
            inZone = true;
        }
    }
    void OnTriggerExit(Collider colZone)
    {
        if (colZone.CompareTag("Vector3Zone"))
        {
            print("outzone");
            inZone = false;
        }
    }
}
