using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalData
{
    //Member variables can be referred to as
    //fields.
    private int xPosition;
    private int yPosition;

    //Experience is a basic property
    public int XPosition
    {
        get
        {
            //Some other code
            return xPosition;
        }
        set
        {
            //Some other code
            xPosition = value;
        }
    }

    //Level is a property that converts experience
    //points into the leve of a player automatically
   /* public int yPosition
    {
        get
        {
            return xPosition ;
        }
        set
        {
            xPosition = value ;
        }
    }*/

    //This is an example of an auto-implemented
    //property
   
}



