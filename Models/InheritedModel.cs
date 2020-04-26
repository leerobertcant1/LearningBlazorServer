using Microsoft.AspNetCore.Components;

namespace LearningBlazorServer.Models
{
    public class InheritedModel : ComponentBase
    {
        public string InheritedData 
        { 
            get 
            { 
                return "this is inherited data"; 
            } 
        }


    }
}
