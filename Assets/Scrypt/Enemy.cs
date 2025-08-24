using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int x;
    private int y;

    [SerializeField] private float _speed;

    private int _napravl = 0;

    private void Update()
    {
        switch (_napravl)
        {
            case 0:
                transform.position += new Vector3(1, 0, 0) * _speed * Time.deltaTime;
                break;
            case 1:
                transform.position += new Vector3(-1, 0, 0) * _speed * Time.deltaTime;
                break;
            case 2:
                transform.position += new Vector3(0, 1, 0) * _speed * Time.deltaTime;
                break;
            case 3:
                transform.position += new Vector3(0, -1, 0) * _speed * Time.deltaTime;
                break;

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _napravl++;
        if (_napravl > 3)
        {
            _napravl = 0;
        }
    }
}
