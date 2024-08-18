using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UIController : MonoBehaviour
{
    private Label labelPontuacao;

    private int pontos;
    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        labelPontuacao = root.Q<Label>("Pontos");
    }   


     public void AdicionarPontos()
    {   
        this.pontos++;
        this.labelPontuacao.text = this.pontos.ToString();
    }
}
