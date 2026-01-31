using System.Collections;
using UnityEngine;

public class ObjectActivator : MonoBehaviour
{
    [SerializeField] GameObject _objectToActivate;
    [SerializeField] float _delay;

    private void Start()
    {
        if (_objectToActivate != null)
        {
            _objectToActivate.SetActive(false);
            StartCoroutine(ActivateObjectAfterDelay());
        }
        else
        {
            Debug.LogError("Не назначен объект для активации");
        }
    }

    IEnumerator ActivateObjectAfterDelay()
    {
        yield return new WaitForSeconds(_delay);
        _objectToActivate.SetActive(true); 
    }
}
