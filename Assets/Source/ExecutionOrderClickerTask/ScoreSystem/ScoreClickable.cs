using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using Zenject;

namespace ExecutionOrderClickerTask.ScoreSystem
{
    using Clicks;

    public class ScoreClickable : MonoBehaviour, IClickable
    {
        [SerializeField]
        private int scoreIncrement = 1;

        private Score score;

        [Inject]
        public void Construct(Score score)
        {
            this.score = score;
        }

        public void Click()
        {
            score.IncrementValue(scoreIncrement);
        }
    }
}
