using UnityEngine;

public class Sprint : MonoBehaviour
{
    [SerializeField] private float _speed = 0.6f;
    [SerializeField] private float _shiftSpeed = 1f;
    [SerializeField] private GroundCheck _groundCheck;

    internal float _girlSpeed;

    void FixedUpdate()
    {
        if (Time.timeScale == 0)
            return;

        if (UserInput.instance.SprintInput && (!_groundCheck || _groundCheck.IsGrounded))
        {
            _girlSpeed = _shiftSpeed;
        }
        else
        {
            _girlSpeed = _speed;
        }
    }
}
