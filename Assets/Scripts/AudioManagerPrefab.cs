using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class AudioManagerPrefab : MonoBehaviour
{
   
    AudioSource audioSource;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
       
        

    }

    private void Start()
    {
        audioSource.Play();
        Debug.Log("Played");
        SceneManager.activeSceneChanged += SceneManager_activeSceneChanged;
    }

    private void SceneManager_activeSceneChanged(Scene arg0, Scene arg1)
    {
        if (arg1.buildIndex != 0)
        {
            Debug.Log("StartSound");
            StartCoroutine(FadeSound(audioSource, 1f, 0f));
        }
    }

    IEnumerator FadeSound(AudioSource audioSource, float duration, float targetVolume)
    {
        float currentTime = 0;
        float start = audioSource.volume;
        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
            audioSource.volume = Mathf.Lerp(start, targetVolume, currentTime / duration);
            yield return null;
        }
        yield break;
    }
}
