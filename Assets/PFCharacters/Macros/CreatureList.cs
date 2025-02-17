using UnityEngine;
using System.Collections.Generic;
namespace PFCharacters.Macros
{
	[CreateAssetMenu]
	[SerializeField]
	class CreatureList : ScriptableObject
	{
		public List<CreatureSetting> creatures = new List<CreatureSetting>();
	}
}