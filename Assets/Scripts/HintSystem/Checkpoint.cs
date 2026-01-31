using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public int index;
    public HintPath hint;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        gameObject.SetActive(false);
        hint.GoNextCheckpoint();
    }
}