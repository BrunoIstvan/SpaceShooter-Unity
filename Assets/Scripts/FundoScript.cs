using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FundoScript : MonoBehaviour {

    void Start()
    {
        Principal.Start();
    }

    // Update is called once per frame
    void Update () {

        // Move o fundo
        transform.Translate(Vector2.down * Principal.velocidade * Time.deltaTime);

        // Retornar quando atingir o limite
        if(transform.position.y < Principal.limite)
        {
            // Reposiciona o fundo para o novo ciclo
            transform.position = new Vector2(transform.position.x, Principal.limite * -1);
        }
        
	}
}
