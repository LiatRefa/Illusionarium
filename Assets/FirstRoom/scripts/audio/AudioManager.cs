using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
using FMOD.Studio;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance { get; private set; }
    private EventInstance musicEventInstance;
    private List<EventInstance> eventInstances;
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Found more than one Audio Manager in the scene.");
        }
        instance = this;
        eventInstances = new List<EventInstance>();
    }

    private void Start()
    {
        InitializeMusic(FMODEvents.instance.ambience);
    }

    private void InitializeMusic(EventReference musicEventReference)
    {
        musicEventInstance = CreateInstance(musicEventReference);
        musicEventInstance.start();
    }

    public EventInstance CreateInstance(EventReference eventReference)
    {
        EventInstance eventInstance = RuntimeManager.CreateInstance(eventReference);
        eventInstances.Add(eventInstance);
        return eventInstance;
    }

    public void SetMusicStage(SolvedPuzzle stage)
    {
        musicEventInstance.setParameterByName("Puzzle Solved", (float)stage);
    }

    public void PlayOneShot(EventReference sound, Vector3 worldPos)
    {
        RuntimeManager.PlayOneShot(sound, worldPos);
    }

    private void CleanUp()
    {
        // stop and release any created instances
        foreach (EventInstance eventInstance in eventInstances)
        {
            eventInstance.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
            eventInstance.release();
        }
        
    }

    private void OnDestroy()
    {
        CleanUp();
    }

}
