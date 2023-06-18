using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PuzzleRoom : MonoBehaviour
{
    [SerializeField]
    PuzzleMission pr;
    [SerializeField] GameObject door;
    [SerializeField] GameObject astroids;
    [SerializeField] GameObject puzzlePic;
    
    //   private bool puzzleComplete = false;

    public Material spaceSky;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update() 
    {
        pr.CheckpuzzleCompleted();
        if (pr.getMissionStatus())
        {
            door.SetActive(true);
            astroids.SetActive(true);
            //puzzlePic.SetActive(true);
            RenderSettings.skybox = spaceSky;


        }
    }


}
