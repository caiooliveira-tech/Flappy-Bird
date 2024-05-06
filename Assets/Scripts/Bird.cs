using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
   Rigidbody2D fisica;
   [SerializeField]
   private float forca = 3;
    // Update is called once per frame

    private void Awake(){
        this.fisica = this.GetComponent<Rigidbody2D>();
    }
    void Update()
    {   

        if(Input.GetMouseButtonDown(0))
        {
            this.Impulsionar();
        }
    }

    void Impulsionar()
    {
        this.fisica.velocity = Vector2.zero;
        this.fisica.AddForce(Vector2.up * this.forca, ForceMode2D.Impulse);
    }
}
