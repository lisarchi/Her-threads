using UnityEngine;

public class VerticalArrowController : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private float _rotationSpeed = 0.8f;
    [SerializeField] internal int _arrowDirection;
    private float _timeOfChangeDirection = 1;
    private float _rotationMax = 89.9f;

    VerticalBalancerSwitch _verticalBalancerSwitch;

    private void Awake()
    {
        _verticalBalancerSwitch = _player.GetComponent<VerticalBalancerSwitch>();
    }

    private void FixedUpdate()
    {
        RotationArrow();
        SetDirection();

        if (_verticalBalancerSwitch._inVerticalBalancer == true)
        {
            if (_arrowDirection < 0)
            {
                if (UserInput.instance.MoveInputBack > 0)
                {
                    BalanceVerticalArrow();
                }
            }

            if (_arrowDirection > 0)
            {
                if (UserInput.instance.MoveInputForward > 0)
                {
                    BalanceVerticalArrow();
                }
            }
        }
    }

    private void SetDirection()
    {
        if (_timeOfChangeDirection > 0)
        {
            _timeOfChangeDirection -= Time.deltaTime;
        }
        if (_timeOfChangeDirection <= 0)
        {
            _timeOfChangeDirection = 1;
            var array = new int[] { -1, 1 };
            var randomElement = array[Random.Range(0, array.Length)];
            _arrowDirection = randomElement;
        }
    }

    internal void RotationArrow()
    {
        transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(transform.localRotation.x, transform.localRotation.y, transform.localRotation.z + _rotationMax * _arrowDirection), _rotationSpeed * Time.fixedDeltaTime);

        if (transform.localRotation.z > 60.0f)
        {
            print("died right"); 
        }

        if (transform.localRotation.z < -60.0f)
        {
            print("died left");
        }
    }

    private void BalanceVerticalArrow()
    {
        transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(transform.localRotation.x, transform.localRotation.y, -89.9f * _arrowDirection), _rotationSpeed * 1.5f * Time.fixedDeltaTime);
    }
}
