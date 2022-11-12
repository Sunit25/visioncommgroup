using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousello : MonoBehaviour
{

public float mouseSensitivity =5000f;
public Transform playerBody;
public float yRotation;
public float xRotation;


    // Start is called before the first frame update
    void Start()
    {
        // Cursor.lockState =CursorLockMode.Fixed;
    }

    // Update is called once per frame
    void Update()
    {
        float mousex=Input.GetAxis("Mouse X") * mouseSensitivity *  Time.deltaTime;
        float mousey=Input.GetAxis("Mouse Y") * mouseSensitivity *  Time.deltaTime;
        yRotation+=mousex;
        xRotation-=mousey;
xRotation=Mathf.Clamp(xRotation,-90f,90f);
        playerBody.Rotate(Vector3.up*mousex);
        // playerBody.Rotate(Vector3.left*mousey);
//          transform.position = new Vector3(
//     Input.GetAxisRaw("mouse X") * mouseSensitivity * Time.deltaTime,  
//     Input.GetAxisRaw("mouse Y")  * mouseSensitivity * Time.deltaTime,
//     0f
// );
    }
    
    }

