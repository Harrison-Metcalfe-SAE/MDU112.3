using UnityEngine;
using System.Collections;

public class cube : MonoBehaviour {

    // Spawn Point for Block Type
    public GameObject AnchorPoint;

	public float selectedPrefab = 2f;

    public GameObject PrefabToSpawn;

	public GameObject SecondPrefabToSpawn;

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
			//if(selectedPrefab == 1f){
            // Spawn the block type
            AttachedBuilding = GameObject.Instantiate(PrefabToSpawn);

            // Spawn at anchor point
            AttachedBuilding.transform.position = AnchorPoint.transform.position;
            AttachedBuilding.transform.SetParent(AnchorPoint.transform);
			}
        /*
			else{
				if(selectedPrefab == 2f){
					// Spawn the block type 2
					AttachedBuilding = GameObject.Instantiate(SecondPrefabToSpawn);
				
					// Spawn at anchor point
					AttachedBuilding.transform.position = AnchorPoint.transform.position;
					AttachedBuilding.transform.SetParent(AnchorPoint.transform);
			}*/
        }
   
        
   }
