using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour{
   
  	public float Velocidade = 10.0f;
  	public float HorizontalAxis;
  	public Rigidbody2D rigibody;

  	void Start(){
  		rigibody = GetComponent<Rigidbody2D>();
  	}

  	void Update () {
  		HorizontalAxis = Input.GetAxis ("Horizontal");
  		rigibody.velocity = new Vector2 (Velocidade * HorizontalAxis, 0);
  	}
}
