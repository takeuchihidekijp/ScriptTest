using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int[] points = new int[5];

        points[0] = 20;
        points[1] = 10;
        points[2] = 30;
        points[3] = 10;
        points[4] = 80;

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(points[i]);
        } 
		 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
