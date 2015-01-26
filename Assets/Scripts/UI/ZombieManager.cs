using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ZombieManager : MonoBehaviour {

    public static int zombieCount;
    public int count = 0;

    Text text;

    void Awake()
    {
        text = GetComponent<Text>();
        zombieCount = count;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Zombies Slain: " + zombieCount;
    }
}
