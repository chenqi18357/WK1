using UnityEngine;
using UnityEngine.AI;

public class DeerW5 : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 1.0f;
    [SerializeField] private float _turnSpeed = 1.0f;
    [SerializeField] private Animator _animator;
    [SerializeField] private NavMeshAgent _agemt;
    [SerializeField] private Transform target;
    private string _isWalkingName = "IsWalking";
    private void Start()
    {
        _agemt.speed = _moveSpeed;
        _agemt.angularSpeed = _turnSpeed;
    }
    private void Update()
    {
        _agemt.SetDestination(target.position);

        if (!_agemt.isStopped)
        {
            _animator.SetBool(_isWalkingName, true);
        }
        else
        {
            _animator.SetBool(_isWalkingName, false);
        }
    }
    
}
// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...