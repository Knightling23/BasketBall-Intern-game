using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fullscreen : MonoBehaviour
{
    // Start is called before the first frame update
    public void fullscreens(bool is_fullscene)
        {
        Screen.fullScreen =is_fullscene;

        }
}
