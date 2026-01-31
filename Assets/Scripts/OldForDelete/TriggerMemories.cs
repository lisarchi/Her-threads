using UnityEngine;

public class TriggerMemories : MonoBehaviour
{
    [SerializeField] private GameObject _memoriesBoarder;
    
    private Transform _boarderPosition;
    void Start()
    {
        _boarderPosition = GameObject.FindGameObjectWithTag("BoarderPosition").GetComponent<Transform>();
    }
    void OnTriggerEnter(Collider colMem)
    {
        if (colMem.CompareTag("Player"))
        {
            Instantiate(_memoriesBoarder, _boarderPosition.position, Quaternion.identity);

            Destroy(gameObject);
        }
    }
}