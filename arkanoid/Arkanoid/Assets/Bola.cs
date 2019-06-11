using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour {

    public Vector2 Velocidade;

    // Start is called before the first frame update
    void Start () {

        Rigidbody2D rigidbody = GetComponent<Rigidbody2D> ();
        rigidbody.AddForce (Velocidade);

    }

}