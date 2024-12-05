using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        //create top
        for (int i = 0; i < 8; i++)
        {
            GameObject temp = (GameObject)Instantiate(cube, new Vector3((-3.5f + i), 0.5f, 4.5f), Quaternion.identity);
            temp.GetComponent<ClickPush>().force = new Vector3(0, 0, -10);
        }

        //create right
        for (int i = 0; i < 8; i++)
        {
            GameObject temp = (GameObject)Instantiate(cube, new Vector3(4.5f, 0.5f, (-3.5f + i)), Quaternion.identity);
            temp.GetComponent<ClickPush>().force = new Vector3(-10, 0, 0);
        }

        //create bottom
        for (int i = 0; i < 8; i++)
        {
            GameObject temp = (GameObject)Instantiate(cube, new Vector3((-3.5f + i), 0.5f, -4.5f), Quaternion.identity);
            temp.GetComponent<ClickPush>().force = new Vector3(0, 0, 10);
        }

        //create left
        for (int i = 0; i < 8; i++)
        {
            GameObject temp = (GameObject)Instantiate(cube, new Vector3(-4.5f, 0.5f, (-3.5f + i)), Quaternion.identity);
            temp.GetComponent<ClickPush>().force = new Vector3(10, 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
