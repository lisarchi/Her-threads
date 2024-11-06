using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalanserIncline : MonoBehaviour
{
    private Rigidbody _rb;

    VerticalBalancerSwitch verticalBalancerSwitch;
    HorizontalBalancerSwitch horizontalBalancerSwitch;
    BalanserLogic balancerLogic;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        verticalBalancerSwitch = GetComponent<VerticalBalancerSwitch>();
        horizontalBalancerSwitch = GetComponent<HorizontalBalancerSwitch>();
        balancerLogic = GetComponent<BalanserLogic>();
    }

    private void FixedUpdate()
    {
        if (verticalBalancerSwitch._inVerticalBalancer == true)
        {
            SetIncline();
        }
        else
        {
            transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(transform.localRotation.x, transform.localRotation.y, 0), Time.fixedDeltaTime);
        }
    }
    private void SetIncline()
    {
        if (balancerLogic._movePower == 0)
        {
            transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(transform.localRotation.x, transform.localRotation.y, 0), Time.fixedDeltaTime);
        }

        if (balancerLogic._movePower == -3)
        {
            transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(transform.localRotation.x, transform.localRotation.y, 15), Time.fixedDeltaTime);
        }

        if (balancerLogic._movePower == -2)
        {
            transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(transform.localRotation.x, transform.localRotation.y, 10), Time.fixedDeltaTime);
        }

        if (balancerLogic._movePower == -1)
        {
            transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(transform.localRotation.x, transform.localRotation.y, 5), Time.fixedDeltaTime);
        }

        if (balancerLogic._movePower == 1)
        {
            transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(transform.localRotation.x, transform.localRotation.y, -5), Time.fixedDeltaTime);
        }

        if (balancerLogic._movePower == 2)
        {
            transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(transform.localRotation.x, transform.localRotation.y, -10), Time.fixedDeltaTime);
        }

        if (balancerLogic._movePower == 3)
        {
            transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(transform.localRotation.x, transform.localRotation.y, -15), Time.fixedDeltaTime);
        }
    }

}
