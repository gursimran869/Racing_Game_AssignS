using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing_Game_AssignS
{
  public class calculateBudget
    {
       
        //this code is used to set the budget of the player after playing the game like winner get the amount 
        //looser los the amount from his budget 
        public int BudgetCal(int rat,int amount,int budget,int winner) {
            if (rat == winner)
            {
                budget = budget + amount;
                return budget;
            }
            else {
                budget = budget - amount;
                return budget;
            }      
        }   

    }
}
