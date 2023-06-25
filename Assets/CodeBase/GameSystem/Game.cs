using System;
using UnityEngine;

namespace CodeBase.GameSystem
{
    public class Game : MonoBehaviour
    {
        private GameState _state = GameState.Loading;

        public event Action LoadingStarted;

        public event Action HandSelectionStarted;
        
        public event Action PlayingStarted;
        
        public event Action Finished;

        private void Start()
        {
            LoadingStarted?.Invoke();
        }

        public void StartHandSelecting()
        {
            _state = GameState.HandSelecting;
            HandSelectionStarted?.Invoke();
        }

        public void StartPlaying()
        {
            _state = GameState.Playing;
            PlayingStarted?.Invoke();
        }

        public void Finish()
        {
            _state = GameState.Finished;
            Finished?.Invoke();
        }
    }
}