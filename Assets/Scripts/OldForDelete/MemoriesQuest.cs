using UnityEngine;

public class MemoriesQuest : MonoBehaviour
{
    [SerializeField] private GameObject _boarderDestroyer;
    
    private Transform _destroyerPosition;

    void Start()
    {
        _destroyerPosition = GameObject.FindGameObjectWithTag("FrontBorder").GetComponent<Transform>();
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag.Equals("Player"))
        {
            Instantiate(_boarderDestroyer, _destroyerPosition.position, Quaternion.identity);

            Destroy(GameObject.FindGameObjectWithTag("ButtonCreater"));
        }
    }
}
