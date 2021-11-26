using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getmainchar : MonoBehaviour
{
    Animation Animation1;
    Animation Animation2;

    public Sprite Playerform1, Playerform2;
    private SpriteRenderer mySprite;
    private readonly string selectedchar = "SelectedCharacter";


    private void Awake()
    {
        mySprite = this.GetComponent<SpriteRenderer>();

    }

    // Start is called before the first frame update
    void Start()
    {

        int getCharacter;
       
        getCharacter = PlayerPrefs.GetInt(selectedchar);


        switch(getCharacter)
        {
            case 1:
                
                mySprite.sprite = Playerform1;
                

                break;

            case 2:
                mySprite.sprite = Playerform2;
               
                break;

            default: 
                break;

        }
    }

}
