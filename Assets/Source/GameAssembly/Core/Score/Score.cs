using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ExecutionOrderClickerTask.GameAssembly
{
    public class Score
    {
        public int Value { get; private set; }

        public System.Action<int> OnValueChanged;

        public Score(ScoreConfig scoreConfig)
        {
            SetValue(scoreConfig.InitialScore);
        }

        public void SetValue(int newValue)
        {
            if (newValue == Value) return;
            OnValueChanged?.Invoke(newValue);
            Value = newValue;
        }

        public void IncrementValue(int increment)
        {
            SetValue(Value + increment);
        }
    }
}
