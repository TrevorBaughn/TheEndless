using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardController : PlayerController
{
    [Header("Control Key Codes")]
    [SerializeField] private KeyCode wolfJump;
    [SerializeField] private KeyCode catJump;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }

    protected override void OnDestroy()
    {
        base.OnDestroy();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    protected override void ProcessInputs()
    {
        if (Input.GetKeyDown(wolfJump))
        {
            dogPawn.Jump(dogPawn.jumpForce);
        }
        if (Input.GetKeyDown(catJump))
        {
            AudioManager.instance.audioSource.PlayOneShot(AudioManager.instance.bark);
            catPawn.Jump(catPawn.jumpForce);
        }
    }
}
