using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour {
    public float mass = 1f;
    public Foodhandler Fh;


    void Start()
    {
        Fh.foods.Add(this);
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponentInHierarchy<CellBody>())
        {
            other.GetComponentInHierarchy<CellBody>().Mass += mass;
            gameObject.SetActive(false);
        }
    }
}
