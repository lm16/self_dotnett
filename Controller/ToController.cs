using Microsoft.AspNetCore.Mvc;

namespace asp.controller{
    
    [Route("[controller]/[action]")]
    public class ToController{
        
        public string A(){
            return "Good a";
        }

        public string B(){
            return "Good b";
        }

        public string C(){
            return "Good c";
        }
        
    }
}