using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour {

    public float velocidade;
    public float alturaY;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        // verifica se o usuário está tocando na tela...
        if(Input.GetButton("Fire1"))
        {
            // recebe o touche na tela e converte em coordenada do mundo
            Vector2 posicaoMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // Reatribui a posição do mouse adicionando altura em Y
            posicaoMouse = new Vector2(posicaoMouse.x, posicaoMouse.y + alturaY);

            // Move o objeto para coordenada indicada
            transform.position = Vector2.Lerp(transform.position, posicaoMouse, velocidade * Time.deltaTime);
        }

	}
}
