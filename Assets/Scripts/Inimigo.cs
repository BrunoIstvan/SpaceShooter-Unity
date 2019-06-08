using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour {

    private Rigidbody2D rb2d; // recebe o componente rigidbody2d do inimigo
    public float velocidadeMin, velocidadeMax;
    private float velocidade;
    public GameObject explosao; // recebe o prefab da explosão

    // Use this for initialization
    void Start () {        
        // determina o tempo de vida do inimigo
        Destroy(gameObject, 5.0f);

        // recupera o rigidbody do inimigo
        rb2d = GetComponent<Rigidbody2D>();
        // zera a gravidade para que ele não caia logo que é criado...
        rb2d.gravityScale = 0.0f;
        // gera um número randomico entre a velocidade mínima e máxima... 
        velocidade = Random.Range(velocidadeMin, velocidadeMax);
    }

    void FixedUpdate() {
        // aplica a velocidade gerada randomicamente ao inimigo
        rb2d.velocity = new Vector2(0.0f, velocidade * -1);
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D c)
    {
        Instantiate(explosao, transform.position, transform.rotation);
        Destroy(gameObject);
    }


}
