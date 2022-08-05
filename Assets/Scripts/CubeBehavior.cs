using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class CubeBehavior : EntityManager
{
    public float power = 500.0f;
    public bool moving;
    private Rigidbody rb;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        moving = false;
        rb = gameObject.GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!moving && mainManager.cubeTarget != Vector3.zero) {
            Move();
            moving = true;
        }
        if (moving == true && rb.velocity.magnitude < 0.02 ) {
            moving = false;
            mainManager.cubeTarget = Vector3.zero;
        }
    }

    void OnMouseDown()
    {
        mainManager.ResetSelected();
        mainManager.isCubeSelected = !mainManager.isCubeSelected;
        if (mainManager.isCubeSelected) {
            mainManager.selectedEntity = gameObject;
        }
    }

    override protected void Move()
    {
        Vector3 force = CalcBallisticVelocityVector(transform.position, mainManager.cubeTarget, 45.0f);
        rb.velocity = force;
    }

    // ABSTRACTION
    Vector3 CalcBallisticVelocityVector(Vector3 source, Vector3 target, float angle)
    {
         Vector3 direction = target - source;                            
         float h = direction.y;                                           
         direction.y = 0;                                               
         float distance = direction.magnitude;                           
         float a = angle * Mathf.Deg2Rad;                                
         direction.y = distance * Mathf.Tan(a);                            
         distance += h/Mathf.Tan(a);                                      
 
         // calculate velocity
         float velocity = Mathf.Sqrt(distance * Physics.gravity.magnitude / Mathf.Sin(2*a));
         return velocity * direction.normalized;    
     }
}
