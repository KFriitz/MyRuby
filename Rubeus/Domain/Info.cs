using System;

namespace Myruby.Domain
{
    public static class Info
    {
        public static void ShowLogo()
        {
            string mylogo = @"                                                                                
                 ################.                
             #######################              
          ###########        *###                 
        .#######*                      .##        
       #######                       ######       
      *######           .##  *###    #######      
      ######          #####%##        ######      
      ######       *###  #####        ######,     
      ######     ###     ##  ###      ######      
       ######                        #######      
       ,#####                       #######       
         ##                      %#######,        
                 #####*     ###########(          
              ######################%             
                  ##############.                                                            
";
            Console.WriteLine(mylogo);
            Console.WriteLine(" MyRuby vX.X.X \r\n");
        }

        public static void ShowUsage()
        {
            string usage = @"
############### READ THE FUCKIN MANUAL ###############
";
            Console.WriteLine(usage);
        }
    }
}
