using UnityEngine;
using System.Collections;

public class AmmoSpawner : MonoBehaviour {

    public GameObject ammoPack;
    public float delayTimer = 5f;
    public float dropRangeLeft = 1;					// Smallest value of x in world coordinates the delivery can happen at.
    public float dropRangeRight = 20;				// Largest value of x in world coordinates the delivery can happen at.


	// Use this for initialization
	void Start () {
        // Start the first delivery.
        StartCoroutine(SpawnAmmo());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public IEnumerator SpawnAmmo()
    {
        // Wait for the delivery delay.
        yield return new WaitForSeconds(delayTimer);

        // Create a random x coordinate for the delivery in the drop range.
        float dropPosX = Random.Range(dropRangeLeft, dropRangeRight);

        //Create drop on first or second floor
        var numbers = new double[] { -2.85, -6.15 };
        var dropPosY = numbers[Random.Range(0, numbers.Length)];

        // Create a position with the random x coordinate.
        Vector2 dropPos = new Vector2(dropPosX, (float)dropPosY);

        Instantiate(ammoPack, dropPos, Quaternion.identity);
    }
}

