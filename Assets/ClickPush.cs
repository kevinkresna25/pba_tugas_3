using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPush : MonoBehaviour
{
    public Vector3 force;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        rb.AddForce(force, ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ball" || collision.gameObject.name == "Target")
        {
            Destroy(gameObject);
        }
    }
}
