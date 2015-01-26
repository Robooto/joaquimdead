using UnityEngine;
using System.Collections;

/*
 * Move our zombie forward
 */

public class MoveForward : MonoBehaviour {

    public float speed = .3f;

	// Use this for initialization
	void Start () {
        var numbers = new int[] { -1, 1 };
        var pick = numbers[Random.Range(0, numbers.Length)];
        this.transform.localScale = new Vector3(this.transform.localScale.x * pick, 1, 1);
	}
	
	// Update is called once per frame
	void Update () {
        rigidbody2D.velocity = new Vector2(this.transform.localScale.x * speed, rigidbody2D.velocity.y);
	}
}
