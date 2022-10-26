using System;

namespace RestaurantPicker // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            class AmericanFoodScript
{

     List<RestaurantClasses> AmerRestaurants = new List<RestaurantClasses>();
     TextMeshProUGUI AmerDisplayTxt;
    System.Random AmerRest = new System.Random();
    int rndAmer;
    int i = 0;


    // Start is called before the first frame update
    void Start()
    {
        AmerDisplayTxt.text = AmerRestaurants[0].RestDisplay; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

      void AmerFoodbttn()
    {
        rndAmer = AmerRest.Next(0,AmerRestaurants.Count);
        
        AmerDisplayTxt.text = AmerRestaurants[rndAmer].RestDisplay;
    } 

}

 class ItalianFoodScript
{

     List<RestaurantClasses>  ItlRestaurants = new List<RestaurantClasses>();
     TextMeshProUGUI ItlDisplayTxt;
    System.Random ItlRest = new System.Random();
    int rndItl;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        ItlDisplayTxt.text = ItlRestaurants[0].RestDisplay;
    }

      void ItlFoodbttn()
    {
        rndItl = ItlRest.Next(0,ItlRestaurants.Count);

        ItlDisplayTxt.text = ItlRestaurants[rndItl].RestDisplay;
    }
}

 class MexicanFoodScript
{
    List<RestaurantClasses>  MexRestaurants = new List<RestaurantClasses>();
     TextMeshProUGUI MexDisplayTxt;
    System.Random MexRest = new System.Random();
    int rndMex;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        MexDisplayTxt.text = MexRestaurants[0].RestDisplay;
    }
        void MexFoodbttn()
    {
        rndMex = MexRest.Next(0,MexRestaurants.Count);
        MexDisplayTxt.text = MexRestaurants[rndMex].RestDisplay;
    }
}
 class RestaurantPicker
 {
 
     List<RestaurantClasses>AllRestaurants = new List<RestaurantClasses>();
    //added list function tied to my class, RestaurantClasses, list name is All restaurants
    
     TextMeshProUGUI RandDisplayTxt;
    int i = 0;
    int rndAll;
    //added sprites for my background images
     Sprite amerBG;
     Sprite mexBG;
     Sprite itlBG;
     Image BGlayer;
    System.Random randomRest = new System.Random();
    //declared Variables above
   
    



    // Start is called before the first frame update
    void Start()
    {
        //test to display first restaurant element in start function
        RandDisplayTxt.text = AllRestaurants[0].RestDisplay; 
        // BGlayer.sprite = mexBG;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
//below function was created to allow SceneChanges, and to connect the function to our Unity Side
     void SceneChange (string RestScene)
    {
    SceneManager.LoadScene(RestScene);
    }

//function to generate random food from all 3 restaurant categories
     void AllFoodbttn()
    {
        

        rndAll = randomRest.Next(0,AllRestaurants.Count);

        RandDisplayTxt.text = AllRestaurants[rndAll].RestDisplay;

        BGchange(rndAll);
        //Called function BGchange, and passed in variable rndAll
        
       
    }  
    //created a function for background change and passed in/declared a variable (rndAll) with data type int
    void BGchange (int rndAll)
    {
         if( rndAll <= 9)
        {//if rndAll is les than or equal to 9, will display Mexican Food Background image
            BGlayer.sprite = mexBG;
        }
        else if (rndAll>=10 && rndAll<= 19)
        { //if rndAll is greater than or equal to 10, and less than or equal to 19, will display Italian Food Background image
            BGlayer.sprite = itlBG;
        }
        else
        {//else if all above are false, will display American food Background
            BGlayer.sprite = amerBG;
        }
    }


}


            Console.WriteLine("Hello World!");
        }
    }
}









