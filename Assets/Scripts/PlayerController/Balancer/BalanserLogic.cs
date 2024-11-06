using System.Collections;
using UnityEngine;

public class BalanserLogic : MonoBehaviour
{
    [SerializeField] private float _speed = 0.1f;
    [SerializeField] internal int _movePower = 0;
    [SerializeField] private int _minPower = -4;
    [SerializeField] private int _maxPower = 4;
    private Rigidbody _rb;
    private float _timeOfChangePower;

    VerticalBalancerSwitch verticalBalancerSwitch;
    HorizontalBalancerSwitch horizontalBalancerSwitch;
    

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        verticalBalancerSwitch = GetComponent<VerticalBalancerSwitch>();
        horizontalBalancerSwitch = GetComponent<HorizontalBalancerSwitch>();
    }
    internal void FixedUpdate()
    {
        if (verticalBalancerSwitch._inVerticalBalancer == true)
        {
            
            ChangePower();
            _rb.AddForce(Vector3.right * _movePower * _speed, ForceMode.Impulse);
        }
        else 
        {
            _movePower = 0;
        }
        
    }

    private void ChangePower()
    {
        if (_timeOfChangePower > 0)
        {
            _timeOfChangePower -= Time.deltaTime;
        }
        if (_timeOfChangePower <= 0)
        {
            _timeOfChangePower = 1;
            _movePower = Random.Range(_minPower, _maxPower);

        }
    }
}
