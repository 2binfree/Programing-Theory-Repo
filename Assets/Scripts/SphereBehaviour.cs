using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class SphereBehaviour : EntityManager
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        Speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (mainManager.sphereTarget != Vector3.zero && mainManager.sphereTarget != gameObject.transform.position) {
            Move();
        }     
    }
    void OnMouseDown()
    {
        mainManager.ResetSelected();
        mainManager.isSphereSelected = !mainManager.isSphereSelected;
        if (mainManager.isSphereSelected) {
            mainManager.selectedEntity = gameObject;
        }
    }
    
    override protected void Move()
    {
        float step =  Speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, mainManager.sphereTarget, step);
    }    
}
