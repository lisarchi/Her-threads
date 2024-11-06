using UnityEngine;

public class TriggerDemons : MonoBehaviour
{
    [SerializeField] GameObject _demon;
    [SerializeField] Vector3 _offset;
    private Transform _demonPosition;

    void Start()
    {
        _demonPosition = GameObject.FindGameObjectWithTag("BoarderPosition").GetComponent<Transform>();
    }
        void OnTriggerEnter(Collider colDemon)
    {
        if (colDemon.tag.Equals("Player"))
        {
            Instantiate(_demon, _demonPosition.position + _offset, Quaternion.identity);

            Destroy(gameObject);
        }
    }


}