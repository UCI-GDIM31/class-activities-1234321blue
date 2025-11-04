using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] float _speed;

    private Transform _playerTransform;
    public void ChaseCat(Transform player)
    {
        _playerTransform = player;
        transform.position = Vector3.MoveTowards(transform.position, _playerTransform.position, _speed * Time.deltaTime);
    }

    public void StopChasingCat()
    {
       transform.position = Vector3.MoveTowards(transform.position, transform.position, _speed * Time.deltaTime);
    }

}
