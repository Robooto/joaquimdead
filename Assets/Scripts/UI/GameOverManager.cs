using UnityEngine;
using System.Collections;

public class GameOverManager : MonoBehaviour {

    //public PlayerHealth playerHealth;
    public float restartDelay = 5f;

    Animator anim;
    float restartTimer;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	       
	}

    public void EndGame()
    {
        anim.SetTrigger("GameOver");

        restartTimer += Time.deltaTime;

        if (restartTimer >= restartDelay)
        {
            Application.LoadLevel(Application.loadedLevel);
        }

    }

    public void Restart()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    public void Testbutton()
    {
        Debug.Log("Button Click");
    }
}
