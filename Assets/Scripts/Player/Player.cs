using UnityEngine;
using System.Collections;

/*
 *  The player class allows our player to move around and jump
 */

public class Player : MonoBehaviour {

    public float speed = 10f;
    public Vector2 maxVelocity = new Vector2(3, 5);
    public float jumpSpeed = 5f;
    public bool standing; //check for standing

    //bullet stuff
    public GameObject ammo;
    public Transform fireMarker;

    //out of ammo
    public AudioClip noAmmoSound;
    public AudioClip jumpSound;

    //contect to animations class
    private Animator animator;

	// Use this for initialization
	void Start () {
        //grab the animator from the player
        animator = GetComponent<Animator>();
	
	}
	
	// Update is called once per frame
	void Update () {
        var absVelX = Mathf.Abs(rigidbody2D.velocity.x);
        var absVelY = Mathf.Abs(rigidbody2D.velocity.y);

        if (absVelY <= .05f)
        {
            standing = true;
        }
        else
        {
            standing = false;
        }

        //Clear force x,y value

        var forceX = 0f;
        var forceY = 0f;

        //Calculate the Velcity X
        if (Input.GetKey("right"))
        {
            if (absVelX < maxVelocity.x)
                forceX = speed;
            this.transform.localScale = new Vector3(1, 1, 1); // change sprite direction
            animator.SetInteger("AnimState", 1);
        }
        else if(Input.GetKey("left"))
        {
            if (absVelX < maxVelocity.x)
                forceX = -speed;
            this.transform.localScale = new Vector3(-1, 1, 1);
            animator.SetInteger("AnimState", 1);
        }
        else
        {
            animator.SetInteger("AnimState", 0);
        }

        if (Input.GetKeyDown("up") && standing)
        {
            if (jumpSound)
                AudioSource.PlayClipAtPoint(jumpSound, transform.position);

            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, jumpSpeed);

        }

        if (Input.GetKey("space") && standing)
        {
            animator.SetInteger("AnimState", 2);
            rigidbody2D.velocity = Vector2.zero;
        }
        else
        {
            rigidbody2D.AddForce(new Vector2(forceX, forceY));
        }

	
	}

    public void Fire()
    {
        if (ammo != null && AmmoManager.ammoCount > 0)
        {
            var clone = Instantiate(ammo, fireMarker.position, Quaternion.identity) as GameObject;
            clone.transform.localScale = transform.localScale;

            AmmoManager.ammoCount--;
        }
        else
        {
            if (noAmmoSound)
                AudioSource.PlayClipAtPoint(noAmmoSound, transform.position);
        }
    }
}
