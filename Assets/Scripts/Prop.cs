using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prop : MonoBehaviour
{
    public float moveSpeed;
    public GameObject floor;

    private Rigidbody2D rigidbodyComponent;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(!other.gameObject.CompareTag("Platform"))
        {
            //delete later
            Destroy(this.gameObject);

            GameManager.instance.ActivateGameOverState();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //move left
        rigidbodyComponent.MovePosition(transform.position -= transform.right * (moveSpeed * Time.deltaTime));

        if(transform.position.x <= -30)
        {
            GameManager.instance.score += 1;
            AudioManager.instance.audioSource.PlayOneShot(AudioManager.instance.score);

            Destroy(this.gameObject);
        }
    }
}
