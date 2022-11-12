using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        // Destroy(gameObject);
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up*300);
            //  rb.velocity=Vector3.forward*30f;
        }
        // rb.velocity=Vector3.forward*30f;
    }
    // void OnMouseDown(){
    //     Destroy(gameObject); 
    // }
}









//         new script





// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class moving : MonoBehaviour
// {
//     [Header("movement")]
//     public float moveSpeed;
//     public Transform orientation;
//     float horizontalInput;
//     float verticalInput;
//     Vector3 moveDirection;
//     Rigidbody rb;
//     // Start is called before the first frame update
//     void Start()
//     {
//      rb=GetComponent<Rigidbody>();
      
//     }
// void FixedUpdate(){
//     MovePlayer();
//     void FixedUpdate ()
//     {
//         float moveHorizontal = Input.GetAxis("Horizontal");
//         float moveVertical = Input.GetAxis("Vertical");
 
//         Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
 
//         GetComponent<Rigidbody>().AddForce(movement);
 
//     }
// }
//     // Update is called once per frame
//     void Update()
//     {
//         MyInput();
//     }
//  void MyInput(){
//     horizontalInput=Input.GetAxisRaw("Horizontal");
//     verticalInput=Input.GetAxisRaw("Vertical");
//     if(Input.GetKeyDown(KeyCode.Space))
//     {
//         rb.AddForce(Vector3.up*500);
//     }
    

// }

// void MovePlayer(){
//     moveDirection=orientation.forward*verticalInput+orientation.right*horizontalInput;
//     rb.AddForce(moveDirection.normalized*moveSpeed*10f,ForceMode.Force);
// }

// }

