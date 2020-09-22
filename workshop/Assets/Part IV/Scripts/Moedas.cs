using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Moedas : MonoBehaviour
{

    public int coins = 0;
    public int i = 0;

    public Text CoinText;
    public List<GameObject> Coins;  


    //public List<GameObject> Coins = {c1, c2, c3}; 

    public GameObject Coin;
    public GameObject Coin1;
    public GameObject Coin2;



    
    


    // Start is called before the first frame update
    void Start()
    {
        CoinText.text = "Coins: " + coins;
        Coins = new List<GameObject>();
        
        
        Coins.Add(Coin) ;
        Coins.Add(Coin1);
        Coins.Add(Coin2);


    }

    void Awake() {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        //GameObject[] Coins2 = new GameObject[] {Coin, Coin1, Coin2};
        //Coins.AddRange(Coins2);

      
        foreach (GameObject c in Coins){
           // Debug.Log("Quantidade Coins: " + Coins.Count());
          //  Debug.Log("IIII: " + i);
           // Debug.Log("COOINS: " + coins);


            if(other.gameObject.CompareTag("Moeda" + i)){
                Debug.Log("MOOOOEEDDA: " + other.gameObject.CompareTag("Moeda" + i));

                i++;
                coins++;
                CoinText.text = "Coins: " + coins;
                c.transform.position = new Vector3(c.transform.position.x, 10, -100);
            }
        }
        // if(other.gameObject.CompareTag("Moeda")){

        //     coins++;
        //     CoinText.text = "Coins: " + coins;
        //     Coin.transform.position = new Vector3(Coin.transform.position.x, 10, -100);
                      
        // }

        // if(other.gameObject.CompareTag("Moeda1")){
        //     coins++;
        //     CoinText.text = "Coins: " + coins;
        //     Coin1.transform.position = new Vector3(Coin1.transform.position.x, 10, -100);
                      
        // }

        // if(other.gameObject.CompareTag("Moeda2")){
        //     coins++;
        //     CoinText.text = "Coins: " + coins;
        //     Coin2.transform.position = new Vector3(Coin2.transform.position.x, 10, -100);
                      
        // }
        

    }
}
