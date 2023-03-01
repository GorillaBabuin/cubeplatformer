using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleContr : MonoBehaviour
{
    // Start is called before the first frame update
    Transform tr;
    float mouseX;
    CharacterController charC;
    float vertical;
    public float speedForce = 10f;
    float gravity = -5.81f;
    float jumpforce = 500f;
    bool isground = true;
    
    void Start()
    {
        tr = GetComponent<Transform>();
        charC = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X");
        vertical = Input.GetAxis("Vertical");
        charC.Move(tr.forward * vertical * speedForce * Time.deltaTime);
        charC.Move(tr.up * gravity * Time.deltaTime);

        if(Input.GetKeyDown("space") && isground == true)
        {
               charC.Move(tr.up * jumpforce * Time.deltaTime);
               isground = false;
        };

        tr.Rotate(0,mouseX * 4f, 0);
    }
    void OnControllerColliderHit(ControllerColliderHit arg)
    {
        if(arg.gameObject.tag == "ground"){
            isground = true;
        }
        
    }

}
