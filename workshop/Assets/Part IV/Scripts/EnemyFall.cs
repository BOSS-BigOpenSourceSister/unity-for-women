using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PartIV
{
    public class EnemyFall : MonoBehaviour
    {
        public Vector2 start;
        public Vector2 end;
        public float speed;
        public float tempo;//tempo em que o objeto fica parado
        public float distacia; //distacia entre jogador e inimigo

        private float direction = 1;
        private int movimento = 0;
        //posição do player
        private Vector3 posicao_jogador = GameObject.FindWithTag("Player").GetComponent(transform);

        //função que determina o quanto tempo o inimigo fica parada para depois subir novamente
        IEnumerator Espera()
        {

          movimento = 0;
          yield return new WaitForSecondsRealtime(tempo);
          movimento = 1;

        }

        private void Start()
        {
            transform.position = new Vector3(start.x, start.y, transform.position.z);
        }

        void Update()
        {
          // nesse caso, o inimigo cai e depois de um tempo ele sobe novamente, se quiser que ele fique estático após cair, remova a variavel de direção e movimento
          if (Vector3.Distance(transform.position, posicao_jogador) < distancia)
          {
            direction = 1;
            transform.position += Vector3.down * speed * direction * movimento;
          }

          //remover esta condição se quiser que o inimigo fique estatico
          if (Vector3.Distance(transform.position, end) < 0.1f)
          {

            StartCoroutine(Espera());
            direction = -1;
          }

          Debug.Log(transform.position);

        }
    }
}
