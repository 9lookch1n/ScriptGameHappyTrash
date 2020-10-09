using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gen_Item : MonoBehaviour
{
    public GameObject[] item;

    // Start is called before the first frame update
    void Start()
    {
        //InInstantiate item in prefabs
        Instantiate(item[0], transform.position = new Vector2(4, 1), Quaternion.identity);
        Instantiate(item[1], transform.position = new Vector2(8, 2), Quaternion.identity);
        Instantiate(item[2], transform.position = new Vector2(12, 1), Quaternion.identity);
        Instantiate(item[3], transform.position = new Vector2(16, 2), Quaternion.identity);
        Instantiate(item[4], transform.position = new Vector2(20, 1), Quaternion.identity);
        Instantiate(item[5], transform.position = new Vector2(24, 2), Quaternion.identity);
        Instantiate(item[6], transform.position = new Vector2(28, 1), Quaternion.identity);
        Instantiate(item[7], transform.position = new Vector2(32, 2), Quaternion.identity);
        Instantiate(item[8], transform.position = new Vector2(36, 1), Quaternion.identity);
        Instantiate(item[9], transform.position = new Vector2(40, 2), Quaternion.identity);
        Instantiate(item[10], transform.position = new Vector2(44, 1), Quaternion.identity);
        Instantiate(item[11], transform.position = new Vector2(48, 2), Quaternion.identity);
    }

}
