using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EntityManager : MonoBehaviour
{
    protected MainManager mainManager {get; set;}
    private int speed;

    // ENCAPSULATION
    public int Speed {
        get { return speed; }
        set {
            if (value < 3) {
                speed = 3;
            } else if (value > 10) {
                speed = 10;
            } else {
                speed = value;
            }
        }
    }
    // ABSTRACTION
    protected abstract void Move();

    // POLYMORPHISM
    protected virtual void Start()
    {
        mainManager = GameObject.Find("GameManager").GetComponent<MainManager>();
    }
}
