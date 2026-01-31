using UnityEngine;

public class BalancerPanel : MonoBehaviour
{
    [SerializeField] private GameObject _balancerPanelVertical;
    [SerializeField] private GameObject _balancerPanelHorizontal;
    [SerializeField] private GameObject _player;

    private VerticalBalancerSwitch verticalBalancerSwitch;
    private HorizontalBalancerSwitch horizontalBalancerSwitch;

    private void Awake()
    {
        verticalBalancerSwitch = _player.GetComponent<VerticalBalancerSwitch>();
        horizontalBalancerSwitch = _player.GetComponent<HorizontalBalancerSwitch>();
    }
    private void Start()
    {
        _balancerPanelVertical.SetActive(false);
    }

    private void FixedUpdate()
    {
        if (verticalBalancerSwitch._inVerticalBalancer == true)
        {
            _balancerPanelVertical.SetActive(true);
        }
        else 
        { 
            _balancerPanelVertical.SetActive(false); 
        }

        if (horizontalBalancerSwitch._inHorizontalBalancer == true)
        {
            _balancerPanelHorizontal.SetActive(true);
        }
        else
        {
            _balancerPanelHorizontal.SetActive(false);
        }
    }
}
