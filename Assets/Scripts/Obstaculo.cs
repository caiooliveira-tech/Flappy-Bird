using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour {
    [SerializeField]
    private float velocidade = 0.005f;

    private void Update () {
        this.transform.Translate(Vector3.left * this.velocidade);
       
        
	}
}
