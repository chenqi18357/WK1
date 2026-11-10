using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] float speed=1.5f;
    private Vector3 playerPos = Vector3.zero;
    float currentSpeed = 0f;
    public Vector3 getPos()
    {
        return transform.position;
    }
    private void Update()
    {
        transform.position= Vector3.MoveTowards(transform.position, playerPos, currentSpeed*Time.deltaTime);
    }
    public void startChasing(Vector3 _playerPos)
    {
        playerPos = _playerPos;
        currentSpeed = speed;
    }
    public void stopChasing()
    {
        currentSpeed = 0f;
    }
}
