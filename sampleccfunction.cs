using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class samplecc : MonoBehaviour {
int a = 7;
int b = 8;
int c;
int f;
float e;
public void calcul ()
{
    c = a + b; 
	f =	a * b;
	e = (float) a/b;
	 Debug.Log(c);
	 Debug.Log(f);
	 Debug.Log(e); 
}

	// Use this for initialization
	void Start () {
	 
	}
	
	// Update is called once per frame
	void Update () {
	 
	}
}
