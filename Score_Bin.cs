using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score_Bin : MonoBehaviour
{
    public GameObject Player; // เอาไว้หาGameObjectของPlayer


    public int increaseCoin = 0; 
    public Text coinText;

    public static int HP = 3;

    public GameObject[] Heart;

    Animator anim;
    Rigidbody2D rd;

    string Scene1;

    private void Start()
    {
        anim = GetComponent<Animator>();
        rd = GetComponent<Rigidbody2D>();

        Scene SceneName = SceneManager.GetActiveScene();

        Scene1 = SceneName.name;


    }
    // Update is called once per frame
    void Update()
    {
        //Check HP and delete heart
        if (HP == 2)
        {
            Heart[0].SetActive(false);
        }
        if (HP == 1)
        {
            Heart[1].SetActive(false);
        }
        if (HP == 0)
        {
            Heart[2].SetActive(false);
            // Animation Dead
            anim.SetBool("Dead", true); 
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //method crash check
        //Check Scene
        if (Scene1 == "Green_Scenes")
        {
            //Check check Collision and reduction or increase of values
            if (collision.gameObject.tag == "Red")
            {
                //static UsingTag from script BinGreenUsingTag
                BinGreenUsingTag.Red -= increaseCoin;
                HP -= 1;
                Destroy(collision.gameObject);
            }
            if (collision.gameObject.tag == "Blue")
            {
                BinGreenUsingTag.Blue -= increaseCoin;
                HP -= 1;
                Destroy(collision.gameObject);
            }
            if (collision.gameObject.tag == "Yellow")
            {
                BinGreenUsingTag.Yellow -= increaseCoin;
                HP -= 1;
                Destroy(collision.gameObject);
            }
            if (collision.gameObject.tag == "Green")
            {
                BinGreenUsingTag.Green += increaseCoin;
                coinText.text = BinGreenUsingTag.Green.ToString();
                Destroy(collision.gameObject);
            }
            if (collision.gameObject.tag == "Goal")
            {
                Star_Ctrl.StarGreen += 1;
                SceneManager.LoadScene("Level_Change");

            }

            if (collision.gameObject.tag == "TNT")
            {
                HP -= 3;
                Heart[0].SetActive(false);
                Heart[1].SetActive(false);
                Heart[2].SetActive(false);
                anim.SetBool("Dead", true);
            }
        }
        //Check Scene
        if (Scene1 == "Red_Scenes")
        {
            //Check check Collision and reduction or increase of values
            if (collision.gameObject.tag == "Green")
            {
                //static UsingTag from script BinGreenUsingTag
                BinGreenUsingTag.Red -= increaseCoin;
                HP -= 1;
                Destroy(collision.gameObject);
            }
            if (collision.gameObject.tag == "Blue")
            {
                BinGreenUsingTag.Blue -= increaseCoin;
                HP -= 1;
                Destroy(collision.gameObject);
            }
            if (collision.gameObject.tag == "Yellow")
            {
                BinGreenUsingTag.Yellow -= increaseCoin;
                HP -= 1;
                Destroy(collision.gameObject);
            }
            if (collision.gameObject.tag == "Red")
            {
                BinGreenUsingTag.Green += increaseCoin;
                coinText.text = BinGreenUsingTag.Green.ToString();
                Destroy(collision.gameObject);
            }
            if (collision.gameObject.tag == "Goal")
            {
                Star_Ctrl.StarRed += 1;
                SceneManager.LoadScene("Level_Change");
            }

            if (collision.gameObject.tag == "TNT")
            {
                HP -= 3;
                Heart[0].SetActive(false);
                Heart[1].SetActive(false);
                Heart[2].SetActive(false);
                anim.SetBool("Dead", true);
            }
        }
        //Check Scene
        if (Scene1 == "Blue_Scenes")
        {
            //Check check Collision and reduction or increase of values
            if (collision.gameObject.tag == "Red")
            {
                //static UsingTag from script BinGreenUsingTag
                BinGreenUsingTag.Red -= increaseCoin;
                HP -= 1;
                Destroy(collision.gameObject);
            }
            if (collision.gameObject.tag == "Green")
            {
                BinGreenUsingTag.Blue -= increaseCoin;
                HP -= 1;
                Destroy(collision.gameObject);
            }
            if (collision.gameObject.tag == "Yellow")
            {
                BinGreenUsingTag.Yellow -= increaseCoin;
                HP -= 1;
                Destroy(collision.gameObject);
            }
            if (collision.gameObject.tag == "Blue")
            {
                BinGreenUsingTag.Green += increaseCoin;
                coinText.text = BinGreenUsingTag.Green.ToString();
                Destroy(collision.gameObject);
            }
            if (collision.gameObject.tag == "Goal")
            {
                Star_Ctrl.StarBlue += 1;
                SceneManager.LoadScene("Level_Change");
            }   
            if (collision.gameObject.tag == "TNT")
            {
                HP -= 3;
                Heart[0].SetActive(false);
                Heart[1].SetActive(false);
                Heart[2].SetActive(false);
                anim.SetBool("Dead", true);
            }
        }
        //Check Scene
        if (Scene1 == "Yellow_Scenes")
        {
            //Check check Collision and reduction or increase of values
            if (collision.gameObject.tag == "Red")
            {
                //static UsingTag from script BinGreenUsingTag
                BinGreenUsingTag.Red -= increaseCoin;
                HP -= 1;
                Destroy(collision.gameObject);
            }
            if (collision.gameObject.tag == "Green")
            {
                BinGreenUsingTag.Blue -= increaseCoin;
                HP -= 1;
                Destroy(collision.gameObject);
            }
            if (collision.gameObject.tag == "Blue")
            {
                BinGreenUsingTag.Yellow -= increaseCoin;
                HP -= 1;
                Destroy(collision.gameObject);
            }
            if (collision.gameObject.tag == "Yellow")
            {
                BinGreenUsingTag.Green += increaseCoin;
                coinText.text = BinGreenUsingTag.Green.ToString();
                Destroy(collision.gameObject);
            }
            if (collision.gameObject.tag == "Goal")
            {
                SceneManager.LoadScene("Level_Change");
                Star_Ctrl.StarYellow += 1;
            }
            if (collision.gameObject.tag == "TNT")
            {
                HP -= 3;
                Heart[0].SetActive(false);
                Heart[1].SetActive(false);
                Heart[2].SetActive(false);
                anim.SetBool("Dead", true);
            }
        }
    }
}
