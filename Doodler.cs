using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doodler : MonoBehaviour
{
    public float moveSpeed;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2 (h*moveSpeed,rb.velocity.y);
        if (h != 0)
        {
            transform.localScale = new Vector3 (-h,1,1);
        }
    }
}
