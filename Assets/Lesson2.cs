using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Lesson2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        List<int> list =new List<int>();
        list.Add(48);
        list.Add(985);
        for (int i = 0; i < list.Count;i++){
            Debug.Log(list[i]);
        
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
