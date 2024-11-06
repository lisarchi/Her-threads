using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashPanelDestroyer : MonoBehaviour
{
    void Update()
    {
        Destroy(gameObject, 2);
    }

   
}
