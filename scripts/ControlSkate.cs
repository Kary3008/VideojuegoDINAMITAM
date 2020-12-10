using UnityEngine;
using System.Collections;

public class ControlSkate : MonoBehaviour
{ 
    //hereda librerias
    public float movimiento;
    public float velocidad = 1250;
    public WheelJoint2D motorllanta1;

    // Use this for initialization

    void Update()
    {
        //-1 o 1 dependiendo de la tecla
        movimiento = Input.GetAxisRaw("Horizontal") * velocidad; 
        //el movimiento se multiplica por la velocidad a un eje horizontal
        
    }

    private void FixedUpdate()
    {
        JointMotor2D motor = new JointMotor2D { motorSpeed = movimiento, maxMotorTorque = 1000 };
        motorllanta1.motor = motor;
    }

}

