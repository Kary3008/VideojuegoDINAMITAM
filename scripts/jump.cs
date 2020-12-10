using UnityEngine;
using System.Collections;

public class jump : MonoBehaviour {
    public float fuerzaSalto;
    private Rigidbody2D rb;

    // Use this for initialization
    void Start () {
      //inicializas el componente rigidbody igualado a la variable rb
        rb = GetComponent<Rigidbody2D>();
    }

	// Update is called once per frame
	void Update () {
    //colocas una condición
        if(Input.GetKeyDown(KeyCode.Space))// si al presionar la tecla espacio genera la siguiente orden...
            {
          //  rb agrega una fuerza a un nuevo vector donde aplica la fuerza del salto
            rb.AddForce(new Vector2(0, fuerzaSalto));
        }
    }
}
