using UnityEngine;

public class DemonMovement : MonoBehaviour
{
    private HealthBar _healthBar;
    [SerializeField] private float _demonSpeed = 0.2f;
    [SerializeField] private float _lengthRay;
    [SerializeField] private Vector3 _offset;
    
    private Transform _player;
    
    
    private void Start()
    {
       _healthBar = GameObject.FindGameObjectWithTag("HealthBar").GetComponent<HealthBar>();
       _player = GameObject.FindGameObjectWithTag("Eyes").GetComponent<Transform>();
    }

    private void Update()
    {
        _healthBar.Damage();

    }
    private void FixedUpdate()
    {
        transform.position = Vector3.Slerp(transform.position, _player.position + _offset, _demonSpeed * Time.fixedDeltaTime);
        transform.LookAt(_player.position);
        Debug.DrawRay(transform.position, transform.forward * _lengthRay, Color.red);
    }   
}
