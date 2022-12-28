using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PLAYER : MonoBehaviour
{
    public bool isjump = false;
    public float speed = 5f;
    public int jumppower = 5;
    private Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            isjump = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");

        Vector3 veto = new Vector3(inputX, 0, inputZ);
        transform.transform.position += veto * speed * Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (!isjump)
            {
                isjump = true;
                rigid.AddForce(Vector3.up * jumppower, ForceMode.Impulse);
            }
        }
    }
}
