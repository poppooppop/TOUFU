using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerCreate : MonoBehaviour
{
    public GameObject Player;

    private int Money = 0;

    public Text MoneyText;

    [SerializeField]
    private int Price = 100;

      // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        Money += 1;

        MoneyText.text = Money.ToString() + "‰~";
    }

    public void OnClick()

    {
     if (Money >= Price)
        {
            Instantiate(Player.gameObject, new Vector3(9.13f, -1.17f, 0), Quaternion.identity);

            Money -= Price;
        }



    }
















}
