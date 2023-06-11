using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleRoom : MonoBehaviour
{
    [SerializeField] GameObject door;
    private bool puzzleComplete;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    void Update() 
    {
        if (puzzleComplete)
        {
            door.SetActive(true);
        }
    }


}
