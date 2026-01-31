using UnityEngine;

public class CatSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _catPrefab;
    [SerializeField] private float _destroyDelay = 20000f;
    private GameObject _currentCat;
    private Transform _catSpawnPoint;
    private float _timer = 0f;
    
    private void Start()
    {
        _catSpawnPoint = GameObject.FindGameObjectWithTag("CatSpawnPoint").transform;
    }

    private void Update()
    {
        if (_currentCat == null && UserInput.instance.CatSpawnInput)
        {
            SpawnCat();
        }
        
        else if (_currentCat != null && UserInput.instance.CatSpawnInput)
        {
            DestroyCat();
        }

        if (UserInput.instance.MoveInputForward !=0 || UserInput.instance.MoveInputBack != 0)
        {
            _timer = _destroyDelay;
        }
        else
        {
            _timer -= Time.deltaTime;
            if (_timer <= 0 && _currentCat != null)
            {
                DestroyCat();
            }
        }
    }

    void SpawnCat()
    {
        Vector3 spawnPosition = _catSpawnPoint.position;
        _currentCat = Instantiate(_catPrefab, spawnPosition, Quaternion.identity);
    }

    void DestroyCat()
    {
        Destroy(_currentCat);
        _currentCat = null;
    }
}
