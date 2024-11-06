using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private float _jumpStrength = 10;
    [SerializeField] private GroundCheck _groundCheck;

    private Rigidbody _rb;
    
    public event System.Action Jumped;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void LateUpdate()
    {
        if (Time.timeScale == 0)
            return;

        if (UserInput.instance.JumpTrigerred && (!_groundCheck || _groundCheck.IsGrounded))
        {
            _rb.AddForce(Vector3.up * 100 * _jumpStrength);
            Jumped?.Invoke();
        }
    }
}
