using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;

public class move_third_room : MonoBehaviour
{
    public void onSelectEnter(SelectEnterEventArgs args)
    {
        SceneManager.LoadScene(2);
    }
}
