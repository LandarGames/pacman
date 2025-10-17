using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] private Transform _tp;
    [SerializeField] private float _speed;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.position = _tp.position;
        collision.transform.position += new Vector3(_speed, 0, 0);
    }
}
