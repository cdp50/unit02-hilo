using System;
using System.Collections.Generic;

namespace unit02_hilo
{
    class Dealer
    {
        // atributes
        public int _card1=0;
        public int _card2=0;
        public string status="";

        public string _playersbet="";
        public int _score=0;

    // constructor
    public Dealer(){} 
     
        //methods 
        public void points_decision()
        {
            if (_card2 > _card1){
                status = "h";

            }else if (_card2 < _card1){
                status = "l";
            }
            if (_playersbet == status){
                _score += 100; 

            }else if (_playersbet != status){
                _score -= 75;
            }
        }
    }
    }

    
  
        
   
       


