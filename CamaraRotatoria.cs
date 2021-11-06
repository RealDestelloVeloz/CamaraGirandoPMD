// Animates the position in an arc between sunrise and sunset.

using UnityEngine;
using System.Collections;

public class CamaraRotatoria : MonoBehaviour
{//COLOCAR EN OBJETO PADRE DE LA CAMARA
	float timeCounter;
Rigidbody rb;
float radius;
GameObject bola;
Transform pos;

    void Start()
    {
    	bola = GameObject.Find("MAIN");

    	radius = 0.03f;
  
       rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
        timeCounter += (Time.deltaTime*2);
            float a = Mathf.Cos(timeCounter) * radius;
            float b = Mathf.Sin(timeCounter) * radius;
            transform.position += new Vector3(a,b);
            	
} 

}