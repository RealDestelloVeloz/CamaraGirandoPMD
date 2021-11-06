using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{ //COLOCAR EN   LA CAMARA
GameObject bola;
	float x, y, z;
Vector3 posicion;
    // Start is called before the first frame update
    void Start()
    {
            	bola = GameObject.Find("MAIN");

    }

    // Update is called once per frame
    void Update()
    {
    	    	x = bola.transform.position.x;
    	y = bola.transform.position.y;
    	z = bola.transform.position.z;
posicion = new Vector3(x, y, z);

        transform.LookAt(posicion);
    }
}
