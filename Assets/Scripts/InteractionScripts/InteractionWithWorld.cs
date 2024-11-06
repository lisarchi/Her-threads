using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionWithWorld : MonoBehaviour
{
    private Transform _player;


    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    internal void InteractWithObject()
    {

    }
    internal void RepulsionObject()
    {

    }
}
