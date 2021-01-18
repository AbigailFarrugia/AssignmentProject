using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlatformBehavior : MonoBehaviour
{
    [SerializeField]
    private int _blockID;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player" && _blockID == 0)
        {
            Destroy(this.gameObject, 3f);

        }
        else if (other.gameObject.tag == "Player" && _blockID == 1)
        {
            Destroy(this.gameObject, 1f);
        }
        else if(other.gameObject.tag == "Player" && _blockID == 2)
        {
            SceneManager.LoadScene(0);
        }

    }


}
