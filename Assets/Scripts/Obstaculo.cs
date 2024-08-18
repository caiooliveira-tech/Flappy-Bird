using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.6f;
    [SerializeField]
    private float variacaoY;
    private Vector3 posicaoBird;
    private bool pontuei;
    private UIController pontuacao;
    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoY, variacaoY));
    }
    private void Start()
    {
        this.posicaoBird = GameObject.FindObjectOfType<Bird>().transform.position;
        this.pontuacao = GameObject.FindObjectOfType<UIController>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.left * velocidade * Time.deltaTime);
        if(!this.pontuei && this.transform.position.x < this.posicaoBird.x)
        {
            pontuacao.AdicionarPontos();
            this.pontuei = true;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.Destruir();
    }
    void Destruir()
    {
        GameObject.Destroy(this.gameObject);
    }
}
