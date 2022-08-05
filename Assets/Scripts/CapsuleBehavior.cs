using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class CapsuleBehavior : EntityManager
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        if (mainManager.capsuleTarget != Vector3.zero && mainManager.capsuleTarget != gameObject.transform.position) {
            Move();
        }            
    }
    void OnMouseDown()
    {
        mainManager.ResetSelected();
        mainManager.isCapsuleSelected = !mainManager.isCapsuleSelected;
        if (mainManager.isCapsuleSelected) {
            mainManager.selectedEntity = gameObject;
        }
    }
    
    override protected void Move()
    {
        transform.position = mainManager.capsuleTarget;
    }    
}
