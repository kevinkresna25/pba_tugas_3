using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            Instantiate(target, new Vector3(Random.Range(-3.0f, 3f), 0.25f, Random.Range(-3.0f, 3.0f)), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
