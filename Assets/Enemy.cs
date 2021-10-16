using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour 
{
   [SerializeField]
    private float MoveSpeed = 1;//
   [SerializeField]
    private float Direction = 180;
    Animator anim;
    private bool move;
    [SerializeField]
    private int EnemyHp = 10;
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
        
        if(EnemyHp <= 1)
        {
            Destroy(gameObject);

        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
      if (collision.gameObject.tag == "Player")
      {
            EnemyHp -= 1;

            anim.SetBool("EnemyAttack", true);

            move = false;
      }
    
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")

        {
            anim.SetBool("EnemyAtack", false);

            move = true;

        }
    
    
    
    
    
    }










}

