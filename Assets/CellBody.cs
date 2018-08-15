using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellBody : MonoBehaviour {

    [SerializeField]
    float _mass = 1;
    public float Mass
    {
        get { return _mass; }
        set
        {
            _mass = value;
            transform.localScale = new Vector3(1 + (_mass * 0.33f), 1 + (_mass * 0.33f), 1);
        }
    }


    void Awake()
    {
        Mass = Mass;
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponentInHierarchy<CellBody>())
        {
            if (collision.gameObject.GetComponentInHierarchy<CellBody>().Mass < _mass)
            {
                Mass += collision.gameObject.GetComponentInHierarchy<CellBody>().Mass;
                collision.gameObject.SetActive(false);
            }
        }
    }
}
