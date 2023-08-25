using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PuzzleMission: MonoBehaviour
{
    
    [SerializeField] private List<Tile> tiles;
    // [SerializeField] public PuzzleRoom puzzleRoom;
    private bool missionComplete;


    // Start is called before the first frame update

    void Start()
    {
        missionComplete = false;
    }

    void Update() 
    {
        CheckpuzzleCompleted();
        if (getMissionStatus())
        {
            Debug.Log("Mission completed!");
        }
    }
    
    public void CheckpuzzleCompleted()
    {
        if (!missionComplete)
        {
            // bool allTilesInPlace = tiles.All(tile => tile.IsInPlace());
            bool allTilesInPlace = tiles.All(tile => tile.IsInPlace());
          
            if (allTilesInPlace)
            {
                // AudioManager.Instance.PlayOneShotAttach(AudioManager.Sounds.WallMove, gameObject);
                missionComplete = true;
                
            }
        }  
    }

    public bool getMissionStatus()
    {
        return missionComplete;
    }

}

