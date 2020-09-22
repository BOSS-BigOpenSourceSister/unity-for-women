using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Moedas : MonoBehaviour
{

    public int coins = 0;
    

    public Text CoinText;
    /*
    public List<GameObject> Coins; 
    public GameObject Coin;
    public GameObject Coin1;
    public GameObject Coin2;
    public int i = 0;    
    */
    
    void Start()
    {
        CoinText.text = "Coins: " + coins; 
        /*       
        Coins = new List<GameObject>();
        Coins.Add((GameObject)Instantiate(Coin, Coin.transform.position, Coin.transform.rotation));
        Coins.Add((GameObject)Instantiate(Coin1, Coin1.transform.position, Coin1.transform.rotation));
        Coins.Add((GameObject)Instantiate(Coin2, Coin2.transform.position, Coin2.transform.rotation)); 
        */

    }
    
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
              
         
            if(other.gameObject.CompareTag("Moeda")){
                coins++;
                CoinText.text = "Coins: " + coins; 
                Destroy(other.gameObject);
            }       


            /*
            foreach (GameObject c in Coins){   
            if(other.gameObject.CompareTag("Moeda" + i)){
                Debug.Log("MOOOOEEDDA: " + other.gameObject.CompareTag("Moeda" + i));

                i++;
                coins++;
                CoinText.text = "Coins: " + coins;
                c.transform.position = new Vector2(c.transform.position.x, 10);               
        
                }
            }
            */
        }       

}

