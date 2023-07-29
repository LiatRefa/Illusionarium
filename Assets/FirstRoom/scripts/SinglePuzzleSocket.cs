using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SinglePuzzleSocket : MonoBehaviour
{
    [SerializeField] private XRSocketInteractor socket;
    public int socketPlaceInPicture;
    
    public void OnHoverStart(HoverEnterEventArgs args)
    {
        Debug.Log("Puzzle in");
        Tile tile = args.interactableObject.transform.gameObject.GetComponent<Tile>();
        // if (IsTileInPlace(tile))
        // {
            // sound
        tile.SetInPlace(true);
        // }
    }

    public void OnHoverExit(HoverExitEventArgs args)
    {
        Debug.Log("Puzzle in");
        Tile tile = args.interactableObject.transform.gameObject.GetComponent<Tile>();
        // if (IsTileInPlace(tile))
        // {
            // sound
        tile.SetInPlace(false);
        // }
    }

    // public void OnTileTake(SelectExitEventArgs args)
    // {
    //     Tile tile = args.interactableObject.transform.gameObject.GetComponent<Tile>();

    //     tile.SetInPlace(false);
    // }

    private bool IsTileInPlace(Tile tile)
    {
        Debug.Log($"{tile.TilePlaceInShelf} and {socketPlaceInPicture}");
        return tile.TilePlaceInShelf == socketPlaceInPicture;
    }
}

