using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    public GameObject Pig;
    public GameObject Pattern;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            Destroy();
        }
    }
    private void Destroy()
    {
        Destroy(Pig);
        Instantiate(Pattern, transform.position, Quaternion.identity);
    }
}
