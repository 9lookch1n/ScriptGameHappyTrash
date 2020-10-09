using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charactor_Ctrl_Flip : MonoBehaviour
{

    public bool facingRight = true;


    // Update is called once per frame
    private void Start()
    {

    }
    private void Update()
    {
        if (Score_Bin.HP > 0)
        {
            float h = Input.GetAxis("Horizontal");
            if (h > 0 && !facingRight)
            {
                Flip();
            }
            else if (h < 0 && facingRight)
            {
                Flip();
            }
        }
    }
    public void Flip()
    {
        //method Charactor Flip
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
