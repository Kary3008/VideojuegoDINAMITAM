using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject Follow;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float posX=Follow.transform.position.x;
        float posY=Follow.transform.position.y;
          transform.position = new Vector3(posX, posY, transform.position)
    }
}
