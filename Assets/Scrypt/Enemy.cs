using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int x;
    private int y;

    [SerializeField] private float _speed;

    private int _napravl = 0;

    private int[] _raz = { 0, 90, 180, 270 };

    private void Start()
    {
        transform.Rotate(0,0, _raz[Random.Range(0,_raz.Length)]);
    }

    private void Update()
    {
        transform.Translate(new Vector3(_speed * Time.deltaTime, 0, 0));
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right, 1, LayerMask.GetMask("sss"));

       

        if (hit.collider == null)
        {
            return;
        }
        Debug.Log(hit.collider.gameObject);
        if (hit.collider.gameObject.GetComponent<Player>() == false && hit.collider.gameObject.GetComponent<Ochko>() == false && hit.collider.gameObject != gameObject)
        {
            transform.Rotate(0, 0, 90);
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
