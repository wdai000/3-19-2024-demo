using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string playerName;
        bool hasCard;
        int totalScraps;
        int soulCount;

        playerName = "Bob";
        hasCard = false;
        totalScraps = 25;
        soulCount = 250;

        //a line that will always print 
        Debug.Log("Welcome to Scrap It!");

        //an if statement that will trigger 
        if (playerName == "Bob")
        {
            Debug.Log("Hi Bob.");
        }

        //an if statement that will not trigger 
        if (playerName == "Sally")
        {
            Debug.Log("Hi Sally.");
        }

        //an if else statement that will trigger 
        if (hasCard == false)
        {
            Debug.Log("You can't proceed without the card, Bob.");
        }
        else
        {
            Debug.Log("You may proceed, Bob.");
        }

        //an if else statement that will not trigger, therefore exectue "else" 
        if (totalScraps > 50)
        {
            Debug.Log("You may access the shop.");
        }
        else
        {
            Debug.Log("You are too broke to access the shop.");
        }

        //if else if else statement 
        if (totalScraps == 50)
        {
            Debug.Log("Total Scraps: 100. Congrats, you are now middle class");
        }
        else if (totalScraps > 150)
        {
            Debug.Log("Total Scraps: More than 50. Congrats, you are now middle-class.");
        }
        else if (totalScraps < 50)
        {
            Debug.Log("Total Scraps: Less than 50. Go back to the dungeon.");
        }

        //if statements that use combining logic
        if(hasCard == false || totalScraps<50)
        {
            Debug.Log("You may trade a soul for a scrap. 300 souls for one card");
        }

        //if statement that prints at least 3 separate lines
        if(soulCount < 300)
        {
            Debug.Log("You still need " + (300 - soulCount) + " more souls.");
            Debug.Log("To obtain souls, you will require a cauldon.");
            Debug.Log("Speak with local witch for further information.");
        }

        //nested if statement
        if(hasCard == true)
        {
            if (soulCount > 300)
            {
                Debug.Log("Congrats, you can unlock shop of fables.");
            }
            else
            {
                Debug.Log("To unlock shop of fables, " +
                    "you need your keyCard and have at least 300 souls." +
                    "You do not have enough souls.");
            }
        }






    }



    // Update is called once per frame 

    void Update()

    {



    }

}
