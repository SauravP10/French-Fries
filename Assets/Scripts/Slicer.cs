using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slicer : MonoBehaviour
{
    public GameObject trailPrefab;
    public float minSliceVelocity = 0.001f;

    GameObject currentTrail;
    CircleCollider2D cCollider;

    Vector2 prevPos;

    bool isSlicing = false;

    Rigidbody2D rb;

    Camera cam;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cam = Camera.main;  
        cCollider= GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartSlicing();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            StopSlicing();
        }

        if(isSlicing)
        {
            SlicerPos();
        }
    }

    void SlicerPos()
    {
        Vector2 newPos = cam.ScreenToWorldPoint(Input.mousePosition);
        rb.position = newPos;

        float velocity = (newPos- prevPos).magnitude * Time.deltaTime;
        if(velocity>minSliceVelocity)
        {
            cCollider.enabled = true;
        }
        else
        {
            cCollider.enabled = false;  
        }

        prevPos= newPos;
    }

    void StartSlicing()
    {
        isSlicing = true;
        currentTrail = Instantiate(trailPrefab, transform);  
        prevPos = cam.ScreenToWorldPoint(Input.mousePosition); 
        cCollider.enabled= false;    
    }

    void StopSlicing()
    {
        isSlicing = false;
        currentTrail.transform.SetParent(null);
        Destroy(currentTrail, 1f);
        cCollider.enabled= false;   
    }
}
