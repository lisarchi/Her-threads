using UnityEngine;

public class DirectionHint : MonoBehaviour
{
    [SerializeField] GameObject _hintLine;

    private Transform _hintPosition;
    private Vector3 _hintDistance = new Vector3(7.2f, 0.0f, 0.0f);
    
    private void Start()
    {
        _hintPosition = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void Update()
    {
        if (Time.timeScale == 0)
            return;

        if (UserInput.instance.HintPressed)
        {
            for (int j = 0; j < 5; j++)
                {
                    _hintPosition.position = _hintPosition.position + _hintDistance;

                    Instantiate(_hintLine, _hintPosition.position, Quaternion.identity);
                }
        }
        else if (!UserInput.instance.HintInput)
        {
            var hints = GameObject.FindGameObjectsWithTag("HintLine");
            for (var i = 0; i < hints.Length; i++)
            {
                Destroy(hints[i]);
            }
        }
    }
}
