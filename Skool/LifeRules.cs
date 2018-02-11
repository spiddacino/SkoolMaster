﻿using System;

namespace Skool
{
	public enum CellState
	{
		Alive,Dead,
	}
	public class LifeRules
	{
		public static CellState GetNewState(CellState currentState, int liveNeighbours)
		{
			switch (currentState)
			{
				case CellState.Alive:
					if (liveNeighbours < 2 || liveNeighbours > 3)
						return CellState.Dead;
					break;
				case CellState.Dead:
					if (liveNeighbours == 3)
						return CellState.Alive;
					break;
			}
			return currentState;
		}
	}
}
