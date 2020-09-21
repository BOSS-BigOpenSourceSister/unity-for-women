using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Moedas : MonoBehaviour
{

    public int coins = 0;
    public Text CoinText;

    public GameObject Coin;
    public GameObject Coin1;
    public GameObject Coin2;
    


    // Start is called before the first frame update
    void Start()
    {
        CoinText.text = "Coins: " + coins;
    }

    void Awake() {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Moeda")){

            coins++;
            CoinText.text = "Coins: " + coins;
            Coin.transform.position = new Vector3(Coin.transform.position.x, 10, -100);
                      
        }

        if(other.gameObject.CompareTag("Moeda1")){
            coins++;
            CoinText.text = "Coins: " + coins;
            Coin1.transform.position = new Vector3(Coin1.transform.position.x, 10, -100);
                      
        }

        if(other.gameObject.CompareTag("Moeda2")){
            coins++;
            CoinText.text = "Coins: " + coins;
            Coin2.transform.position = new Vector3(Coin2.transform.position.x, 10, -100);
                      
        }
        

    }
}
