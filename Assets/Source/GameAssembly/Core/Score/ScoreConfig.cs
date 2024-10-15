using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ExecutionOrderClickerTask.GameAssembly
{
    [CreateAssetMenu(fileName = "New Score Config", menuName = "Score Config", order = 51)]
    public class ScoreConfig : ScriptableObject
    {
        [field: SerializeField]
        public int InitialScore { get; private set; } = 5;
    }
}
