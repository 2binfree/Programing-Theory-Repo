using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EntityManager : MonoBehaviour
{
    protected MainManager mainManager;
    protected int step;
    protected int speed;
    protected abstract void Move();
    protected Vector3 screenPoint;

    protected virtual void Start()
    {
        mainManager = GameObject.Find("GameManager").GetComponent<MainManager>();
        screenPoint = Camera.main.WorldToScreenPoint(transform.position);
    }
}
