using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class END : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "END")
        {
            Debug.Log("클리어 한태혁");
        }
    }
}
