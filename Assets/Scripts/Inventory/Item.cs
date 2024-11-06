using UnityEngine;
using UnityEngine.Events;

public class Item : MonoBehaviour
{
    [SerializeField] internal string _nameItem;
    [SerializeField] internal int _idItem;
    [SerializeField] internal bool _isStacable;
    [Multiline(5), SerializeField]
    internal string _descriptionItem;
    [SerializeField] internal Sprite _icon;

    internal int _countItem;
    public UnityEvent ItemEvent;
}
