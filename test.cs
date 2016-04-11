using UnityEngine;
using System.Collections;

public sealed class Character_Controller : MonoBehaviour
{
    private CharacterController character_control = null;
    public Character_Controller()
    {
        character_control = GetComponent<CharacterController>();
    }
    ~Character_Controller()
    {
        this.unloadMemory();
    }
    void OnDestroy()
    {
        this.unloadMemory();
    }
    private void unloadMemory()
    {
        this.character_control = null;
        System.GC.Collect();
    }
    // Use this for initialization
	void Start ()
    {
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {

        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {

        }
        else if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {

        }
    }
}
