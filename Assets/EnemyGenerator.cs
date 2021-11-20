using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject Enemy;


    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("Generate", 7, 3);
    
    }

    // Update is called once per frame
    void Update()
    {
        
     
    
    }

    void Generate()

    {
        Instantiate(Enemy.gameObject, new Vector3(-9.13f, -1.37f, 0), Quaternion.identity);

    }
}
