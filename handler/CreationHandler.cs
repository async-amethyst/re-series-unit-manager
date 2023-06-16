using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddUnit()
    {

    }

    public void CreateNewUnitPage()
    {
        GameObject unitObject = Instantiate(Resources.Load<GameObject>("Prefabs/DefaultUnitManageInterface"));
        //We will put more code here that will take some of the children of the object, and add listeners to them. This will make it so that when you click the checkbox, it will change the values in the variable as well. I'm too lazy to write this right now though, so uh... yeah.
    }
}
