using System;
using System.Collections.Generic;
using System.Text;

namespace Unity
{
    public interface IGame
    {
        string Name { get; }
        int CurrentPlayers { get; }
        int MinPlayers { get; }
        int MaxPlayers { get; }
        void AddPlayer();
        void RemovePlayer();
        void Play();
        string Result();
    }
}

