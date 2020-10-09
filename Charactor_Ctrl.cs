using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Charactor_Ctrl : MonoBehaviour
{
    float xInput;
    float Movespeed = 10f;

    float yInput;
    float Jumpspeed = 10f;

    bool checkPressBttSpace = false;
    bool checkPressBtt = false;

    Animator anim;
    Rigidbody2D rd;

    float cooldown = 3f;

    private void Start()
    {
        anim = GetComponent<Animator>();
        rd = GetComponent<Rigidbody2D>();
    }

    void Comeback(string A1)
    {
        print(A1);
    }
    private void FixedUpdate()
    {
        if (Score_Bin.HP <= 0)
        {
            cooldown -= Time.deltaTime;

            if (cooldown <= 0.0f)
            {
                SceneManager.LoadScene("Level_Change");
                cooldown = 3f;
                Score_Bin.HP = 3;
                Comeback("Replay");
            }
        }
        if(Score_Bin.HP >  0)
        {
            //GetButton Keyboard
            if (Input.GetButton("Horizontal"))
            {
                xInput = Input.GetAxis("Horizontal") * Movespeed * Time.deltaTime;
                MoveHorizontal();
            }
            else if (Input.GetButtonUp("Horizontal"))
            {
                anim.SetBool("Walk", false);
            }

            if (Input.GetButton("Jump"))
            {
                yInput = Input.GetAxis("Jump") * Jumpspeed * Time.deltaTime;
                MoveJump();
            }
            else if (Input.GetButtonUp("Jump"))
            {
                anim.SetBool("Jump", false);
            }

            if (checkPressBtt) //mean true
            {
                MoveHorizontal();
            }
            if (checkPressBttSpace) //mean true
            {
                MoveJump();
            }
            if (checkPressBttSpace == true)
            {
                yInput = Jumpspeed * Time.deltaTime;
            }
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        //method crash check
        if (collision.gameObject.name == "Floor")
        {
            checkPressBttSpace = false;
        }
    }
    public void UpBtt()
    {
        //method check ButtonUp
        checkPressBtt = false;
        anim.SetBool("Walk", false);
        anim.SetBool("Jump", false);
    }
    public void MoveHorizontal()
    {
        //method Horizontal
        transform.Translate(xInput, 0, 0);
        anim.SetBool("Walk", true);
    }
    public void MoveJump()
    {
        //method check Jump
        transform.Translate(0, yInput, 0);
        anim.SetBool("Jump", true);
    }
    public void SpacePress()
    {
        //method check press Button Spacebar
        checkPressBttSpace = true;
    }
    public void LeftPress()
    {
        //method check press Button LeftArrow
        xInput = -Movespeed * Time.deltaTime;
        checkPressBtt = true;
    }
    public void RightPress()
    {
        //method check press Button RightArrow
        xInput = Movespeed * Time.deltaTime;
        checkPressBtt = true;
    }
}
    