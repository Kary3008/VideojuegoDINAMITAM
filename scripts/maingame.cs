using UnityEngine;
using System.Collections;

public class maingame : MonoBehaviour {
    public Renderer fondo;    

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        fondo.material.mainTextureOffset = fondo.material.mainTextureOffset + new Vector2(0.05f, 0) * Time.deltaTime;
        //mover el fondo constantemente, llamando la propiedad llamada material, siendo declaradas como igual.
        //moverse en x en (0.2f) y en y (0)-------Delta time sirve para moverse a la misma velocidad.
	}
}
