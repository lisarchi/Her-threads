using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    [SerializeField] internal float _rotationSpeed = 10.0f;

    private float _flipAngle = 89.0f;


    internal void FlipDirection(string direction = "right")
    {

        if (direction == "right")
        {
            transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(transform.localRotation.x, _flipAngle * -1, transform.localRotation.z), _rotationSpeed * Time.fixedDeltaTime);
        }

        if (direction == "left")
        {
            transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(transform.localRotation.x, _flipAngle, transform.localRotation.z), _rotationSpeed * Time.fixedDeltaTime);
        }

        if (direction == "up")
        {
            transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(transform.localRotation.x, _flipAngle * -2, transform.localRotation.z), _rotationSpeed * Time.fixedDeltaTime);
        }

        if (direction == "down")
        {
            transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(transform.localRotation.x, _flipAngle * 0, transform.localRotation.z), _rotationSpeed * Time.fixedDeltaTime);
        }

    }
}
