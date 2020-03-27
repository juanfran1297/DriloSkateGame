using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {


	private float velocidadFondo = 0.1f;

	private float tiempoInicio = 0f;

	// Update is called once per frame
	void Update () 
    {
			//Entramos en el componente del material para modificar el offset.
			GetComponent<Renderer>().material.mainTextureOffset = new Vector2 (((Time.time-tiempoInicio) * velocidadFondo)%1, 0);
	}
}
