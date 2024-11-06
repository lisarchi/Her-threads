using UnityEngine;

public class DestroyMessages : MonoBehaviour
{
    private float _timeOfDestroyMessage = 1f;
    private void Update()
    {
        Destroy(gameObject, _timeOfDestroyMessage);
    }
}
