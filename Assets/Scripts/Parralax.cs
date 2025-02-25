using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parralax : MonoBehaviour
{

    private MeshRenderer meshRenderer;
    public float animationSpeed = 1f;

    private void Awake() {
        meshRenderer = GetComponent<MeshRenderer>();
    }


    // Update is called once per frame
    private void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);
    }
}
