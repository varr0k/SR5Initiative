using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SR5Initiative
{
    public class Combatant
    {
        public Guid Id { get; set; }
        public string DisplayName { get; set; }
        public int InitiativeScore { get; set; }
        public int InitiativeModifier { get; set; }
        public bool IsPlayerCharacter { get; set; }
        public bool IsHostile { get; set; }
        public int Edge { get; set; }
        public int Reaction { get; set; }
        public int Intuition { get; set; }
        public bool IsActive() => InitiativeScore > 0;
        public int NumberOfPhases() => IsActive() ? (InitiativeScore / 10) + 1 : 0;

        public void AddInitiative(int count)
        {
            InitiativeScore += count;
        }

        public void SubtractInitiative(int count)
        {
            InitiativeScore -= count;
            if (InitiativeScore < 0)
            {
                InitiativeScore = 0;
            }
        }

        public string CssClass()
        {
            string cssClass = "list-group-item";
            if (IsActive())
            {
                if (IsPlayerCharacter)
                {
                    cssClass += " list-group-item-primary";
                }
                else
                {
                    if (IsHostile)
                    {
                        cssClass += " list-group-item-danger";
                    }
                    else
                    {
                    }

                }
            }
            else
            {
                cssClass += " list-group-item-secondary";
            }

            return cssClass;
        }
    }
}
