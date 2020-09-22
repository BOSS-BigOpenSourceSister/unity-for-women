using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PartIV
{
	public class buraco : MonoBehaviour
	{
		// Public attributes
		public Text resultText;
		public Button button;
    public bool isDead;


		// nesse caso ele retorna ao começo do jogo
		void OnCollisionEnter2D(Collision2D other)
		{

      isDead = true;
			resultText.gameObject.SetActive(true);
			button.gameObject.SetActive(true);
			resultText.text = "Game Over";
		}
	}
}
