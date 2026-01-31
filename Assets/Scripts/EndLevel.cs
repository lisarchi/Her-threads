using UnityEngine;

public class EndLevel : MonoBehaviour
{
    public GameObject _fadeIn;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            _fadeIn.SetActive(true);
        }
    }
}
