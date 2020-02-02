using UnityEngine;

public class ItemPickup : MonoBehaviour {
	private InventoryUI inventory;
	public GameObject itemButton;

	private void Start() 
	{
		//inventory= GameObject.FindGameObjectsWithTag("Player").GetComponent<InventoryUI>();

	}


	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			for(int i = 0; i < inventory.slots.Length; i++)
			{
				if(inventory.isFull[i] == false)
				{
					inventory.isFull[i] = true;
					Instantiate(itemButton, inventory.slots[i].transform, false);
					Destroy(gameObject);
					break;
				}
			}
		}
	}
}