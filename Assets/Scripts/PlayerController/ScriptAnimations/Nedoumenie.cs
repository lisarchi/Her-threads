using UnityEngine;

public class Nedoumenie : MonoBehaviour
{
    public Animator playerAnimator;
    private bool _inZoneNedoumenie;
    void Awake()
    {
        _inZoneNedoumenie = false;
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag.Equals("Player"))
        {
            _inZoneNedoumenie = true;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag.Equals("Player"))
        {
            _inZoneNedoumenie = false;
        }
    }


    private void Update()
    {
        playerAnimator.SetBool("nedoumenie", UserInput.instance.InteractionInput && _inZoneNedoumenie==true);
    }
}
