using Microsoft.VisualStudio.TestTools.UnitTesting;
using SR5Initiative;
using System;

namespace SR5Initiative.Tests
{
    [TestClass]
    public class CombatantTests
    {
        [TestMethod]
        public void AddInitiative_NegativeCount_ThrowsException()
        {
            //Arrange
            Combatant combatant = new();
            combatant.InitiativeScore = 1;

            //Act => Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => combatant.AddInitiative(-1));
        }

        [TestMethod]
        public void AddInitiative_ZeroCount_ThrowsException()
        {
            //Arrange
            Combatant combatant = new();
            combatant.InitiativeScore = 1;

            //Act => Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => combatant.AddInitiative(0));
        }

        [TestMethod]
        public void AddInitiative_PositiveCount_IncreasesInitiativeSuccessfully()
        {
            //Arrange
            Combatant combatant = new();
            int initial = 1;
            combatant.InitiativeScore = initial;

            //Act
            combatant.AddInitiative(1);

            //Assert
            int actual = combatant.InitiativeScore;
            Assert.IsTrue(actual > initial);
        }

        [TestMethod]
        public void SubtractInitiative_LessThanZero_ReturnsZero()
        {
            //Arrange
            Combatant combatant = new();
            combatant.InitiativeScore = 1;

            //Act
            combatant.SubtractInitiative(10);

            //Assert
            int initiative = combatant.InitiativeScore;
            Assert.AreEqual(0, initiative);
        }

        [TestMethod]
        public void RollInitiative_ReturnsGreaterThanZero()
        {
            // Arrange
            Combatant combatant = new();
            combatant.Reaction = 1;
            combatant.Intuition = 1;
            combatant.InitiativeDice = 1;

            //Act
            int initiative = combatant.RollInitiative();

            //Assert
            Assert.IsTrue(initiative > 0);
        }

        [TestMethod]
        public void CssClass_ReturnsNonEmptyString()
        {
            //Arrange
            Combatant combatant = new();

            //Act
            string result = combatant.CssClass();

            //Assert
            Assert.IsFalse(String.IsNullOrEmpty(result));
        }

        [TestMethod]
        public void CssClass_PlayerCharacter_ReturnsDifferentClass()
        {
            //Arrange
            Combatant npc = new();
            npc.IsPlayerCharacter = false;
            npc.InitiativeScore = 1;
            Combatant pc = new();
            pc.IsPlayerCharacter = true;
            pc.InitiativeScore = 1;

            //Act
            string npcClass = npc.CssClass();
            string pcClass = pc.CssClass();

            //Assert
            Assert.AreNotEqual(npcClass, pcClass);
        }

        [TestMethod]
        public void CssClass_HostileCharacter_ReturnsDifferentClass()
        {
            //Arrange
            Combatant notHostile = new();
            notHostile.IsHostile = false;
            notHostile.InitiativeScore = 1;
            Combatant hostile = new();
            hostile.IsHostile = true;
            hostile.InitiativeScore = 1;

            //Act
            string notHostileClass = notHostile.CssClass();
            string hostileClass = hostile.CssClass();

            //Assert
            Assert.AreNotEqual(notHostileClass, hostileClass);

        }
    }
}
