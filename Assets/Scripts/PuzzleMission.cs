using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PuzzleMission: MonoBehaviour
{
    
    [SerializeField] private List<Tile> tiles;
    // [SerializeField] private Animator _wallAnimator;
    private bool missionComplete;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!missionComplete)
        {
            bool allTilesInPlace = tiles.All(tile => tile.IsInPlace());
            if (allTilesInPlace)
            {
                // _wallAnimator.SetTrigger("Open");
                // AudioManager.Instance.PlayOneShotAttach(AudioManager.Sounds.WallMove, gameObject);
                missionComplete = true;
            }
        }  
    }
}

