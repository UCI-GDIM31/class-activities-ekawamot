using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed;
    //[SerializeField] GameObject _target;
    private Transform _playerTransform;
    

    private void Start()
    {
        
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _playerTransform.position, _speed * Time.deltaTime);
    }

    public void StartChase(Transform player)
    {
        enabled = true;
        _playerTransform = player;
    }
    
    public void StopChase()
    {
        enabled = false;
    }
}
