using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Inventory : MonoBehaviour
{
    [SerializeField] private GameObject _cellContainer;
    [SerializeField] private GameObject _messageManager;
    [SerializeField] private GameObject _message;
    [HideInInspector] public List<Item> item;
    public GameObject DataBase;

    private void Start()

    {
        _cellContainer.SetActive(false);
        //Перебор и присваивание каждой ячейке свою айдиху
        for (int i = 0; i < _cellContainer.transform.childCount; i++)
        {
            _cellContainer.transform.GetChild(i).GetComponent<CurrentItem>()._indexCell = i;
        }

        item = new List<Item>();

        for (int i = 0; i < _cellContainer.transform.childCount; i++)
        {
            item.Add(gameObject.AddComponent<Item>());
        }
    }

    private void Update()
    {
        OpenInventory();

        if (UserInput.instance.UsingInput)
        {
            print("Taked");
            //Подбор предмета по рейкасту с камеры в коллайдер предмета
            Ray ray = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 15f))
            {
                if (hit.collider.GetComponent<Item>())
                {
                    Item currentItem = hit.collider.GetComponent<Item>();
                    ShowMessage(currentItem);
                    AddItem(hit.collider.GetComponent<Item>());
                }
            }
        }
    }

    private void AddItem (Item currentItem)
    {
        if (currentItem._isStacable)
        {
            AddStackableItem(currentItem);
        }
        else
        {
            AddUnstackableItem(currentItem);
        }
    }

    private void AddUnstackableItem(Item currentItem)
    {
        for (int i = 0; i < item.Count; i++)
        {
            if (item[i]._idItem == 0)
            {
                item[i] = currentItem;
                item[i]._countItem = 1;
                DisplayItems();
                Destroy(currentItem.gameObject);
                break;
            }
        }
    }

    private void AddStackableItem (Item currentItem)
    {
        for (int i = 0; i < item.Count; i++)
        {
            if (item[i]._idItem == currentItem._idItem)
            {
                item[i]._countItem++;
                DisplayItems();
                Destroy(currentItem.gameObject);
                return;
            }
        }
        AddUnstackableItem(currentItem);
    }

    private void ShowMessage(Item currentItem)
    {
        
        GameObject msgObj = Instantiate(_message);
        msgObj.transform.SetParent(_messageManager.transform);
        Image msgImg = msgObj.transform.GetChild(0).GetComponent<Image>();
        msgImg.sprite = currentItem._icon;
        TMP_Text msgtxt = msgObj.transform.GetChild(1).GetComponent<TMP_Text>();
        msgtxt.text = currentItem._nameItem;
    }
    
    private void OpenInventory()
    {
        if (UserInput.instance.InventoryInput)
        {
            if (_cellContainer.activeSelf)
            {
                _cellContainer.SetActive(false);
                //Time.timeScale = 1.0f;
                Cursor.visible = false;
            }
            else
            {
                _cellContainer.SetActive(true);
                //Time.timeScale = 0.0f;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }
    
    public void DisplayItems()
    {
        for (int i = 0; i< item.Count; i++)
        {
            Transform cell = _cellContainer.transform.GetChild(i);
            Transform icon = cell.GetChild(0);
            Transform count = icon.GetChild(0);

            TMP_Text txt = count.GetComponent<TMP_Text>();
            Image img = icon.GetComponent<Image>();
           
            if (item[i]._idItem !=0)
            {
                img.enabled = true;
                img.sprite = item[i]._icon;
                if (item[i]._countItem>1)
                {
                    txt.text = item[i]._countItem.ToString();
                }
                else
                {
                    txt.text = null;
                }
            }
            else
            {
                img.enabled = false;
                img.sprite = null;
                txt.text = null;
            }
        }
    }
}

