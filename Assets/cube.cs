using UnityEngine;
using System.Collections;

public class cube : MonoBehaviour {

    // Spawn Point for Block Type
    public GameObject AnchorPoint;


    public GameObject PrefabToSpawn;


    private GameObject AttachedBuilding = null;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void ReactToMouseClick()
    {

        //Is there a building?
        if(AttachedBuilding != null)
        {
            GameObject.Destroy(AttachedBuilding);
            AttachedBuilding = null;
        }
        else
        {
            // Spawn the block type
            AttachedBuilding = GameObject.Instantiate(PrefabToSpawn);

            // Spawn at anchor point
            AttachedBuilding.transform.position = AnchorPoint.transform.position;
            AttachedBuilding.transform.SetParent(AnchorPoint.transform);
        }
   
        
    }
}
