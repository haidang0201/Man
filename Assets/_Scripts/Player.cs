using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator ani;
    public float movestep;


    public int speed;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();   
        ani = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
        Move();

    }
    private void Move()
    {
        movestep = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(speed * movestep, rb.velocity.y);
       if(movestep != 0 )
        {
            if (movestep == 1)
            {
                ani.SetBool("run", true);

            }
            else if (movestep == -1)
            {
                ani.SetBool("run", true);

            }
            


        }
       else  ani.SetBool("run", false);

    }







}
