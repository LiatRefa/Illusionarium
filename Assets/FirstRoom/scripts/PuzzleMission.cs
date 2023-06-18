using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PuzzleMission: MonoBehaviour
{
    
    [SerializeField] private List<Tile> tiles;
    private bool missionComplete;

    // Start is called before the first frame update
    void Start()
    {
        missionComplete = false;
    }
    
    public void CheckpuzzleCompleted()
    {
        if (!missionComplete)
        {
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

