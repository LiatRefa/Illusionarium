using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleRoom : MonoBehaviour
{
    [SerializeField] GameObject door;
    [SerializeField] GameObject astroids;
    [SerializeField] GameObject puzzlePic;
    private bool puzzleComplete = false;

    public Material spaceSky;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    void Update() 
    {
        
        if (puzzleComplete)
        {
            door.SetActive(true);
            astroids.SetActive(true);
            puzzlePic.SetActive(true);
            RenderSettings.skybox = spaceSky;


        }
    }


}
