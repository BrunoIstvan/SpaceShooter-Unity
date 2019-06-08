using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerarInimigos : MonoBehaviour {

    public float tempoInicial, tempoFinal;
    public float esquerdaX, direitaX;
    public GameObject inimigoPrefab;

	// Use this for initialization
	void Start () {
        // executar uma Coroutine
        StartCoroutine(Gerar());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Gerar() {

        // aguarda um tempo gerado randomicamente
        yield return new WaitForSeconds(Random.Range(tempoInicial, tempoFinal));
        // gera uma posição em X... usa a posição y e z do ponto que está na tela...
        Vector3 posicao = 
            new Vector3(Random.Range(esquerdaX, direitaX), 
                        transform.position.y, transform.position.z);
        // instancia o inimigo
        Instantiate(inimigoPrefab, posicao, transform.rotation);


        // executar uma Coroutine
        StartCoroutine(Gerar());

    }

}
