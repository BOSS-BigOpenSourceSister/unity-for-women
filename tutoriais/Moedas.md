# Adicionando Moedas

1. Adicione um asset de moeda à cena
2. Coloque uma tag de nome "Moeda" no objeto da moeda
3. Crie um UI de texto para mostrar na tela a quantidade de moedas coletadas
4. No inspector do objeto texto criado, troque o Horinzontal Overflow para Overflow e faça o mesmo para o vertical
5. Adicione ao player um script Coins

6. Crie uma variável para contagem das moedas e outra para usar o Text do UI:
```
public int coins = 0;
public Text CoinText; // importe o UnityEngine.UI

```

7. No método *Start* do script inicialize o texto que acopanhará a contagem de moedas:
```
void Start() {
    CoinText.text = "Coins: " + coins;
}
```

8. No método *OnCollisionEnter2D* faça uma condição que verifica se o player colidiu com algum objeto cuja tag seja "Moeda":
```
private void OnCollisionEnter2D(Collision2D other) {
	if(other.gameObject.CompareTag("Moeda")){
    }
}
```

9. Caso o player tenha colidido com uma moeda, então o contador de moedas é pra ser atualizado e a moeda é pra ser destruída:
```
	if(other.gameObject.CompareTag("Moeda")){
                coins++;
                CoinText.text = "Coins: " + coins;
                Destroy(other.gameObject);
    }
```
