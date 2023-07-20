using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SinglePuzzleSocket : MonoBehaviour
{
    [SerializeField] private XRSocketInteractor socket;
    public int socketPlaceInPicture;
    
    public void OnPuzzlePut(SelectEnterEventArgs args)
    {
        Debug.Log("Puzzle in");
        Tile tile = args.interactableObject.transform.gameObject.GetComponent<Tile>();
        // if (IsTileInPlace(tile))
        // {
            // sound
        tile.SetInPlace(true);
        // }
    }

    public void OnTileTake(SelectExitEventArgs args)
    {
        Tile tile = args.interactableObject.transform.gameObject.GetComponent<Tile>();

        tile.SetInPlace(false);
    }

    private bool IsTileInPlace(Tile tile)
    {
        Debug.Log($"{tile.TilePlaceInShelf} and {socketPlaceInPicture}");
        return tile.TilePlaceInShelf == socketPlaceInPicture;
    }
}

