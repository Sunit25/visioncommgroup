using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatingmodel : MonoBehaviour
{
     public float speed = 30f;
   
    //Forward Direction
    public bool ForwardX = false;
    public bool ForwardY = false;
    public bool ForwardZ = false;
   
    //Reverse Direction
    public bool ReverseX = false;
    public bool ReverseY = false;
    public bool ReverseZ = false;
   
    void Update ()
    {
        //Forward Direction
         if(Input.GetKey(KeyCode.W))
        {
            transform.Rotate(Time.deltaTime * speed, 0, 0, Space.Self);
        }
       if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, Time.deltaTime * speed,  0, Space.Self);
        }
        if(Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, 0, Time.deltaTime * speed, Space.Self);
        }
        //Reverse Direction
        if(Input.GetKey(KeyCode.S))
        {
            transform.Rotate(-Time.deltaTime * speed, 0, 0, Space.Self);
        }
       else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, -Time.deltaTime * speed,  0, Space.Self);
        }
         if(Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, 0, -Time.deltaTime * speed, Space.Self);
        }



  }

}


