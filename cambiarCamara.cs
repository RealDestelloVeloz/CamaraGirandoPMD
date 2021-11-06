using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiarCamara : MonoBehaviour
{
	Camera c1;
	Camera c2;
    // Start is called before the first frame update
    void Start()
    {
    	c1 = GameObject.Find("TerceraPersona").GetComponent<Camera>();
        c2 = GameObject.Find("FlotanteGiratoria").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            c1.enabled = !c1.enabled;
            c2.enabled = !c2.enabled;
    }
} }
