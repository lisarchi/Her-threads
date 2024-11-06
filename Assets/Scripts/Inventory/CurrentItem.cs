using UnityEngine;
using UnityEngine.EventSystems;

public class CurrentItem : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Vector3 _offset;
    internal int _indexCell;
    internal GameObject _inventoryObject;
    private Transform _player;
    
    Inventory _inventory; 

    void Start()
    {
        _inventoryObject = GameObject.FindGameObjectWithTag("InventoryManager");
        _inventory = _inventoryObject.GetComponent<Inventory>();
        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            _inventory.item[_indexCell].ItemEvent.Invoke();
        }
            if (eventData.button == PointerEventData.InputButton.Right)
        {
            Drop();
            Remove();
        }
    }
    void Remove()
    {
        if (_inventory.item[_indexCell]._idItem !=0)
            {
                if (_inventory.item[_indexCell]._countItem > 1)
                {
                    _inventory.item[_indexCell]._countItem--;
                }
                else
                {
                    _inventory.item[_indexCell] = gameObject.AddComponent<Item>();
                }
                _inventory.DisplayItems();
            }
    }
    void Drop()
    {
        if (_inventory.item[_indexCell]._idItem != 0)
        {
            for (int i = 0; i < _inventory.DataBase.transform.childCount; i++)
            {
                Item item = _inventory.DataBase.transform.GetChild(i).GetComponent<Item>();
                if (item)
                {
                    if (_inventory.item[_indexCell]._idItem == item._idItem)
                    {
                        GameObject _droppedObj = Instantiate(item.gameObject);
                        _droppedObj.transform.position = _player.transform.position + _offset;
                    }
                }
            }
        }
    }
}