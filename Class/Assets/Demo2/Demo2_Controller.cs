using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;

public class Demo2_Controller : MonoBehaviour
{
   public void EnterGame()
    {
        SceneComponent scene = UnityGameFramework.Runtime.GameEntry.GetComponent<SceneComponent>();
        scene.LoadScene("Assets/Demo2/Demo2_Game.unity", this);
        
    }
}
