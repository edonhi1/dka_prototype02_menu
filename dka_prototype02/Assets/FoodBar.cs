using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodBar : MonoBehaviour {

    public float food;
    public float maxFood;
    private Vector3 barScale;

	void Start () {
		
	}
	
	void Update () {
        barScale = new Vector3(food / maxFood, transform.localScale.y, transform.localScale.z);
        transform.localScale = barScale;
	}
}
