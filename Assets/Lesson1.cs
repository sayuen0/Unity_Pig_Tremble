using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Debug.Log("Hello");
        Person p = new Person();
        p.firstName = "太郎";
        p.lastName = "田中";
        Debug.Log(p.GetFullName());
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}

class Person{
    public string firstName;
    public string lastName;

    public string GetFullName (){
        return this.lastName + this.firstName;
    }
}

　