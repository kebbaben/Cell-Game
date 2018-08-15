using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterCamera : MonoBehaviour {
    [SerializeField]
    GameObject target;

	
	void Update ()
    {
        if (target != null)
        {
            transform.position = target.transform.position;
            transform.SetPosZ(-7f - (target.transform.localScale.x / 2)); 
        }
	}
}
