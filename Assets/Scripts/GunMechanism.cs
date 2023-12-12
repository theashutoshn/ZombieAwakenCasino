using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunMechanism : MonoBehaviour
{
    private float _speed = 0.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));

        transform.position = Vector3.MoveTowards(transform.position, mousePos, _speed * Time.deltaTime);
    }
}
