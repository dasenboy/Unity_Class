using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LuaInterface;


public class UIModule : MonoBehaviour
{
    public string ModuleName;


    public List<UISprite> List_Sprite;
    public List<UILabel> List_Label;
    public List<UIButton> List_Button;
    public List<GameObject> List_Object;
    public List<UITexture> List_Texture;


    public void Btn_OnClick(GameObject btn)
    {

        LuaManager.Instance.LuaClient.luaState.DoFile("OneButton.lua");
        string func =""+ ModuleName + ".OnClick";
        LuaManager.Instance.LuaClient.CallFunc(func, btn.name);
    }
}
