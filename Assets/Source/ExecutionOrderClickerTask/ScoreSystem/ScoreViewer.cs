using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Zenject;

namespace ExecutionOrderClickerTask.ScoreSystem
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class ScoreViewer : MonoBehaviour
    {
        private TextMeshProUGUI counter;

        private Score score;

        private void Awake()
        {
            counter = GetComponent<TextMeshProUGUI>();
        }

        private void Start()
        {
            UpdateCounter(score.Value);
            score.OnValueChanged += OnScoreChangedHandler;
        }

        [Inject]
        public void Construct(Score score)
        {
            this.score = score;
        }

        private void OnScoreChangedHandler(int newValue)
        {
            UpdateCounter(newValue);
        }

        private void UpdateCounter(int newValue)
        {
            counter.text = "Score: " + newValue.ToString();
        }
    }
}
