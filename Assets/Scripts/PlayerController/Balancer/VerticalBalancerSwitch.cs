using UnityEngine;

public class VerticalBalancerSwitch : MonoBehaviour
{
    internal bool _inVerticalBalancer;
    private void Start()
    {
        _inVerticalBalancer = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("VerticalBalancerZone"))
        {
            print("inVertBalancerZone");
            _inVerticalBalancer = true;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("VerticalBalancerZone"))
        {
            print("outVertBalancerZone");
            _inVerticalBalancer = false;
        }

    }
}
