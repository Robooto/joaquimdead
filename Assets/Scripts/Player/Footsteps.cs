using UnityEngine;
using System.Collections;

/*
 * Footsteps for our player
 */

public class Footsteps : MonoBehaviour {
    public AudioClip leftFootSound;
    public AudioClip rightFootSound;

    void PlayLeftFootSound()
    {
        if (leftFootSound)
            AudioSource.PlayClipAtPoint(leftFootSound, transform.position);
    }

    void PlayRightFootSound()
    {
        if (rightFootSound)
            AudioSource.PlayClipAtPoint(rightFootSound, transform.position);
    }
}
