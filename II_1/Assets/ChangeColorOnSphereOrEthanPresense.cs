using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnSphereOrEthanPresense : MonoBehaviour
{
    private Renderer _renderer;
    private float redColorComponent = 0.0f;
    private float greenColorComponent = 0.0f;
    private float blueColorComponent = 0.0f;

    void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void UpdateColor()
    {
        _renderer.material.color = new Color(redColorComponent, greenColorComponent, blueColorComponent);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Sphere"))
        {
            redColorComponent = 1.0f;
        }
        if (collision.gameObject.tag.Equals("Ethan"))
        {
            blueColorComponent = 1.0f;
        }
        UpdateColor();
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Sphere"))
        {
            redColorComponent = 0.5f;
        }
        if (collision.gameObject.tag.Equals("Ethan"))
        {
            blueColorComponent = 0.5f;
        }
        UpdateColor();
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Sphere"))
        {
            redColorComponent = 0.1f;
        }
        if (collision.gameObject.tag.Equals("Ethan"))
        {
            blueColorComponent = 0.1f;
        }
        UpdateColor();
    }
}