using UnityEngine;

public class HorizontalBalancerSwitch : MonoBehaviour
{
    internal bool _inHorizontalBalancer;
    private void Start()
    {
        _inHorizontalBalancer = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("HorizontalBalancerZone"))
        {
            print("inHorBalancerZone");
            _inHorizontalBalancer = true;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("HorizontalBalancerZone"))
        {
            print("outHorBalancerZone");
            _inHorizontalBalancer = false;
        }

    }
}
