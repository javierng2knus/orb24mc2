using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPhysics : MonoBehaviour
{
    public float force;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            // do smt
            Rigidbody2D rb = this.gameObject.GetComponent<Rigidbody2D>();
            rb.AddForce(new Vector2(1, 0) * force);
        }
    }
}
