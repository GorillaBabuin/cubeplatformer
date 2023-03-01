using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectItems : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TextMeshProUGUI Text;
    Rigidbody rb;
    static int points = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision arg)
    {
        if(arg.gameObject.tag == "player"){
            Destroy(gameObject);
            
            points = points + 1;
            Text.text = points + "";
        }
    }
}
