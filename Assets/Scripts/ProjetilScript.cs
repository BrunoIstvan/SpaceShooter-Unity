using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjetilScript : MonoBehaviour {

    public float velocidade;

    void Start () {

        // Destroi o rojetil da memória após 2 segundos
        Destroy(gameObject, 2f);

	}
	
	
	void Update () {

        // Mover o projétil
        transform.Translate(Vector2.up * velocidade * Time.deltaTime);

	}

    private void OnCollisionEnter2D(Collision2D collision) {

        if(collision.gameObject.tag == "Inimigo")
        {
            Placar.Pontos++;

            // Destroy o inimigo primeiramente para não destruir esse script
            Destroy(collision.gameObject);

            // Destroi o projetil
            Destroy(gameObject);
        }
    }

}
