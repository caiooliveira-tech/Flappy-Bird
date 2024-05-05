using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculos : MonoBehaviour
{
    [SerializeField]
    private float tempoParaGerar;
    //Controla quanto tempo já passou para sabermos se já podemos gerar outro
    private float cronometro;
    [SerializeField]
    private GameObject modeloObstaculo;
    void Awake()
    {
        this.cronometro = this.tempoParaGerar;
    }

    // Update is called once per frame
    void Update()
    {
        this.cronometro -= Time.deltaTime;
        Debug.Log(cronometro);
        if(this.cronometro <0) {
            // Instantiate precisa do objeto que será instanciado, a posição e se ele será rotacionado ou não
            GameObject.Instantiate(this.modeloObstaculo, this.transform.position,Quaternion.identity);
            this.cronometro = this.tempoParaGerar;
        }
    }
}
