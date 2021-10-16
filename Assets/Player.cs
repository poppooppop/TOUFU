using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float MoveSpeed = -1; //
    [SerializeField]
    private float Direction = 0;//
    Animator anim;
    private bool move;
    [SerializeField]
    private int playerHP = 10;
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(0, Direction, 0);

        anim = GetComponent<Animator>();

        move = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (move == true)

        {
            transform.position += new Vector3(MoveSpeed * Time.deltaTime, 0, 0);
        }
        if (playerHP <= 1)
        { Destroy(gameObject); }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {   
        if (collision.gameObject.tag == "Enemy")
        {
            playerHP -= 1;
            
            anim.SetBool("Attack", true);

            move = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Enemy")

        {
            anim.SetBool("Attack", false);


            move = true;
        }
    }



















}
