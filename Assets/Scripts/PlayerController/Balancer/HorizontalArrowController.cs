using UnityEngine;

public class HorizontalArrowController : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] internal int _arrowDirection;
    [SerializeField] private float _moveSpeed = 1.0f;
    private float _timeOfChangeDirection = 1;

    HorizontalBalancerSwitch _horizontalBalancerSwitch;

    private void Awake()
    {
        _horizontalBalancerSwitch = _player.GetComponent<HorizontalBalancerSwitch>();
    }

    private void FixedUpdate()
    {
        MoveArrow();
        SetDirection();

        if (_horizontalBalancerSwitch._inHorizontalBalancer == true)
        {
            if (_arrowDirection > 0)
            {
                if (UserInput.instance.MoveInputDown > 0)
                {
                    BalanceHorizontalArrow();
                }
            }

            if (_arrowDirection < 0)
            {
                if (UserInput.instance.MoveInputUp > 0)
                {
                    BalanceHorizontalArrow();
                }
            }
        }
        if (_horizontalBalancerSwitch._inHorizontalBalancer == false)
        {
            transform.localPosition = Vector3.zero;
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

    internal void MoveArrow()
    {
        transform.localPosition = Vector3.Lerp(transform.localPosition, new Vector3(transform.localPosition.x, transform.localPosition.y + (1 * _arrowDirection), transform.localPosition.z), _moveSpeed * Time.fixedDeltaTime);
        if (transform.localPosition.y > 1)
        {
            _arrowDirection = -1;
        }

        if (transform.localPosition.y < -1)
            _arrowDirection = 1;

        if (transform.localPosition.y > 0.9f)
        {
            print("died 1");
        }
        if (transform.localPosition.y < -0.9f)
        {
            print("died 2");
        }
    }
    private void BalanceHorizontalArrow()
    {
        if (_arrowDirection > 0)
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, new Vector3(transform.localPosition.x, transform.localPosition.y + (-1 * _arrowDirection), transform.localPosition.z), _moveSpeed *1.5f * Time.fixedDeltaTime);
        }

        if (_arrowDirection < 0)
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, new Vector3(transform.localPosition.x, transform.localPosition.y + (-1 * _arrowDirection), transform.localPosition.z), _moveSpeed * 1.5f * Time.fixedDeltaTime);
        }
    }
}
