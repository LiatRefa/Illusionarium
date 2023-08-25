using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField]
    SinglePuzzleSocket currPuzzleSocket;
    private bool inPlace;
    public int TilePlaceInShelf;
    

    public void Start()
    {
        inPlace = false;
    }

    public bool IsInPlace()
    {
        // return inPlace;
        if (inPlace){
        return TilePlaceInShelf == currPuzzleSocket.socketPlaceInPicture; 
        }
        return false;
    }

    public void SetInPlace(bool place)
    {
        inPlace = place;
        AudioManager.instance.PlayOneShot(FMODEvents.instance.tileInSocket, this.transform.position);
        // AudioManager.Instance.PlayOneShotAttach(AudioManager.Sounds.PushBook, gameObject);
    }
    
    // TODO: Add sound to drop
    
}
