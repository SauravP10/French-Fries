using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Veg : MonoBehaviour
{
    public GameObject slicedPrefab;

    Rigidbody2D rb;
    public float Force = 20f;

    private int scoreCount;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * Force, ForceMode2D.Impulse);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Slicer")
        {
            Vector3 direction = (collision.transform.position - transform.position).normalized;
            Quaternion rot = Quaternion.LookRotation(direction);
            GameObject slicedVeg = Instantiate(slicedPrefab, transform.position, rot);
            Score.instance.AddScore();           
            Destroy(slicedVeg, 3f);
            Destroy(gameObject);
        }        
    }
}
