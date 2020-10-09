using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ctrl_Item : MonoBehaviour
{
    //public string move;


    public GameObject[] item;

    float P = 1;
    string Status = "Up";

    int Up;
    int Down;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 12; i++)
        {
            if (i % 2 == 1)
            {
                Up = 10;
                Down = -3;
            }
            else
            {
                Up = 10;
                Down = -3;
            }
        }
    }  
    // Update is called once per frame
    void Update()
    {
        MoveOBJ(item[0], Up, Down);
        MoveOBJ(item[1], Up, Down);

    }
    void MoveOBJ(GameObject OBJ,int Up, int Down)
    {
        //method item move up and down
        if (OBJ.transform.position.y >= Up)
        {
            Status = "Down";
        }
        if (OBJ.transform.position.y <= Down)
        {
            Status = "Up";
        }
        if (Status == "Down")
        {
            P = -0.1f;
        }
        if (Status == "Up")
        {
            P = 0.1f;
        }
        OBJ.transform.position += new Vector3(0, P, 0);
    }

}

