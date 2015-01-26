using UnityEngine;
using System.Collections;

/*
 * When player collides with ammo pack add ammo and destroy pack
 * Collider on pack and player need to be the same.  Was triggering box collider and wasn't working.  Switched to circle colider and it started working.
 */

public class AmmoPickup : MonoBehaviour {

    public int addAmmo = 5;

    private AmmoSpawner ammoSpawner;	// Reference to the pickup spawner.
    public AudioClip ammoSound;

    void Awake()
    {
        // Setting up the references.
        ammoSpawner = GameObject.Find("AmmoPackSpawner").GetComponent<AmmoSpawner>();
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D target){

        if (target.gameObject.tag == "Player")
        {

            if (ammoSound)
                AudioSource.PlayClipAtPoint(ammoSound, transform.position);

            AmmoManager.ammoCount += addAmmo;

            // Trigger a new delivery.
            ammoSpawner.StartCoroutine(ammoSpawner.SpawnAmmo());

            Destroy(transform.root.gameObject);

           
        }
    }
}
