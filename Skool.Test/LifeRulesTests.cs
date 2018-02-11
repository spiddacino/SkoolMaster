using System;
using NUnit.Framework;

namespace Skool.Test
{
	[TestFixture]
	public class LifeRulesTests
	{
		[Test]
		public void LiveCell_FewerThan2LiveNeighbours_Dies()
		{
			var currentState = CellState.Alive;
			var liveNeighbours = 0;

			CellState newState = LifeRules.GetNewState(currentState, liveNeighbours);                       
			Assert.AreEqual(CellState.Dead,newState);
		}

		[Test]
		public void DeadCell_Exactly3LiveNeighbours_Lives()
		{
			var currentState = CellState.Dead;
			var liveNeighbours = 3;
			CellState newState = LifeRules.GetNewState(currentState, liveNeighbours);
			Assert.AreEqual(CellState.Alive, newState);

		}

		[Test]
		public void DeadCell_FewerThan3LiveNeighbours_StayDead(
			[Range(0, 2)] int liveNeighbours)
		{
			var currentState = CellState.Dead;
			CellState newState = LifeRules.GetNewState(currentState, liveNeighbours);
			Assert.AreEqual(CellState.Dead, newState);

		}

		[Test]
		public void DeadCell_MoreThan3LiveNeighbours_StayDead([Range(4, 8)] int liveNeighbours)
		{
			var currentState = CellState.Dead;
			CellState newState = LifeRules.GetNewState(currentState, liveNeighbours);
			Assert.AreEqual(CellState.Dead, newState);

		}
	}
}
