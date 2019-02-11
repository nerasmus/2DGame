using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class functions : MonoBehaviour {

	public string weather;

	void start(){
		Weather(weather);
	}

	void  Weather(string weatherstate){

		if(weatherstate == "sunny"){
			print("the sun is shining today");
		}
		else if(weatherstate == "raining"){
			print("it is soggy");
		}
			else if(weatherstate == "windy"){
			print("it is windy");
		}	
		else if(weatherstate == "snowing"){
			print("it is a blizzard out there");
		}	
		else if(weatherstate == "foggy"){
			print("i can't see");
		}
			else{
				print("i don't understand"+ weatherstate);
			}

	}
}
