using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;
public class Tutorial : MonoBehaviour
{
    private void Awake()
    {
        Advertisement.Show();
    }
    public AudioClip ButtonClick;
    public void Home()
    {
        AudioSource.PlayClipAtPoint(ButtonClick, Vector3.zero);
        SceneManager.LoadScene("StartScene");
    }
}
