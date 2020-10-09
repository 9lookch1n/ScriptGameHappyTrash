using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star_Ctrl : MonoBehaviour
{
    public GameObject StarGreenImgae;
    public GameObject StarRedImgae;
    public GameObject StarBlueImgae;
    public GameObject StarYellowImgae;

    public static int StarGreen;
    public static int StarRed;
    public static int StarBlue;
    public static int StarYellow;

    public GameObject[] Bin;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        //Check star
        if(StarGreen >= 1)
        {
            //Active StarImage
            StarGreenImgae.SetActive(true);
            //close Icon Bin
            Bin[3].SetActive(false);
        }
        if (StarRed >= 1)
        {
            //Active StarImage
            StarRedImgae.SetActive(true);
            //close Icon Bin
            Bin[0].SetActive(false);
        }
        if (StarBlue >= 1)
        {
            //Active StarImage
            StarBlueImgae.SetActive(true);
            //close Icon Bin
            Bin[2].SetActive(false);
        }
        if (StarYellow >= 1)
        {
            //Active StarImage
            StarYellowImgae.SetActive(true);
            //close Icon Bin
            Bin[1].SetActive(false);
        }
    }
}
