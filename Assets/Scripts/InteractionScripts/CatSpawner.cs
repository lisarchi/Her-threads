using UnityEngine;

public class CatSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _catPrefab;
    [SerializeField] private float _followSpeed = 5f;
    [SerializeField] private float _spawnDistance = 2f;
    [SerializeField] private float _destroyDelay = 10f;
    [SerializeField] private Vector3 _offset;
    private GameObject _currentCat;
    private Transform _player;
    private float _timer = 0f;

    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").transform;
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

        if (_currentCat != null)
        {
            FollowPlayer();
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
        // Создаем новый куб на заданном расстоянии от игрока
        Vector3 spawnPosition = _player.position + _player.forward * _spawnDistance;
        _currentCat = Instantiate(_catPrefab, spawnPosition, Quaternion.identity);
    }

    void DestroyCat()
    {
        // Удаляем текущий куб
        Destroy(_currentCat);
        _currentCat = null;
    }

    void FollowPlayer()
    {
        // Направляем куб за спину игрока с использованием линейной интерполяции для плавного перемещения
        Vector3 targetPosition = _player.position + _player.forward + _offset;
        _currentCat.transform.position = Vector3.Lerp(_currentCat.transform.position, targetPosition,  _followSpeed * Time.deltaTime);
    }
}
