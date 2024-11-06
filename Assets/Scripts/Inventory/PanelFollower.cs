using UnityEngine;

public class PanelFollower : MonoBehaviour
{
	[SerializeField] private float _followSpeed = 2f;
    [SerializeField] private Transform _target;

    private void Update()
    {
        Vector3 newPosition = _target.position;
        transform.position = Vector3.Slerp(transform.position, newPosition, _followSpeed * Time.deltaTime);
    }
}

