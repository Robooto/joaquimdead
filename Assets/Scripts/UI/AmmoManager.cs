using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AmmoManager : MonoBehaviour {

    public static int ammoCount;
    public static int bombCount;
    public int bombcount = 3;
    public int count = 20;

    Text text;

    void Awake()
    {
        text = GetComponent<Text>();
        ammoCount = count;
        bombCount = bombcount;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        text.text = "Ammo: " + ammoCount;
	}
}
