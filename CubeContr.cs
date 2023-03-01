using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CubeContr : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    float vertical;
    float horizontal;
    Transform tr;
    static int points = 0;
    public float jumpforce = 10f;
    bool isground = true;
    [SerializeField] TextMeshProUGUI Text;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        tr = GetComponent<Transform>();
        PointsText.text = points + "";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space") && isground == true)
        {
                rb.AddForce(0,jumpforce,0,ForceMode.Impulse); 
                isground = false;
        };
        
        vertical = Input.GetAxis("Vertical");
        print(vertical);
        horizontal = Input.GetAxis("Horizontal");
        rb.AddRelativeForce(0,0, vertical * 5f);
        tr.Rotate(0,horizontal,0);
        
    }

    void OnCollisionEnter(Collision arg)
    {
        if(arg.gameObject.tag == "plane"){
            isground = true;
        }
        
    }
}
