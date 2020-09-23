using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PartIV
{
	public class PlayerMovimentation : MonoBehaviour
	{
		// Public attributes
		public float maxSpeed = 5;
		public float jumpSpeed = 5;

        //Player Sound
		private AudioSource source;
		public AudioClip stepsSound, jumpSound, colisionSound;

		private bool colidedWithEnemy = false;


        // Private attributes
        Rigidbody2D rigidBody;
		bool isJumping = false;

		private PlayerHealth health;

		void setSound(AudioClip sound, Boolean isLoop)
		{
            source.Stop();
            source.clip = sound;
            source.loop = isLoop;
            source.Play();
		}

		// Start is called before the first frame update
		// Here you can handle with all objects in the scene
		void Start()
		{
		}

		// Awake is called before the first frame update
		// Here you can handle with all components in the object
		void Awake()
		{
			rigidBody = GetComponent<Rigidbody2D>();
			health = GetComponent<PlayerHealth>();

			// Player sounds
            source = GetComponent<AudioSource>();
            setSound(stepsSound, true);
		}

		// Update is called once per frame
		void Update()
		{
			if (health.isDead)
			{
				return;
			}
			
			var x = Input.GetAxis("Horizontal");
			// transform.position += x * maxSpeed * transform.right * Time.deltaTime;
			rigidBody.velocity = new Vector2(x * maxSpeed, rigidBody.velocity.y);

			var jump = Input.GetAxis("Jump");
			if (jump > 0.5 && !isJumping)
			{
				isJumping = true;
				rigidBody.velocity = new Vector2(rigidBody.velocity.x, jump * jumpSpeed);

                //Handle jump sound
                setSound(jumpSound, false);
            }

			// Handle steps sound only while walking
            if (x != 0 && !isJumping)
            {
				if(colidedWithEnemy && !source.isPlaying)
				{
					colidedWithEnemy = false;
					setSound(stepsSound, true);
				}
				else
				{
                	source.UnPause();
				}
            }
            else if (!isJumping)
            {
                source.Pause();
            }
		}

		// OnCollisionEnter2D is called whenever the player hits something
		void OnCollisionEnter2D(Collision2D other)
		{
			// Debug.Log("Collision with: " + other.gameObject.name);
			if (other.contacts[0].normal == Vector2.up && isJumping)
			{
				isJumping = false;

				// Set sound to steps after jump
                setSound(stepsSound, true);
            }

			// Set sound on enemy colision
            if (other.gameObject.CompareTag("Enemy"))
            {
				colidedWithEnemy = true;
				setSound(colisionSound, false);
			}
		}
	}
}