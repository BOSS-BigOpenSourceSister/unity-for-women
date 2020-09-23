using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PartIV
{
    public class PlayerHealth : MonoBehaviour
    {
        public bool isDead;
        public Text resultText;
        public Button button;
        public int health = 100;
        public Text text;
        public AudioSource source;
        public AudioClip backgroundSound, gameoverSound, victorySound;

        private void Start()
        {
            text.text = "HP: " + health;
            source.clip = backgroundSound;
            source.loop = true;
			source.Play();
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Enemy"))
            {
                health -= 50;
                text.text = "HP: " + health;

                if (health <= 0)
                {
                    source.Stop();
                    source.clip = gameoverSound;
                    source.loop = false;
                    source.Play();
                    isDead = true;
                    resultText.gameObject.SetActive(true);
                    button.gameObject.SetActive(true);
                    resultText.text = "Derrota";

                } 
            }
            if (other.gameObject.CompareTag("Finish")){
                source.Stop();
                source.clip = victorySound;
                source.loop = false;
                source.Play();
            }
        }
    }
}
