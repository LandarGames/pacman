
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _upPoint;

    [SerializeField] private Transform[] _points;
    [SerializeField] private float _kd;

    private void Start()
    {
        NewLoc();
    }
    private void NewLoc()
    {
        Instantiate(_upPoint, _points[Random.Range(0, _points.Length)].transform.position,Quaternion.identity);
        Invoke(nameof(NewLoc), _kd);
    }
}
