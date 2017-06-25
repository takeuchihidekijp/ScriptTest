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

        for(int j = array.Length-1; j >= 0; j--)
        {
            Debug.Log(array[j]);
        }
		 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
