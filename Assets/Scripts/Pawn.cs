using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pawn : MonoBehaviour, Mover
{
    public Controller controller;

    // Start is called before the first frame update
    protected virtual void Start()
    {

    }

    public abstract void Jump(float force);
}
