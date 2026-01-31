using UnityEngine;

public class Zadumalas : MonoBehaviour
{
    public Animator playerAnimator;
    private bool _inZoneZadumalas;
    void Awake()
    {
        _inZoneZadumalas = false;

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag.Equals("Player"))
        {
            _inZoneZadumalas = true;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag.Equals("Player"))
        {
            _inZoneZadumalas = false;
        }
    }


    private void Update()
    {
        playerAnimator.SetBool("zadumalas", _inZoneZadumalas == true);
    }
}
