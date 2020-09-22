# Adicionando Moedas

1. Adicione um asset de moeda à cena
2. Coloque uma tag de nome "Moeda" no objeto da moeda
3. Adicione ao player um script Coins
4. No método *Start* do script inicialize o texto que acopanhará a contagem de moedas:
```
void Start() {
    CoinText.text = "Coins: " + coins;
}
```

5. No método *OnCollisionEnter2D* faça uma condição que verifica se o player colidiu com algum objeto cuja tag seja "Moeda":
```
private void OnCollisionEnter2D(Collision2D other) {
	if(other.gameObject.CompareTag("Moeda")){
    }
}
```

6. Caso o player tenha colidido com uma moeda, então o contador de moedas é pra ser atualizado e a moeda é pra ser destruída:
```
	if(other.gameObject.CompareTag("Moeda")){
                coins++;
                CoinText.text = "Coins: " + coins;
                Destroy(other.gameObject);
    }
```
