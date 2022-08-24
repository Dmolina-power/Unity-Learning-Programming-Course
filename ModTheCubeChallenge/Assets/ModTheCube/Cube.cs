using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10;
    
    void Start()
    {
        transform.position = new Vector3(0, 4, 1);
        transform.localScale = Vector3.one * 8f;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.5f, 1.0f, 2.3f, 0.4f);
    }
    
    void Update()
    {
        transform.Rotate(80.0f * Time.deltaTime, 30.0f * Time.deltaTime, 50.0f * Time.deltaTime);

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
    }
}
