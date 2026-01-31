using UnityEngine;
using UnityEngine.AI;

[RequireComponent (typeof(NavMeshAgent))]
public class CatsTarget : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _followDistance;

    private NavMeshAgent _catAgent;
    internal Animator _catAnimator;
    private float _distance;

    private void Start()
    {
        _target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        _catAgent = GetComponent<NavMeshAgent>();
        _catAnimator = GetComponentInChildren<Animator>();
    }


    private void Update()
    {
        _distance = Vector3.Distance(_catAgent.transform.position, _target.position);
        if (_distance <= _followDistance)
        {
            _catAgent.isStopped = true;
            _catAnimator.SetBool("Seat", true);
            _catAnimator.SetBool("Hodba", false);
        }
        else
        {
            _catAgent.isStopped = false;
            _catAnimator.SetBool("Seat", false);
            _catAnimator.SetBool("Hodba", true);
            _catAgent.destination = _target.position;
        }
    }

    private void OnAnimatorMove()
    {
        if (_catAnimator.GetBool("Seat") == false)
        {
            _catAgent.speed = (_catAnimator.deltaPosition / Time.deltaTime).magnitude;
        }
    }
}
