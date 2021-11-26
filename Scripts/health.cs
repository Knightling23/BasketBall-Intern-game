using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class health : MonoBehaviour
{
    // Start is called before the first frame update
    public int Healthpoints;
    public int numOfHearts;

    public Image[] Hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    private void Awake()
    {
        MainScript.healthman += tookdmage;

    }
        private void Update()
    {
        
        if (Healthpoints > numOfHearts)
        {
            Healthpoints = numOfHearts;
        }
        

        for (int i=0; i < Hearts.Length; i++)//determines how much health they have
        {
            if (i < Healthpoints)
            {

                Hearts[i].sprite = fullHeart;
            }

            else {
                Hearts[i].sprite = emptyHeart;
            }



            if (i < numOfHearts)// determines make health
            {
                Hearts[i].enabled = true;
            }

            else
            {
                Hearts[i].enabled = false;
            }



        }

       

    }


    public void tookdmage()// lose 1 health per wrong question
    {
        Healthpoints = Healthpoints - 1;

    }
}
