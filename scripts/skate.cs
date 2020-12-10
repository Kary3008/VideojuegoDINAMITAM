using UnityEngine;
using System.Collections;

public class skate : MonoBehaviour {

    public float salto;
    private Rigidbody2D rigidbody2D;
    public WheelJoint2D salto1;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2D.AddForce(new Vector2(0, salto));
        }
	
	}
}
