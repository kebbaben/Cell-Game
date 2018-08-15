using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foodhandler : MonoBehaviour {
    public List<Food> foods = new List<Food>();
    public float spawnTime = 60;
    public float xTime = 0;
	
	void Update()
	{
        xTime += 1 * Time.deltaTime;
        if (xTime > spawnTime)
        {
            foreach (Food food in foods)
            {
                food.gameObject.SetActive(true);
            }
            xTime = 0;
        }
	}
}
