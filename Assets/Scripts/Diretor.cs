using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{
    [SerializeField]
    private GameObject imagemGameOver;
    
    public void FinalizarJogo()
    {   
        //habilitar a imagem de Game Over
        this.imagemGameOver.SetActive(true);
        Time.timeScale = 0;

    }
}
