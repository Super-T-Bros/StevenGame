using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TextAdventure/InputActions/Go")]
public class Go : InputAction
{
    public override void RespondToInput(GameController controller, string[] separatedInputWords)
    {
        //dont want to create vars that will be in the scene, pass them in
        controller.roomNavigation.AttemptToChangeRooms(separatedInputWords[1]);
    }
}
