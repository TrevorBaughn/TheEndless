using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfPawn : Pawn
{
    public Vector3 startPos;
    public Rigidbody2D rigidbody2d;
    public BoxCollider2D boxcollider2d;
    public float jumpForce;
    public LayerMask platformsLayerMask;

    private void Awake()
    {
        startPos = this.transform.position;
    }

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        
        rigidbody2d = GetComponent<Rigidbody2D>();
        boxcollider2d = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Jump(float force)
    {
        if (IsGrounded())
        {
            rigidbody2d.velocity = Vector2.up * force;
        }
        
    }

    private bool IsGrounded()
    {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxcollider2d.bounds.center, 
                                                        boxcollider2d.bounds.size,
                                                        0f,
                                                        Vector2.down, 
                                                        0.1f, 
                                                        platformsLayerMask);
        return raycastHit2d.collider != null;
    }
}
