using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleBehavior : EntityManager
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        step = 1;
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        mainManager.ResetSelected();
        mainManager.isCapsuleSelected = !mainManager.isCapsuleSelected;
    }
    
    override protected void Move()
    {
        Debug.Log("capsule move");
    }    
}
