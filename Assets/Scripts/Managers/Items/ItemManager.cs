﻿using UnityEngine;

namespace VoidInc
{
	public class ItemManager : MonoBehaviour
	{
		/// <summary>
		/// The item type enum to determine the item function.
		/// </summary>
		public enum _ItemType
		{
			Coin1,
			Coin5,
			Coin10,
			Gem,
			Key
		}

		/// <summary>
		/// If the item has been destroyed.
		/// </summary>
		[HideInInspector]
		public bool Destroyed;

		/// <summary>
		/// What type of item is the item.
		/// </summary>
		public _ItemType ItemType;

		/// <summary>
		/// The identifier for keys to open locks and for locks to be opened by keys.
		/// </summary>
		public string Identifier;

		/// <summary>
		/// The key id to check the identifier with.
		/// </summary>
		public int KeyID;

		/// <summary>
		/// The GameManager class for the items.
		/// </summary>
		[HideInInspector]
		private GameManager _GameController;

		void Awake()
		{
			_GameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
		}

		public void RemoveItem()
		{
			switch (ItemType)
			{
				case _ItemType.Coin1:
					RemoveCoin(100);
					break;
				case _ItemType.Coin5:
					RemoveCoin(500);
					break;
				case _ItemType.Coin10:
					RemoveCoin(1000);
					break;
				case _ItemType.Gem:
					RemoveGem(8000);
					break;
				case _ItemType.Key:
					RemoveKey();
					break;
				default:
					break;
			}
		}

		private void RemoveCoin(int score)
		{
			_GameController.DestroyedGameObjects.Add(gameObject);
			Destroy(gameObject);
			_GameController.Score += score;
		}

		private void RemoveGem(int score)
		{
			_GameController.DestroyedGameObjects.Add(gameObject);
			Destroy(gameObject);
			_GameController.Score += score;
			_GameController.Gems += 1;
			_GameController.TotalGems += 1;
		}


		private void RemoveKey()
		{
			_GameController.DestroyedGameObjects.Add(gameObject);
			Destroy(gameObject);
			_GameController.Keys += 1;
			_GameController.KeyIdentifiers.Add(KeyID, Identifier);
		}
	}
}