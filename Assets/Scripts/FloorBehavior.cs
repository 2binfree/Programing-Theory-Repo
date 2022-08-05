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
            Vector3 mousePosition = Input.mousePosition;
            Ray ray = Camera.main.ScreenPointToRay(mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hitData)) {
                Vector3 target = hitData.point;
                target.y = mainManager.selectedEntity.transform.position.y;
                mainManager.SetTarget(target);  
            }
        }
    }
}
