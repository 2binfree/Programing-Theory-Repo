using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorBehavior : EntityManager
{
    private Camera cam;
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        cam = Camera.main;
    }

    protected override void Move()
    {
        
    }

    void OnMouseDown()
    {
        if (gameObject.CompareTag("Floor")) {
            Vector3 mousePos = Input.mousePosition;
            mainManager.SetTarget(cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane)));  
        }
    }
}
