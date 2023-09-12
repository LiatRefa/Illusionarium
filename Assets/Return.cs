using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;

public class Return : MonoBehaviour
{
     public void OnHoverEnter(HoverEnterEventArgs args)
    {
        SceneManager.LoadScene(2);
    }
}
