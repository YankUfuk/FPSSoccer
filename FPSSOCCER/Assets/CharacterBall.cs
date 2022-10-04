using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBall : MonoBehaviour
{
    public bool ball;
    public GameObject ballObj;

    public float shoot1, shoot2, air1, air2;
    void Start()
    {
        
    }

    
    void Update()
    {
        if(ball){
            if(Input.GetMouseButtonDown(0)){
                ballObj.GetComponent<Rigidbody>().velocity = transform.TransformDirection(new Vector3(0,0,10));
            }

            if(Input.GetMouseButtonDown(1)){
                ballObj.GetComponent<Rigidbody>().velocity = transform.TransformDirection(new Vector3(0,Random.Range(air1, air2),Random.Range(shoot1,shoot2)));
            }
        }
    }
}
