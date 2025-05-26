using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int speed;
    public Rigidbody2D rigid;
    
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        
    }
}
