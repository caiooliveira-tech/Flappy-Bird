using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
   Rigidbody2D fisica;
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

    void Impulsionar(){
        this.fisica.AddForce(Vector2.up * 3, ForceMode2D.Impulse);
    }
}
