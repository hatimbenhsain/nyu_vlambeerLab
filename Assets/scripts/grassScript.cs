using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grassScript : MonoBehaviour
{
    public GameObject wall;
	public Sprite[] grasses;
    public Pathmaker pathmaker;
    bool walled=false;
    // Start is called before the first frame update
    void Start()
    {
        int k=Random.Range(0,grasses.Length);
        GetComponent<SpriteRenderer>().sprite=grasses[k];
    }

    // Update is called once per frame
    void Update()
    {
        // if(!walled && (Pathmaker.endedSpheres==Pathmaker.sphereNumber || Pathmaker.floorNum==pathmaker.maxTiles)){
        //     print(this);
        //     float d=pathmaker.movementUnit;
        //     Vector2[] directions={new Vector2(d,0),new Vector2(d,d),new Vector2(0,d),new Vector2(-d,d),new Vector2(-d,0),new Vector2(-d,-d),new Vector2(0,-d),new Vector2(d,-d)};
        //     foreach(Vector2 dir in directions){
        //         if(Physics2D.Raycast(transform.position,dir,d)==null){
        //             Instantiate(wall,transform.position+new Vector3(dir.x,dir.y,0),new Quaternion(0,0,0,0));
        //         }
        //     }
        //     walled=true;
        // }
    }
}
