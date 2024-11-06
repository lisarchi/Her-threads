using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMemories : MonoBehaviour
{
    void OnTriggerEnter(Collider colEnd)
    {
        if (colEnd.CompareTag("Player"))
        {
            Destroy(GameObject.FindGameObjectWithTag("Boarder"));
        }
    }
}
