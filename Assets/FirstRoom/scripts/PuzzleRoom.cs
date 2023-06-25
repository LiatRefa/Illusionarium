using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PuzzleRoom : MonoBehaviour
{
    [SerializeField]
    PuzzleMission puzzle;
    [SerializeField] GameObject door;
    [SerializeField] GameObject astroids;
    public Material spaceSky;


    // Start is called before the first frame update
    void Start()
    {

    }

    void Update() 
    {
        puzzle.CheckpuzzleCompleted();
        if (puzzle.getMissionStatus())
        {
            door.SetActive(true);
            astroids.SetActive(true);
            RenderSettings.skybox = spaceSky;


        }
    }


}
