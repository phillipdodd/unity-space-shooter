using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UVScroll : MonoBehaviour
{
    public Vector2 speed;

    private Renderer r;

    private void Start()
    {
        r = GetComponent<Renderer>();
    }

    private void Update()
    {
        r.material.mainTextureOffset = speed * Time.time;
    }
}
