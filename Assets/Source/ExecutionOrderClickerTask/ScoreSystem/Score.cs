using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ExecutionOrderClickerTask.ScoreSystem
{
    public class Score
    {
        private int value;

        public int Value 
        {
            get => value;
            set
            {
                if (this.value == value) return;
                this.value = value;
                OnValueChanged?.Invoke(this.value);
            }
        }

        public System.Action<int> OnValueChanged;

        public Score(ScoreConfig scoreConfig)
        {
            Value = scoreConfig.InitialScore;
        }

        public void IncrementValue(int increment)
        {
            Value += increment;
        }
    }
}
