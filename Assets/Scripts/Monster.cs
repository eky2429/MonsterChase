using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [HideInInspector]
    public float speed = 10f;

    private Rigidbody2D myBody;

    // Frist function called
    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per "fixed" frame
    void FixedUpdate()
    {
        myBody.velocity = new Vector2(speed, myBody.velocity.y);
    }
}
