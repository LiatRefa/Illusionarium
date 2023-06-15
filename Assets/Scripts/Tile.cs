using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    private bool inPlace;
    public int TilePlaceInShelf;
    public bool IsInPlace()
    {
        return inPlace;
    }

    public void SetInPlace(bool place)
    {
        inPlace = place;
        // AudioManager.Instance.PlayOneShotAttach(AudioManager.Sounds.PushBook, gameObject);
    }
    
    
    // TODO: Add sound to drop
}
