using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaScript : MonoBehaviour {

    public GameObject projetilPrefab;
	
    void Start () {

        StartCoroutine(Atirar());

	}

    IEnumerator Atirar()
    {
        // Instancia um projetil
        Instantiate(projetilPrefab, transform.position, transform.rotation);
        // aguarda meio segundo para executar...
        yield return new WaitForSeconds(0.5f);
        // reexecuta essa coroutine
        StartCoroutine(Atirar());
    }



}
