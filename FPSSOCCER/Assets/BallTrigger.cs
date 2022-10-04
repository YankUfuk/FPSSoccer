using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTrigger : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider obj){
    if(obj.gameObject.tag == "Ball")
    {
        transform.root.gameObject.GetComponent<CharacterBall>().ball = true;
    }
    
}

void OnTriggerStay(Collider obj){
    if(obj.gameObject.tag == "Ball")
    {
        transform.root.gameObject.GetComponent<CharacterBall>().ball = true;
    }
    
}

void OnTriggerExit(Collider obj){
    if(obj.gameObject.tag == "Ball")
    {
        transform.root.gameObject.GetComponent<CharacterBall>().ball = false;
    }
    
}

}
