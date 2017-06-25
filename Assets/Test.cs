using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int[] array = { 10, 20, 30, 40, 50 };

        for(int i =0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        for(int j =0; j < array.Length; j++)
        {
            int k = (array.Length -1 ) - j ;
            Debug.Log(array[k]);
        }
		 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
