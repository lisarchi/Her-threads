using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Sprite _selectedSlotImage;
    Sprite _slotImage;
    Image img;

    private void OnDisable()
    {
        img.sprite = _slotImage;
    }
    private void Start()
    {
        img= GetComponent<Image>();
        _slotImage = img.sprite;
    }
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        img.sprite = _selectedSlotImage;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        img.sprite = _slotImage;
    }
}
