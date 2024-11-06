using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Sprint sprint;

    private Rigidbody _rb;
    Flip flip;
    Vector3ZoneSwitch v3Zone;
    VerticalBalancerSwitch verticalBalancerSwitch;
    HorizontalBalancerSwitch horizontalBalancerSwitch;

    private void Awake()
    {
        flip = GetComponent<Flip>();
        _rb = GetComponent<Rigidbody>();
        v3Zone = GetComponent<Vector3ZoneSwitch>();
        verticalBalancerSwitch = GetComponent<VerticalBalancerSwitch>();
        horizontalBalancerSwitch = GetComponent<HorizontalBalancerSwitch>();
    }
    void FixedUpdate()
    {
        if (Time.timeScale == 0)
            return;

        //если вертикальный балансир отключен, то флип работает (при включении движение только влево-вправо, без поворотов)

        float moveForward = UserInput.instance.MoveInputForward;
        _rb.AddForce(Vector3.right * moveForward * sprint._girlSpeed, ForceMode.Impulse);

        if (moveForward > 0 && verticalBalancerSwitch._inVerticalBalancer == false)
        {
            flip.FlipDirection("right");
        }

        float moveBack = UserInput.instance.MoveInputBack;
        _rb.AddForce(Vector3.left * moveBack * sprint._girlSpeed, ForceMode.Impulse);

        if (moveBack > 0 && verticalBalancerSwitch._inVerticalBalancer == false)
        {
            flip.FlipDirection("left");
        }

        if (horizontalBalancerSwitch._inHorizontalBalancer != false)
        {
            //если горизонтальный балансир включен, то добавляется метод наклона и при сильном наклоне импульс в сторону наклона
            print("HorizontalBalancerOn");
        }

        if (verticalBalancerSwitch._inVerticalBalancer == false && horizontalBalancerSwitch._inHorizontalBalancer == false)
        {
            //если отключены балансиры, то автоматический поворот в сторону персонажа при бездействии включен
            if (moveForward == 0)
            {
                transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(transform.localRotation.x, 0.0f, transform.localRotation.z), (flip._rotationSpeed / 5.0f) * Time.fixedDeltaTime);
            }
        }

        if (v3Zone.inZone == true || verticalBalancerSwitch._inVerticalBalancer == true)
        {
            //если мы попадаем в 3д зону ИЛИ в зону вертикального балансира, то включается передвижение вперед назад
            //если попадаем только в зону балансира, то движения влево вправо остаются, но отключается флип

            float moveUp = UserInput.instance.MoveInputUp;
            _rb.AddForce(Vector3.forward * moveUp * sprint._girlSpeed, ForceMode.Impulse);
            if (moveUp > 0)
            {
                flip.FlipDirection("up");
            }

            float moveDown = UserInput.instance.MoveInputDown;
            _rb.AddForce(Vector3.back * moveDown * sprint._girlSpeed, ForceMode.Impulse);

            if (moveDown > 0)
            {
                flip.FlipDirection("down");
            }
            if (verticalBalancerSwitch._inVerticalBalancer == true)
            {
                //если вертикальный балансир включен, тодобавляется метод наклона и при сильном наклоне импульс в сторону наклона
                print("verticalBalancerOn");
            }

        }

    }
}
