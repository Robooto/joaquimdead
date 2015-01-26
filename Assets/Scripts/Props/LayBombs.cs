using UnityEngine;
using System.Collections;

public class LayBombs : MonoBehaviour
{
	[HideInInspector]
	public bool bombLaid = false;		// Whether or not a bomb has currently been laid.
	//public AudioClip bombsAway;			// Sound for when the player lays a bomb.
	public GameObject bomb;				// Prefab of the bomb.



	void Awake ()
	{
		// Setting up the reference.
		//bombHUD = GameObject.Find("ui_bombHUD").guiTexture;
	}

	void Update ()
	{
		// If the bomb laying button is pressed, the bomb hasn't been laid and there's a bomb to lay...
        if (Input.GetKey(KeyCode.LeftControl) && !bombLaid && BombManager.bombCount > 0)
		{
			// Decrement the number of bombs.
            BombManager.bombCount--;

			// Set bombLaid to true.
			bombLaid = true;

			// Play the bomb laying sound.
			//AudioSource.PlayClipAtPoint(bombsAway,transform.position);

			// Instantiate the bomb prefab.
            GameObject clone = Instantiate(bomb, transform.position, transform.rotation) as GameObject;
            clone.rigidbody2D.velocity =  new Vector2(3, 0) * transform.localScale.x;
            clone.rigidbody2D.AddForce(Vector3.up * Random.Range(100, 200));
            
		}
	}
}
